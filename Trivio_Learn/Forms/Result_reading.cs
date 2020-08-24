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
    public partial class Result_reading : Form
    {
        public Result_reading()
        {
            InitializeComponent();
        }

        MySqlConnection connection;


        Label[] lbl = new Label[5];
        Label[] lbl2 = new Label[5];


        string saveGraph;
        List<string> saveList;


        public void Graph(string getResult)
        {
            saveGraph = getResult;
        }

     
        public void Lista(List<string> getResult)
        {
            saveList = getResult;
        }

        private void Result_reading1_Load(object sender, EventArgs e)
        {
            int novo = Convert.ToInt32(saveGraph);

            int brojrecenica = 5;

            decimal postotak = ((decimal)novo / (decimal)(brojrecenica)) * 100m;

            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;
            circularProgressBar2.Text = string.Format("{0:0.00}", postotak);

            for (int i = 1; i < 100; i++)
            {
                circularProgressBar2.Value = Convert.ToInt32(postotak);
                circularProgressBar2.Update();
            }

            int counter = 0;
            int space = 0;
            foreach (var i in saveList)
            {
                connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM reading_questions WHERE id_question=" + i, connection);
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    lbl[counter] = new Label();
                    lbl[counter].Text = reader["question"].ToString();
                    lbl[counter].AutoSize = true;
                    lbl[counter].Visible = true;
                    lbl[counter].Location = new Point(10, 40 + space);
                    lbl[counter].Font = new Font("Century Gothic", 14);
                    lbl[counter].ForeColor = Color.MediumSeaGreen;
                    panel1.Controls.Add(lbl[counter]);

                    lbl2[counter] = new Label();
                    lbl2[counter].Text = reader["answer"].ToString();
                    lbl2[counter].AutoSize = true;
                    lbl2[counter].Visible = true;
                    lbl2[counter].Location = new Point(20, 70 + space);
                    lbl2[counter].Font = new Font("Calibri", 12);
                    lbl2[counter].ForeColor = Color.DimGray;
                    panel1.Controls.Add(lbl2[counter]);

                    space += 60;
                    counter++;

                }
                reader.Close();
                connection.Close();

            }


        }
    }
}
