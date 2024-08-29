namespace CoinKeeper
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cb_network = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.lb_address = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.lb_balance = new Sunny.UI.UILabel();
            this.btn_refresh = new Sunny.UI.UIButton();
            this.btn_login = new Sunny.UI.UIButton();
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.tb_tokenaddress = new Sunny.UI.UITextBox();
            this.btn_remove = new Sunny.UI.UIButton();
            this.btn_add = new Sunny.UI.UIButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TransactionHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.tb_gasprice = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.tb_gas = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.tb_amount = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cb_token = new Sunny.UI.UIComboBox();
            this.tb_toaddress = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.btn_send = new Sunny.UI.UIButton();
            this.lb_msg = new Sunny.UI.UILabel();
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(574, 580);
            this.btn.Margin = new System.Windows.Forms.Padding(2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(98, 35);
            this.btn.TabIndex = 0;
            this.btn.Text = "TestButton";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(19, 13);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(153, 31);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "NetWork:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_network
            // 
            this.cb_network.DataSource = null;
            this.cb_network.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cb_network.FillColor = System.Drawing.Color.White;
            this.cb_network.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_network.IsScaled = false;
            this.cb_network.Items.AddRange(new object[] {
            "Eth-Sepolia"});
            this.cb_network.Location = new System.Drawing.Point(186, 13);
            this.cb_network.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_network.MinimumSize = new System.Drawing.Size(42, 0);
            this.cb_network.Name = "cb_network";
            this.cb_network.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_network.Radius = 15;
            this.cb_network.Size = new System.Drawing.Size(137, 31);
            this.cb_network.TabIndex = 2;
            this.cb_network.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(19, 67);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(153, 31);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "Account Address:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_address
            // 
            this.lb_address.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_address.Location = new System.Drawing.Point(182, 67);
            this.lb_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(475, 31);
            this.lb_address.TabIndex = 4;
            this.lb_address.Text = "null";
            this.lb_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(19, 125);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(153, 31);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "Balance(Eth):";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_balance
            // 
            this.lb_balance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_balance.Location = new System.Drawing.Point(182, 125);
            this.lb_balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(475, 31);
            this.lb_balance.TabIndex = 6;
            this.lb_balance.Text = "0";
            this.lb_balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_refresh.IsScaled = false;
            this.btn_refresh.Location = new System.Drawing.Point(370, 13);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Radius = 30;
            this.btn_refresh.Size = new System.Drawing.Size(85, 31);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.IsScaled = false;
            this.btn_login.Location = new System.Drawing.Point(572, 13);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_login.Name = "btn_login";
            this.btn_login.Radius = 30;
            this.btn_login.Size = new System.Drawing.Size(85, 31);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Controls.Add(this.tabPage2);
            this.uiTabControlMenu1.Controls.Add(this.tabPage3);
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 200);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(8, 184);
            this.uiTabControlMenu1.Margin = new System.Windows.Forms.Padding(2);
            this.uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(678, 381);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControlMenu1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TabIndex = 9;
            this.uiTabControlMenu1.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiTabControlMenu1.TabSelectedForeColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TabSelectedHighColor = System.Drawing.Color.DodgerBlue;
            this.uiTabControlMenu1.TabUnSelectedForeColor = System.Drawing.Color.DarkGray;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.uiTableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(477, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Token";
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 3;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.uiTableLayoutPanel2.Controls.Add(this.tb_tokenaddress, 0, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.btn_remove, 2, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.btn_add, 1, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 2;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(477, 381);
            this.uiTableLayoutPanel2.TabIndex = 0;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // tb_tokenaddress
            // 
            this.tb_tokenaddress.ButtonSymbol = 61761;
            this.tb_tokenaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tokenaddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_tokenaddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_tokenaddress.IsScaled = false;
            this.tb_tokenaddress.Location = new System.Drawing.Point(4, 355);
            this.tb_tokenaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_tokenaddress.Maximum = 2147483647D;
            this.tb_tokenaddress.Minimum = -2147483648D;
            this.tb_tokenaddress.MinimumSize = new System.Drawing.Size(1, 11);
            this.tb_tokenaddress.Name = "tb_tokenaddress";
            this.tb_tokenaddress.Radius = 15;
            this.tb_tokenaddress.Size = new System.Drawing.Size(299, 21);
            this.tb_tokenaddress.TabIndex = 23;
            this.tb_tokenaddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_remove
            // 
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_remove.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_remove.IsScaled = false;
            this.btn_remove.Location = new System.Drawing.Point(394, 352);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Radius = 30;
            this.btn_remove.Size = new System.Drawing.Size(81, 27);
            this.btn_remove.TabIndex = 20;
            this.btn_remove.Text = "Remove";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.IsScaled = false;
            this.btn_add.Location = new System.Drawing.Point(309, 352);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_add.Name = "btn_add";
            this.btn_add.Radius = 30;
            this.btn_add.Size = new System.Drawing.Size(81, 27);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Balance});
            this.uiTableLayoutPanel2.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(471, 344);
            this.dataGridView1.TabIndex = 22;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            this.Symbol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Symbol.Width = 150;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Balance.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(201, 0);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(477, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transaction";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionHash});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.Color.Silver;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(477, 381);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // TransactionHash
            // 
            this.TransactionHash.HeaderText = "TransactionHash";
            this.TransactionHash.Name = "TransactionHash";
            this.TransactionHash.ReadOnly = true;
            this.TransactionHash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TransactionHash.Width = 360;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.uiTableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(201, 0);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(477, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Send";
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel6, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_gasprice, 1, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel4, 0, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_gas, 1, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel8, 0, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_amount, 1, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel5, 0, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.cb_token, 1, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_toaddress, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel7, 0, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.btn_send, 1, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_msg, 0, 5);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 7;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(477, 381);
            this.uiTableLayoutPanel1.TabIndex = 19;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(2, 0);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(129, 33);
            this.uiLabel6.TabIndex = 12;
            this.uiLabel6.Text = "ToAddress:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_gasprice
            // 
            this.tb_gasprice.ButtonSymbol = 61761;
            this.tb_gasprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_gasprice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_gasprice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_gasprice.IsScaled = false;
            this.tb_gasprice.Location = new System.Drawing.Point(137, 137);
            this.tb_gasprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_gasprice.Maximum = 2147483647D;
            this.tb_gasprice.Minimum = -2147483648D;
            this.tb_gasprice.MinimumSize = new System.Drawing.Size(1, 11);
            this.tb_gasprice.Name = "tb_gasprice";
            this.tb_gasprice.Radius = 15;
            this.tb_gasprice.Size = new System.Drawing.Size(336, 23);
            this.tb_gasprice.TabIndex = 18;
            this.tb_gasprice.Text = "default";
            this.tb_gasprice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(2, 33);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(129, 33);
            this.uiLabel4.TabIndex = 10;
            this.uiLabel4.Text = "Token:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_gas
            // 
            this.tb_gas.ButtonSymbol = 61761;
            this.tb_gas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_gas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_gas.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_gas.IsScaled = false;
            this.tb_gas.Location = new System.Drawing.Point(137, 104);
            this.tb_gas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_gas.Maximum = 2147483647D;
            this.tb_gas.Minimum = -2147483648D;
            this.tb_gas.MinimumSize = new System.Drawing.Size(1, 11);
            this.tb_gas.Name = "tb_gas";
            this.tb_gas.Radius = 15;
            this.tb_gas.Size = new System.Drawing.Size(336, 23);
            this.tb_gas.TabIndex = 16;
            this.tb_gas.Text = "default";
            this.tb_gas.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(2, 132);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(129, 33);
            this.uiLabel8.TabIndex = 17;
            this.uiLabel8.Text = "Gas Price:";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_amount
            // 
            this.tb_amount.ButtonSymbol = 61761;
            this.tb_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_amount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_amount.IsScaled = false;
            this.tb_amount.Location = new System.Drawing.Point(137, 71);
            this.tb_amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_amount.Maximum = 2147483647D;
            this.tb_amount.Minimum = -2147483648D;
            this.tb_amount.MinimumSize = new System.Drawing.Size(1, 11);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Radius = 15;
            this.tb_amount.Size = new System.Drawing.Size(336, 23);
            this.tb_amount.TabIndex = 14;
            this.tb_amount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(2, 66);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(129, 33);
            this.uiLabel5.TabIndex = 11;
            this.uiLabel5.Text = "Amount:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_token
            // 
            this.cb_token.DataSource = null;
            this.cb_token.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_token.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cb_token.FillColor = System.Drawing.Color.White;
            this.cb_token.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_token.IsScaled = false;
            this.cb_token.Items.AddRange(new object[] {
            "ETH"});
            this.cb_token.Location = new System.Drawing.Point(137, 38);
            this.cb_token.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_token.MinimumSize = new System.Drawing.Size(42, 0);
            this.cb_token.Name = "cb_token";
            this.cb_token.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_token.Radius = 15;
            this.cb_token.Size = new System.Drawing.Size(336, 23);
            this.cb_token.TabIndex = 3;
            this.cb_token.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_toaddress
            // 
            this.tb_toaddress.ButtonSymbol = 61761;
            this.tb_toaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_toaddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_toaddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_toaddress.IsScaled = false;
            this.tb_toaddress.Location = new System.Drawing.Point(137, 5);
            this.tb_toaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_toaddress.Maximum = 2147483647D;
            this.tb_toaddress.Minimum = -2147483648D;
            this.tb_toaddress.MinimumSize = new System.Drawing.Size(1, 11);
            this.tb_toaddress.Name = "tb_toaddress";
            this.tb_toaddress.Radius = 15;
            this.tb_toaddress.Size = new System.Drawing.Size(336, 23);
            this.tb_toaddress.TabIndex = 13;
            this.tb_toaddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(2, 99);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(129, 33);
            this.uiLabel7.TabIndex = 15;
            this.uiLabel7.Text = "Gas:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_send.IsScaled = false;
            this.btn_send.Location = new System.Drawing.Point(390, 348);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_send.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_send.Name = "btn_send";
            this.btn_send.Radius = 30;
            this.btn_send.Size = new System.Drawing.Size(85, 31);
            this.btn_send.TabIndex = 19;
            this.btn_send.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lb_msg
            // 
            this.lb_msg.AutoEllipsis = true;
            this.lb_msg.AutoSize = true;
            this.uiTableLayoutPanel1.SetColumnSpan(this.lb_msg, 2);
            this.lb_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_msg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_msg.Location = new System.Drawing.Point(2, 165);
            this.lb_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(473, 21);
            this.lb_msg.TabIndex = 20;
            this.lb_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 623);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lb_balance);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.cb_network);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "CoinKeeper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cb_network;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel lb_address;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel lb_balance;
        private Sunny.UI.UIButton btn_refresh;
        private Sunny.UI.UIButton btn_login;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UITextBox tb_toaddress;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox cb_token;
        private Sunny.UI.UITextBox tb_amount;
        private Sunny.UI.UITextBox tb_gasprice;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox tb_gas;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIButton btn_send;
        private Sunny.UI.UILabel lb_msg;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIButton btn_remove;
        private Sunny.UI.UIButton btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Sunny.UI.UITextBox tb_tokenaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionHash;
    }
}

