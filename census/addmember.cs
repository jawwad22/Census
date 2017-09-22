using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace census
{
    public partial class addmember : Form
    {
        string qry;
        public addmember()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CNIC = cnictextbox.Text;
            string Name = nametextbox.Text;
            string Gender = cbMaleFemale.SelectedItem.ToString();
            string Province = cbProvince.SelectedItem.ToString();
            int val = InsertCustomer(CNIC, Name, Gender, Province);
            if (val > 0)
            {
                MessageBox.Show("Data Added");
            }
        }
        public int InsertCustomer(string CNIC, string Name, string Gender, string Province)
        {
            string Query = "Insert into CitizenTable(CNIC,Name,Gender,Province) values('" + CNIC + "','" + Name + "','" + Gender + "','" + Province +"')";
            SqlCommand sc = new SqlCommand(Query, Webpro.GetConnection());
            int Val = sc.ExecuteNonQuery();
            return Val;

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
