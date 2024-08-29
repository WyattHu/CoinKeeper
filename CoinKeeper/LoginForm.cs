using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinKeeper
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string privatekey = "";

        private void btn_enter_Click(object sender, EventArgs e)
        {
            privatekey = tb_privatekey.Text;
            base.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
