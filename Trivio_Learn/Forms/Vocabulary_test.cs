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
    public partial class Vocabulary_test : Form
    {

        public static List<string> list;


        public Vocabulary_test()
        {
            InitializeComponent();
            list = new List<string>();

        }

        int space = 0;
        int space2 = 0;
        MySqlConnection connection;

        MySqlCommand com;

        TextBox[] txtBox = new TextBox[10];
        Label[] lbl = new Label[10];
        Label[] lbl2 = new Label[10];
        String[] lblArray = new String[10];

        string saveVocabularyCategoryClick;

        public void VocabularyCategoryClick(string getResult)
        {
            saveVocabularyCategoryClick = getResult;
        }

        IEnumerable<int> UniqueRandom(int minInclusive, int maxInclusive)
        {
            List<int> candidates = new List<int>();
            for (int i = minInclusive; i <= maxInclusive; i++)
            {
                candidates.Add(i);
            }
            Random rnd = new Random();
            while (candidates.Count > 0)
            {
                int index = rnd.Next(candidates.Count);
                yield return candidates[index];
                candidates.RemoveAt(index);
            }
        }



        private void Vocabulary_test_Load_1(object sender, EventArgs e)
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
            connection.Open();
            string str = "SELECT * FROM terms_vocabulary WHERE vocabulary_category='"+saveVocabularyCategoryClick+"' ORDER BY RAND() LIMIT 10";
            com = new MySqlCommand(str, connection);
            MySqlDataReader reader = com.ExecuteReader();

            int counter = 0;

            while (reader.Read())
            {

                txtBox[counter] = new TextBox();
                txtBox[counter].Name = reader["id_term"].ToString();
                txtBox[counter].AutoSize = true;
                txtBox[counter].Visible = true;
                txtBox[counter].Location = new Point(10, 40 + space);
                txtBox[counter].BackColor = Color.FromArgb(70, 70, 70);
                txtBox[counter].BorderStyle = BorderStyle.None;
                txtBox[counter].Font = new Font("Century Gothic", 10);
                txtBox[counter].ForeColor = Color.LightCyan;
                panel1.Controls.Add(txtBox[counter]);

                lbl[counter] = new Label();
                lbl[counter].Text = reader["description"].ToString();
                lbl[counter].AutoSize = true;
                lbl[counter].Visible = true;
                lbl[counter].Location = new Point(120, 40 + space);
                lbl[counter].Font = new Font("Century Gothic", 10);
                lbl[counter].ForeColor = Color.MediumSeaGreen;
                panel1.Controls.Add(lbl[counter]);

                lblArray[counter] = reader["term"].ToString();
                                
                list.Add(reader["id_term"].ToString());
                

                space += 40;
                counter++;
               
            }

            reader.Close();
            connection.Close();

            foreach (int i in UniqueRandom(0, 9))
            {
                lbl2[i] = new Label();
                lbl2[i].Text = lblArray[i];
                lbl2[i].AutoSize = true;
                lbl2[i].Visible = true;
                lbl2[i].TextAlign = ContentAlignment.MiddleCenter;
                lbl2[i].Location = new Point(20 + space2, 10);
                lbl2[i].Font = new Font("Calibri", 8);
                lbl2[i].ForeColor = Color.DimGray;
                panel1.Controls.Add(lbl2[i]);

                space2 += 65;

            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            int correct = 0;

            foreach (Control c in panel1.Controls)
            {
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                {

                    connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");

                    string sql = "SELECT * FROM terms_vocabulary WHERE id_term= '" + c.Name + "' AND term=@Text";
                   

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlParameter[] param = new MySqlParameter[1];
                    param[0] = new MySqlParameter("@Text", c.Text);
                    cmd.Parameters.Add(param[0]);
                    connection.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        correct++;
                        
                    }

                    connection.Close();
                  
                }
            }

            string broj = Convert.ToString(correct);
            Result_vocabulary myResult = new Result_vocabulary();
            myResult.Graph(broj);

            myResult.Lista(list);

            myResult.VocabularyCategory(saveVocabularyCategoryClick);

            myResult.TopLevel = false;
            myResult.FormBorderStyle = FormBorderStyle.None;
            myResult.Dock = DockStyle.Fill;
            panel1.Controls.Add(myResult);
            panel1.Tag = myResult;
            myResult.BringToFront();

            myResult.Show();
        }

    }
}
