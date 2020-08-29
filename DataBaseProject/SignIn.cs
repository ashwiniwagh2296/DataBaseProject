using DatabaseProject;
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

namespace DataBaseProject
{
    public partial class SignIn : Form
    {
        public static string id, name, email, password, country;
        dbAccess DbAccess = new dbAccess();
        DataTable dtUsers = new DataTable();
        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_LOGIN_Click(object sender, EventArgs e)
        {
            string userEmail = txt_EmailLogin.Text;
            string userPassword = txt_PasswordLogin.Text;

            if (userEmail.Equals("")) 
            {
                MessageBox.Show("Please enter your Email.");
            }
           else if (userPassword.Equals("")) 
            {
                MessageBox.Show("Please enter your Password.");
            }
            else
            {
                string query = "Select * from Users where Email= '" + userEmail + "'AND password= '" + userPassword + "'";
                DbAccess.readDatathroughAdapter(query, dtUsers);
                if(dtUsers.Rows.Count==1)
                {
                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    country= dtUsers.Rows[0]["Country"].ToString();


                    MessageBox.Show("Congratulation,You are logged in Successfully");
                    DbAccess.closeConn();
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

        private void lbl_CreatAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
          SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
