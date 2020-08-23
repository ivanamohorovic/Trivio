using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Trivio_Learn.Forms
{
    public partial class Reading1 : Form
    {
        public Reading1()
        {
            InitializeComponent();
  
        }

        MySqlConnection connection;
        MySqlCommand com;

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reading1_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
            connection.Open();
            string str = "SELECT * FROM reading WHERE id_reading=1 ";
            com = new MySqlCommand(str, connection);
            MySqlDataReader reader = com.ExecuteReader();


            while (reader.Read())
            {
                TextBox txtBox = new TextBox();
                txtBox.Multiline = true;
                txtBox.WordWrap = true;
                txtBox.ReadOnly = true;
                txtBox.Text = reader["reading_text"].ToString();
                txtBox.Size = new System.Drawing.Size(600, 300); 
                txtBox.Visible = true;
                txtBox.Location = new Point(40, 80);
                txtBox.BackColor = Color.FromArgb(50,50,50);
                txtBox.BorderStyle = BorderStyle.None;
                txtBox.Font = new Font("Century Gothic", 13);
                txtBox.ForeColor = Color.DimGray;
                panel1.Controls.Add(txtBox);
               
            }
            connection.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new Reading1_test());

        }
    }
}
