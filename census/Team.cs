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

namespace census
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            
            
        }

        private void Team_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            String a;
            String b;
            a=tbLogin.Text;
            b=tbPassword.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "admin" & tbPassword.Text == "admin")
            {
                addmember datainput = new addmember();
                datainput.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("enter correct cnic and password");
            }   


            if (tbLogin.Text == null || tbPassword.Text == null)
            {
                MessageBox.Show("enter CNic and password");

            }
            else
            {
                
            }
        }

    }
}
