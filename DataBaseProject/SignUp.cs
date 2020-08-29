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
using System.Data;
using System.Data.SqlClient;


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

            string userName = txt_Name.Text;
            string userEmail = txt_Email.Text;
            string userPassword = txt_Password.Text;
            string userCountry = txt_Country.Text;


            if (userName.Equals(""))
            {
                MessageBox.Show("Write your user name.");
            }
            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Write your Email.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Write your Password.");
            }
            else if (userCountry.Equals(""))
            {
                MessageBox.Show("Write your country.");
            }
            else
            {


                SqlCommand insertCommand = new SqlCommand("Insert into Users(Name,Email,Password,Country) Values(@userName,@userEmail,@userPassword,@userCountry)");

                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

                int row = ObjDbAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account created successfully,Please login now.");
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
        

       

        

