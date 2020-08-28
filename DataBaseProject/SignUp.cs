using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataBaseProject
{
    public partial class SignUp : Form
    {
        dbAccess ObjDbAccess = new dbAccess();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string UserName = txt_Name.Text;
            string UserEmail = txt_Email.Text;
            string UserPassword = txt_Password.Text;
            string UserCountry = txt_Country.Text;

            if (UserName.Equals(" "))
            {
                MessageBox.Show("Please enter Your user name.");
            }
            else if (UserEmail.Equals(" "))
            {
                MessageBox.Show("Please enter Your  Email.");
            }
            else if (UserPassword.Equals(" "))
            {
                MessageBox.Show("Please enter Your Password.");
            }
            else if (UserCountry.Equals(" "))
            {
                MessageBox.Show("Please enter Your Country.");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("Insert into Users(Name,Email,Password,Country) Values(@UserName,@UserEmail,@UserPassword,@UserCountry)");

                insertCommand.Parameters.AddWithValue("@userName", UserName);
                insertCommand.Parameters.AddWithValue("@userEmail", UserEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", UserPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", UserCountry);

                int row = ObjDbAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account created successfully");
                    this.Hide();

                    HomePage home = new HomePage();
                    home.Show();

                }
                else
                {
                    MessageBox.Show("Error Occured..Try Again");
                }
            }
        }
    }
}

        

