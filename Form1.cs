using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insta employee = new Insta();

            employee.FirstName = textBox1.Text;
            employee.MidName = textBox2.Text;
            employee.LastName = textBox3.Text;
            employee.StreetOne = textBox4.Text;
            employee.StreetTwo = textBox5.Text;
            employee.PubCity = textBox6.Text;
            employee.PubState = textBox7.Text;
            employee.ZipCode = textBox8.Text;
            employee.PhoneNum = textBox9.Text;
            employee.UserEmail = textBox10.Text;
            employee.UserInsta = textBox11.Text;
            employee.Cell = textBox12.Text;
            employee.AddARecord();


           
           
            
           }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
