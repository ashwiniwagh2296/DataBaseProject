using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DatabaseProject;

namespace DataBaseProject
{
    public partial class HomePage : Form
    {
        dbAccess objDBAccess = new dbAccess();
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lbl_WelcomUserName.Text = "Welcome: "+ SignIn.name;
            txt_NameHome.Text = SignIn.name;
            txt_EmailHome.Text = SignIn.email;
            txt_PasswordHome.Text = SignIn.password;
            txt_CountryHome.Text = SignIn.country;
        }

        private void btn_UpdateInfo_Click(object sender, EventArgs e)
        {
            string newUserName = txt_NameHome.Text;
            string newUserEmail = txt_EmailHome.Text;
            string newUserPassword = txt_PasswordHome.Text;
            string newUserCountry = txt_CountryHome.Text;

            if(newUserName.Equals(""))
            {
                MessageBox.Show("Please fill user name.");
            }
           else if (newUserEmail.Equals(""))
            {
                MessageBox.Show("Please fill user Email.");
            }
           else if (newUserPassword.Equals(""))
            {
                MessageBox.Show("Please fill user Password.");
            }
           else if (newUserCountry.Equals(""))
            {
                MessageBox.Show("Please fill user County.");
            }
            else
            {
                string qurey = "Update Users SET Name='" + @newUserName + "',Email='" + @newUserEmail + "',Password='" + @newUserPassword + "',Country='" + @newUserCountry + "'where ID='"+SignIn.id+"'";

                SqlCommand updateCommand = new SqlCommand(qurey);

                updateCommand.Parameters.AddWithValue("@userName", @newUserName);
                updateCommand.Parameters.AddWithValue("@userEmail", @newUserEmail);
                updateCommand.Parameters.AddWithValue("@userPassword", @newUserPassword);
                updateCommand.Parameters.AddWithValue("@userCountry", @newUserCountry);

                int row = objDBAccess.executeQuery(updateCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account information updated  successfully");
                    this.Hide();

                    SignIn sign = new SignIn();
                    sign.Show();

                }
                else
                {
                    MessageBox.Show("Error Occured..Try Again");
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog==DialogResult.Yes)
            {
                string query = "DELETE from Users Where ID='" + SignIn.id + "'";
                SqlCommand deleteCommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deleteCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account information deleted  successfully");
                    this.Hide();

                    SignIn sign = new SignIn();
                    sign.Show();

                }
                else
                {
                    MessageBox.Show("Error Occured..Try Again");
                }
            }
        }
    }
}
