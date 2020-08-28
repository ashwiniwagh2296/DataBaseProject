using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lbl_WelcomUserName.Text = SignIn.name;
            txt_NameHome.Text = SignIn.name;
            txt_EmailHome.Text = SignIn.email;
            txt_PasswordHome.Text = SignIn.password;
            txt_CountryHome.Text = SignIn.country;
        }
    }
}
