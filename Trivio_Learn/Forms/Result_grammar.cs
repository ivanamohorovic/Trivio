using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trivio_Learn.Forms
{
    public partial class Result_grammar : Form
    {
        public Result_grammar()
        {
            InitializeComponent();
        }

        MySqlConnection connection;

        string saveGraph;

        string saveVerb_number;

        Label[] lbl = new Label[10];

        public void graph(string getResult)
        {
            saveGraph = getResult;
        }

        public void verb_number(string getResult)
        {
            saveVerb_number = getResult;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            Convert.ToInt32(saveGraph);
            int novo = Convert.ToInt32(saveGraph);

            int brojrecenica = Int32.Parse(saveVerb_number);

            decimal postotak = ((decimal)novo / (decimal)(brojrecenica)) * 100m;

            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;
            circularProgressBar2.Text = string.Format("{0:0.00}", postotak);

            for (int i = 1; i < 100; i++)
            {
                circularProgressBar2.Value = Convert.ToInt32(postotak);
                circularProgressBar2.Update();
            }

            connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sentence where id_tenses = 1", connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            int counter = 0;
            int space = 0;

            while (reader.Read())
            {
                lbl[counter] = new Label();
                lbl[counter].Text = reader["full_sentence"].ToString();
                lbl[counter].AutoSize = true;
                lbl[counter].Visible = true;
                lbl[counter].Location = new Point(40, 10 + space);
                lbl[counter].Font = new Font("Century Gothic", 14);
                lbl[counter].ForeColor = Color.MediumSeaGreen;
                panelResult.Controls.Add(lbl[counter]);

                space += 40;
                counter++;

            }
            reader.Close();
            connection.Close();

        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
