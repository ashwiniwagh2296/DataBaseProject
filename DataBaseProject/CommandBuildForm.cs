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

namespace DataBaseProject
{
    public partial class CommandBuildForm : Form
    {
        dbAccess objdbAccess = new dbAccess();
        DataTable dtUsers = new DataTable();
        public CommandBuildForm()
        {
            InitializeComponent();
        }

        private void CommandBuildForm_Load(object sender, EventArgs e)
        {
            string query = "Select * from Users";
            objdbAccess.readDatathroughAdapter(query, dtUsers);
            dataGridView1.DataSource = dtUsers;
            objdbAccess.closeConn();
        }

        private void btn_PerformOperation_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users";
            int changes = objdbAccess.executeDataAdapter(dtUsers, query);
            MessageBox.Show("count = " + changes);
        }
    }
}
