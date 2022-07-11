using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Eclerx.Question2.AshutoshNayak
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Customer ", con))
                {
                    DataTable dt = new DataTable();
                    ds = new DataSet();
                  adapter.Fill(ds, "Customer");
                  DataGridGetData.DataSource = ds.Tables["Customer"];
                   
                   



                }
            }
        }
    }
}
