namespace Site_Management_System
{
    partial class loginPage
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
            this.loginBTN = new System.Windows.Forms.Button();
            this.passwordTXB = new System.Windows.Forms.TextBox();
            this.usernameTXB = new System.Windows.Forms.TextBox();
            this.adminLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginMa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(112, 131);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(100, 37);
            this.loginBTN.TabIndex = 0;
            this.loginBTN.Text = "LOGIN";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordTXB
            // 
            this.passwordTXB.Location = new System.Drawing.Point(112, 96);
            this.passwordTXB.Name = "passwordTXB";
            this.passwordTXB.Size = new System.Drawing.Size(100, 20);
            this.passwordTXB.TabIndex = 1;
            // 
            // usernameTXB
            // 
            this.usernameTXB.Location = new System.Drawing.Point(112, 60);
            this.usernameTXB.Name = "usernameTXB";
            this.usernameTXB.Size = new System.Drawing.Size(100, 20);
            this.usernameTXB.TabIndex = 2;
            // 
            // adminLogin
            // 
            this.adminLogin.Location = new System.Drawing.Point(163, 191);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(149, 23);
            this.adminLogin.TabIndex = 3;
            this.adminLogin.Text = "LOGIN FOR ADMIN";
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginMa
            // 
            this.LoginMa.Location = new System.Drawing.Point(3, 191);
            this.LoginMa.Name = "LoginMa";
            this.LoginMa.Size = new System.Drawing.Size(154, 23);
            this.LoginMa.TabIndex = 6;
            this.LoginMa.Text = "LOGIN FOR MANAGEMENT";
            this.LoginMa.UseVisualStyleBackColor = true;
            this.LoginMa.Click += new System.EventHandler(this.LoginMa_Click);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 232);
            this.Controls.Add(this.LoginMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.usernameTXB);
            this.Controls.Add(this.passwordTXB);
            this.Controls.Add(this.loginBTN);
            this.Name = "loginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TextBox passwordTXB;
        private System.Windows.Forms.TextBox usernameTXB;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginMa;
    }
}

