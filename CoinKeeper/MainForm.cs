//using Org.BouncyCastle.Math;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Sunny.UI;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace CoinKeeper
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        Web3 w3;
        Account account;
        UserInfo userInfo = new UserInfo();

        private async void button1_Click(object sender, EventArgs e)
        {



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cb_network.SelectedIndex = 0;
            cb_token.SelectedIndex = 0;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if( loginForm.ShowDialog() == DialogResult.OK )
            {
                account = new Account(loginForm.privatekey);
                RefreshInfo();
            }
        }

        private async void RefreshInfo()
        {
            w3 = new Web3(account,"https://eth-sepolia.g.alchemy.com/v2/6AzT7NQNUUj0McvUUFZy4rfQQc7rcfJ_");
            lb_address.Text = account.Address;
            var balance = await w3.Eth.GetBalance.SendRequestAsync(account.Address);
            var value = Web3.Convert.FromWeiToBigDecimal(balance.Value);
            lb_balance.Text = value.ToString();

            if (File.Exists(Application.StartupPath + "/UserInfo/" + account.Address + ".xml"))
            {
                userInfo = XmlSerializerManager<UserInfo>.Deserialize(Application.StartupPath + "/UserInfo/" + account.Address + ".xml");
                dataGridView1.Rows.Clear();
                cb_token.Items.Clear();
                cb_token.Items.Add("ETH");
                cb_token.SelectedIndex = 0;
                for (int i = 0; i < userInfo.tokenAddress.Count; i++)
                {
                    var balanceOfMessage = new BalanceOfFunction() { Owner = account.Address };
                    var queryHandler = w3.Eth.GetContractQueryHandler<BalanceOfFunction>();
                    var tokenbalance = await queryHandler
                        .QueryAsync<BigInteger>(userInfo.tokenAddress[i], balanceOfMessage);
                    var tokenbalance1 = Web3.Convert.FromWeiToBigDecimal(tokenbalance);

                    var symbolMessage = new SymbolFunction() { };
                    var queryHandler1 = w3.Eth.GetContractQueryHandler<SymbolFunction>();
                    var symbol = await queryHandler1
                        .QueryAsync<string>(userInfo.tokenAddress[i], symbolMessage);

                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = symbol;
                    row.Cells.Add(cell);
                    DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                    cell2.Value = tokenbalance1;
                    row.Cells.Add(cell2);
                    dataGridView1.Rows.Add(row);

                    cb_token.Items.Add(symbol);
                }

                dataGridView2.Rows.Clear();
                for (int i = 0; i < userInfo.transactionHash.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = userInfo.transactionHash[i];
                    row.Cells.Add(cell);
                    dataGridView2.Rows.Add(row);
                }
            }
        }

        private void SaveUserInfo()
        {
            XmlSerializerManager<UserInfo>.Serialize(Application.StartupPath + "/UserInfo/" + account.Address + ".xml", userInfo);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            Action myAction = async () => {
                lb_msg.Text = "Sending...";
                TransactionReceipt transaction;
                if (cb_token.SelectedIndex!=0)
                {
                    var transfer = new TransferFunction() { To = tb_toaddress.Text, TokenAmount = Web3.Convert.ToWei(Convert.ToDecimal(tb_amount.Text)) };
                    var transferHandler = w3.Eth.GetContractTransactionHandler<TransferFunction>();
                    transaction = await transferHandler.SendRequestAndWaitForReceiptAsync(userInfo.tokenAddress[cb_token.SelectedIndex-1], transfer);
                }
                else
                {
                    transaction = await w3.Eth.GetEtherTransferService().TransferEtherAndWaitForReceiptAsync(tb_toaddress.Text, Convert.ToDecimal(tb_amount.Text));
                }

                int timeoutCount = 0;
                var txReceipt = await w3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transaction.TransactionHash);
                while (txReceipt == null && timeoutCount < 120000)
                {
                    Thread.Sleep(3000);
                    txReceipt = await w3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transaction.TransactionHash);
                    timeoutCount += 3000;
                }
                if (txReceipt.Status == new HexBigInteger(1))
                {
                    lb_msg.Text = "Transaction Success!\r" +"TransactionHash:"+txReceipt.TransactionHash+"\r"+ "From:" + txReceipt.From + "\r" + "To:" + txReceipt.To + "\r" + "GasLimit:" + txReceipt.GasUsed.ToString() + "\r"
                    + "GasPrice:" + (txReceipt.EffectiveGasPrice.Value / 1000000000).ToString();
                    userInfo.transactionHash.Add(txReceipt.TransactionHash);
                    SaveUserInfo();
                    RefreshInfo();
                }
                else
                {
                    lb_msg.Text = "Transaction Failed!";
                }

            };

            myAction.BeginInvoke(null, null);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(!userInfo.tokenAddress.Contains(tb_tokenaddress.Text))
            {
                userInfo.tokenAddress.Add(tb_tokenaddress.Text);
            }
            SaveUserInfo();
            RefreshInfo();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (userInfo.tokenAddress.Contains(tb_tokenaddress.Text))
            {
                userInfo.tokenAddress.Remove(tb_tokenaddress.Text);
            }
            SaveUserInfo();
            RefreshInfo();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string hash = (string)dataGridView2[0, e.RowIndex].Value;
            System.Diagnostics.Process.Start("https://sepolia.etherscan.io/tx/"+hash);
        }
    }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunction : FunctionMessage
    {
        [Parameter("address", "_owner", 1)] public string Owner { get; set; }
    }

    [Function("symbol", "string")]
    public class SymbolFunction : FunctionMessage
    {
        //[Parameter("address", "_owner", 1)] public string Owner { get; set; }
    }

    [Function("transfer", "bool")]
    public class TransferFunction : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public string To { get; set; }

        [Parameter("uint256", "_value", 2)]
        public BigInteger TokenAmount { get; set; }
    }

    public static class XmlSerializerManager<T>
    {
        private static XmlSerializer factory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static T Deserialize(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                using (XmlReader inputStream = XmlReader.Create(filePath))
                {
                    return Deserialize(inputStream);
                }
            }
            return default(T);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputStream"></param>
        /// <returns></returns>
        public static T Deserialize(XmlReader inputStream)
        {
            if (factory == null)
            {
                factory = new XmlSerializer(typeof(T));
            }
            T t = (T)factory.Deserialize(inputStream);
            return t;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="data"></param>
        public static void Serialize(string filePath, T data)
        {
            using (TextWriter writer = new StreamWriter(filePath))
            {
                Serialize(writer, data);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="outputStream"></param>
        /// <param name="data"></param>
        public static void Serialize(TextWriter outputStream, T data)
        {
            if (factory == null)
            {
                factory = new XmlSerializer(typeof(T));
            }
            factory.Serialize(outputStream, data);
        }
    }
}
