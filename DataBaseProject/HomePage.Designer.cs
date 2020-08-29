namespace DataBaseProject
{
    partial class HomePage
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
            this.btn_UpdateInfo = new System.Windows.Forms.Button();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.txt_CountryHome = new System.Windows.Forms.ComboBox();
            this.txt_PasswordHome = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_EmailHome = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_NameHome = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_WelcomUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_UpdateInfo
            // 
            this.btn_UpdateInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateInfo.ForeColor = System.Drawing.Color.Black;
            this.btn_UpdateInfo.Location = new System.Drawing.Point(145, 384);
            this.btn_UpdateInfo.Name = "btn_UpdateInfo";
            this.btn_UpdateInfo.Size = new System.Drawing.Size(334, 41);
            this.btn_UpdateInfo.TabIndex = 18;
            this.btn_UpdateInfo.Text = "Update my Account Information";
            this.btn_UpdateInfo.UseVisualStyleBackColor = true;
            this.btn_UpdateInfo.Click += new System.EventHandler(this.btn_UpdateInfo_Click);
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.ForeColor = System.Drawing.Color.Black;
            this.lbl_Country.Location = new System.Drawing.Point(23, 321);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(97, 24);
            this.lbl_Country.TabIndex = 17;
            this.lbl_Country.Text = "Country:";
            // 
            // txt_CountryHome
            // 
            this.txt_CountryHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CountryHome.FormattingEnabled = true;
            this.txt_CountryHome.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Belgium",
            "Belize",
            "China",
            "Colombia",
            "Comoros",
            "France",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Japan",
            "Spain",
            "Sri Lanka"});
            this.txt_CountryHome.Location = new System.Drawing.Point(145, 324);
            this.txt_CountryHome.Name = "txt_CountryHome";
            this.txt_CountryHome.Size = new System.Drawing.Size(334, 32);
            this.txt_CountryHome.TabIndex = 16;
            // 
            // txt_PasswordHome
            // 
            this.txt_PasswordHome.Location = new System.Drawing.Point(145, 273);
            this.txt_PasswordHome.Name = "txt_PasswordHome";
            this.txt_PasswordHome.Size = new System.Drawing.Size(334, 20);
            this.txt_PasswordHome.TabIndex = 15;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(23, 269);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(116, 24);
            this.lbl_Password.TabIndex = 14;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_EmailHome
            // 
            this.txt_EmailHome.Location = new System.Drawing.Point(145, 232);
            this.txt_EmailHome.Name = "txt_EmailHome";
            this.txt_EmailHome.Size = new System.Drawing.Size(334, 20);
            this.txt_EmailHome.TabIndex = 13;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.Black;
            this.lbl_Email.Location = new System.Drawing.Point(23, 228);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(72, 24);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "Email:";
            // 
            // txt_NameHome
            // 
            this.txt_NameHome.Location = new System.Drawing.Point(145, 187);
            this.txt_NameHome.Name = "txt_NameHome";
            this.txt_NameHome.Size = new System.Drawing.Size(334, 20);
            this.txt_NameHome.TabIndex = 11;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Name.Location = new System.Drawing.Point(23, 182);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(74, 24);
            this.lbl_Name.TabIndex = 10;
            this.lbl_Name.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(44, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Change account setting";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(612, 252);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(334, 41);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Delete my Account ";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_WelcomUserName
            // 
            this.lbl_WelcomUserName.AutoSize = true;
            this.lbl_WelcomUserName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomUserName.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_WelcomUserName.Location = new System.Drawing.Point(323, 23);
            this.lbl_WelcomUserName.Name = "lbl_WelcomUserName";
            this.lbl_WelcomUserName.Size = new System.Drawing.Size(281, 32);
            this.lbl_WelcomUserName.TabIndex = 21;
            this.lbl_WelcomUserName.Text = "Welcome UserName";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.lbl_WelcomUserName);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_UpdateInfo);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.txt_CountryHome);
            this.Controls.Add(this.txt_PasswordHome);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_EmailHome);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_NameHome);
            this.Controls.Add(this.lbl_Name);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UpdateInfo;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.ComboBox txt_CountryHome;
        private System.Windows.Forms.TextBox txt_PasswordHome;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_EmailHome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_NameHome;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_WelcomUserName;
    }
}