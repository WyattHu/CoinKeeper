namespace CoinKeeper
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tb_privatekey = new Sunny.UI.UITextBox();
            this.btn_enter = new Sunny.UI.UIButton();
            this.btn_cancel = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(57, 68);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(531, 52);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Pls enter ur privatekey...";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_privatekey
            // 
            this.tb_privatekey.ButtonSymbol = 61761;
            this.tb_privatekey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_privatekey.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_privatekey.IsScaled = false;
            this.tb_privatekey.Location = new System.Drawing.Point(57, 187);
            this.tb_privatekey.Maximum = 2147483647D;
            this.tb_privatekey.Minimum = -2147483648D;
            this.tb_privatekey.MinimumSize = new System.Drawing.Size(1, 11);
            this.tb_privatekey.Name = "tb_privatekey";
            this.tb_privatekey.PasswordChar = '*';
            this.tb_privatekey.Size = new System.Drawing.Size(531, 40);
            this.tb_privatekey.TabIndex = 1;
            this.tb_privatekey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_enter
            // 
            this.btn_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_enter.IsScaled = false;
            this.btn_enter.Location = new System.Drawing.Point(150, 271);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_enter.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Radius = 30;
            this.btn_enter.Size = new System.Drawing.Size(112, 51);
            this.btn_enter.TabIndex = 8;
            this.btn_enter.Text = "Enter";
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancel.IsScaled = false;
            this.btn_cancel.Location = new System.Drawing.Point(374, 271);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Radius = 30;
            this.btn_cancel.Size = new System.Drawing.Size(110, 51);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 385);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_privatekey);
            this.Controls.Add(this.uiLabel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox tb_privatekey;
        private Sunny.UI.UIButton btn_enter;
        private Sunny.UI.UIButton btn_cancel;
    }
}