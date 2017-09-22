using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace census
{
    public partial class Teampage : Form
    {
        public Teampage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Teampage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataTable dt = ShowAllData();
            dataGridView1.DataSource = dt;

        }
        public DataTable ShowAllMale()
        {
            string Query = "Select * from CitizenTable where Gender= 'Male'";
            SqlCommand sc = new SqlCommand(Query, Webpro.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }
        public DataTable ShowAllData()
        {
            string Query = "Select * from CitizenTable";
            SqlCommand sc = new SqlCommand(Query, Webpro.GetConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sds = new SqlDataAdapter(sc);
            sds.Fill(dt);
            return dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView1.DataSource = null;
                DataTable dt = ShowAllData();
                dataGridView1.DataSource = dt;
            }
        }

        private void rbShowMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowMale.Checked == true)
            {
                dataGridView1.DataSource = null;
                DataTable dt = ShowAllMale();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
