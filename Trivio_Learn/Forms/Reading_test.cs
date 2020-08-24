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
    public partial class Reading_test : Form
    {
        public Reading_test()
        {
            InitializeComponent();
            list_reading = new List<string>();
           
        }

        int saveId;

        public void IdReading(int getResult)
        {
            saveId = getResult;
        }


        MySqlConnection connection;

        Label[] lbl = new Label[5];
        Label lblTitle = new Label();
        RadioButton[] radioButton = new RadioButton[5];
        GroupBox[] groupBox = new GroupBox[5];

        string[] wrong_answers = new string[] { };

        public static List<string> list_reading;



        private void Reading1_test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trivio_learnDataSet2.reading_questions' table. You can move, or remove it, as needed.
            this.reading_questionsTableAdapter.Fill(this.trivio_learnDataSet2.reading_questions);

            connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT reading_questions.id_question," +
                " reading_questions.question, reading_questions.id_reading, reading_questions.answer, " +
                "reading_questions.wrong_answers, reading.title FROM reading_questions " +
                "INNER JOIN reading ON reading_questions.id_reading=reading.id_reading " +
                "WHERE reading_questions.id_reading=" + saveId, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            int counter = 0;
            int space = 0;


            while (reader.Read())
            {
                lblTitle = new Label();
                lblTitle.Text = reader["title"].ToString();
                lblTitle.Visible = true;
                lblTitle.AutoSize = true;
                lblTitle.Location = new Point(200, 3);
                lblTitle.Font = new Font("Century Gothic", 34);
                lblTitle.ForeColor = Color.DarkSeaGreen;
                panel1.Controls.Add(lblTitle);


                int[] positions_x = { 10, 180, 360, 510 };

                lbl[counter] = new Label();
                lbl[counter].Text = reader["question"].ToString();
                lbl[counter].AutoSize = true;
                lbl[counter].Visible = true;
                lbl[counter].Location = new Point(10, 70 + space);
                lbl[counter].Font = new Font("Century Gothic", 12);
                lbl[counter].ForeColor = Color.MediumSeaGreen;
                panel1.Controls.Add(lbl[counter]);

                Random rnd = new Random();

                int position_index = rnd.Next(0, positions_x.Length);
                int curr_position = positions_x[position_index];


                groupBox[counter] = new GroupBox();
                radioButton[counter] = new RadioButton();

                if (positions_x[position_index] == 10)
                {
                    radioButton[counter].Checked = true;

                }
                positions_x = positions_x.Where((source, index) => index != position_index).ToArray();

                radioButton[counter].Text = reader["answer"].ToString();
                radioButton[counter].Name = "correct";
                radioButton[counter].Appearance = Appearance.Normal;
                radioButton[counter].AutoCheck = true;
                radioButton[counter].AutoSize = true;
                radioButton[counter].Location = new Point(curr_position, 10);
                groupBox[counter].Location = new Point(0, 90 + space);
                groupBox[counter].Size = new Size(700, 40);
                groupBox[counter].Font = new Font("Microsoft Sans Serif", 9);
                groupBox[counter].ForeColor = Color.DimGray;
                groupBox[counter].FlatStyle = FlatStyle.Flat;
                groupBox[counter].Controls.Add(radioButton[counter]);


                wrong_answers = reader["wrong_answers"].ToString().Split(',');

                foreach (string answer in wrong_answers)
                {

                    Random rnd2 = new Random();
                    position_index = rnd2.Next(0, positions_x.Length);

                    curr_position = positions_x[position_index];


                    string p = answer.Trim();
                    
                    radioButton[counter] = new RadioButton();
                    radioButton[counter].Text = p;

                    if (positions_x[position_index] == 10)
                    {
                        radioButton[counter].Checked = true;

                    }
                    positions_x = positions_x.Where((source, index) => index != position_index).ToArray();

                    radioButton[counter].Name = "incorrect";
                    radioButton[counter].Appearance = Appearance.Normal;
                    radioButton[counter].AutoCheck = true;
                    radioButton[counter].AutoSize = true;
                    radioButton[counter].Location = new Point(curr_position, 10);
                    groupBox[counter].Controls.Add(radioButton[counter]);


                }

                list_reading.Add(reader["id_question"].ToString());

                panel1.Controls.Add(groupBox[counter]);

                space += 70;
                counter++;

            }
            reader.Close();
            connection.Close();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            int correct = 0;
            for (int i = 0; i <groupBox.Length; i++)
            {
                string curr = groupBox[i].Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;

                if (curr == "correct")
                {
                    correct++;
                }
            }

            string broj = Convert.ToString(correct);
            Result_reading myResult= new Result_reading();
            myResult.Graph(broj);

            myResult.Lista(list_reading);
        

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
