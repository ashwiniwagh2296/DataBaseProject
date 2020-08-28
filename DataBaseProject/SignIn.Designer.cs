namespace DataBaseProject
{
    partial class SignIn
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
            this.btn_LOGIN = new System.Windows.Forms.Button();
            this.txt_PasswordLogin = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_EmailLogin = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_CreatAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LOGIN
            // 
            this.btn_LOGIN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LOGIN.ForeColor = System.Drawing.Color.Black;
            this.btn_LOGIN.Location = new System.Drawing.Point(527, 282);
            this.btn_LOGIN.Name = "btn_LOGIN";
            this.btn_LOGIN.Size = new System.Drawing.Size(95, 41);
            this.btn_LOGIN.TabIndex = 15;
            this.btn_LOGIN.Text = "LOGIN";
            this.btn_LOGIN.UseVisualStyleBackColor = true;
            this.btn_LOGIN.Click += new System.EventHandler(this.btn_LOGIN_Click);
            // 
            // txt_PasswordLogin
            // 
            this.txt_PasswordLogin.Location = new System.Drawing.Point(288, 223);
            this.txt_PasswordLogin.Name = "txt_PasswordLogin";
            this.txt_PasswordLogin.Size = new System.Drawing.Size(334, 20);
            this.txt_PasswordLogin.TabIndex = 14;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(165, 218);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(116, 24);
            this.lbl_Password.TabIndex = 13;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_EmailLogin
            // 
            this.txt_EmailLogin.Location = new System.Drawing.Point(288, 182);
            this.txt_EmailLogin.Name = "txt_EmailLogin";
            this.txt_EmailLogin.Size = new System.Drawing.Size(334, 20);
            this.txt_EmailLogin.TabIndex = 12;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.Black;
            this.lbl_Email.Location = new System.Drawing.Point(166, 178);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(72, 24);
            this.lbl_Email.TabIndex = 11;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Black;
            this.lbl_Login.Location = new System.Drawing.Point(163, 60);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(86, 32);
            this.lbl_Login.TabIndex = 10;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_CreatAccount
            // 
            this.lbl_CreatAccount.AutoSize = true;
            this.lbl_CreatAccount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreatAccount.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_CreatAccount.Location = new System.Drawing.Point(371, 335);
            this.lbl_CreatAccount.Name = "lbl_CreatAccount";
            this.lbl_CreatAccount.Size = new System.Drawing.Size(251, 19);
            this.lbl_CreatAccount.TabIndex = 16;
            this.lbl_CreatAccount.Text = "Don\'t have an account created?";
            this.lbl_CreatAccount.Click += new System.EventHandler(this.lbl_CreatAccount_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_CreatAccount);
            this.Controls.Add(this.btn_LOGIN);
            this.Controls.Add(this.txt_PasswordLogin);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_EmailLogin);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Login);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LOGIN;
        private System.Windows.Forms.TextBox txt_PasswordLogin;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_EmailLogin;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_CreatAccount;
    }
}