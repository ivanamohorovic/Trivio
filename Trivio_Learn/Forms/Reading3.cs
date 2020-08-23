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
    public partial class Reading3 : Form
    {
        public Reading3()
        {
            InitializeComponent();
        }

        MySqlConnection connection;
        MySqlCommand com;

        private void Reading3_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
            connection.Open();
            string str = "SELECT * FROM reading WHERE id_reading=3 ";
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
                txtBox.BackColor = Color.FromArgb(50, 50, 50);
                txtBox.BorderStyle = BorderStyle.None;
                txtBox.Font = new Font("Century Gothic", 13);
                txtBox.ForeColor = Color.DimGray;
                panel1.Controls.Add(txtBox);

            }
            connection.Close();
        }
    }
}
