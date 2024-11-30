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

namespace HospitalManagementSystemCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
                if (textBox1.Text == "hanan" || textBox2.Text == "1234")
                {
                    MessageBox.Show("Welcome Admin. You are logged in successfully.");
                    this.Visible = false;
                    Home obj1 = new Home();
                    obj1.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";                 
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password.");
                }
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
