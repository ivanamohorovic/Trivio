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
    public partial class Result_Present_Simple : Form
    {
        public Result_Present_Simple()
        {
            InitializeComponent();
        }

        MySqlConnection connection;

        string saveGraph;

        public void graph (string getResult)
        {
            saveGraph = getResult;
        }


        private void Result_Load(object sender, EventArgs e)
        {
            label1.Text = saveGraph;
            Convert.ToInt32(saveGraph);
            int novo = Convert.ToInt32(saveGraph);

            int brojrecenica = 10;

            var rezultat = brojrecenica - (brojrecenica - novo);
            decimal postotak = ((decimal)novo / (decimal)(brojrecenica)) * 100m;


            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;
            circularProgressBar2.Text = Convert.ToString(postotak);

            for (int i = 1; i <100; i++)
            {
                circularProgressBar2.Value = Convert.ToInt32(postotak);
                circularProgressBar2.Update();
            }

            connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
            connection.Open();

            DataTable dt = new DataTable();
            MySqlCommand sqlCmd = new MySqlCommand("select full_sentence from sentence where id_tenses = 1", connection);

            MySqlDataAdapter sqlDa = new MySqlDataAdapter(sqlCmd);


            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                label1.Text = dt.Rows[0]["full_sentence"].ToString(); 
                label2.Text = dt.Rows[1]["full_sentence"].ToString();
                label3.Text = dt.Rows[2]["full_sentence"].ToString();
                label4.Text = dt.Rows[3]["full_sentence"].ToString();
                label5.Text = dt.Rows[4]["full_sentence"].ToString();
                label6.Text = dt.Rows[5]["full_sentence"].ToString();
                label7.Text = dt.Rows[6]["full_sentence"].ToString();
                label8.Text = dt.Rows[7]["full_sentence"].ToString();
                label9.Text = dt.Rows[8]["full_sentence"].ToString();
                label10.Text = dt.Rows[9]["full_sentence"].ToString();

            }

            connection.Close();

        }

        private void panelResult_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
