using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trivio_Learn.Forms;


namespace Trivio_Learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

      

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Grammar Trivio_Learn = new Grammar();
            Trivio_Learn.Show();
            Visible = false; 
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Vocabulary Trivio_Learn = new Vocabulary();
            Trivio_Learn.Show();
            Visible = false;
        }
    }
}
