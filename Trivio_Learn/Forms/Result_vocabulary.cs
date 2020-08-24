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
    public partial class Result_vocabulary : Form
    {
        public Result_vocabulary()
        {
            InitializeComponent();
        }

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

        MySqlConnection connection;

        string saveGraph;
        List<string> saveList;
        string saveVocabularyCategory;

        Label[] lbl = new Label[10];
        Label[] lbl2 = new Label[10];

        public void Graph(string getResult)
        {
            saveGraph = getResult;
        }

        public void Lista(List<string> getResult)
        {
            saveList = getResult;
        }

        public void VocabularyCategory(string getResult)
        {
            saveVocabularyCategory = getResult;
        }


        private void Result_vocabulary_Load(object sender, EventArgs e)
        {
            int counter = 0;
            int space = 0;
            foreach (var i in saveList)
            { 
                connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM terms_vocabulary WHERE id_term="+i, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
           

                while (reader.Read())
                {
                    lbl[counter] = new Label();
                    lbl[counter].Text = reader["term"].ToString();
                    lbl[counter].AutoSize = true;
                    lbl[counter].Visible = true;
                    lbl[counter].Location = new Point(0, 40 + space);
                    lbl[counter].Font = new Font("Century Gothic", 10);
                    lbl[counter].ForeColor = Color.MediumSeaGreen;
                    panel1.Controls.Add(lbl[counter]);

                    lbl2[counter] = new Label();
                    lbl2[counter].Text = reader["description"].ToString();
                    lbl2[counter].AutoSize = true;
                    lbl2[counter].Visible = true;
                    lbl2[counter].Location = new Point(100, 40 + space);
                    lbl2[counter].Font = new Font("Calibri", 10);
                    lbl2[counter].ForeColor = Color.DimGray;
                    panel1.Controls.Add(lbl2[counter]);

                    space += 40;
                    counter++;

                }
                reader.Close();
                connection.Close();

            }
 
            int novo = Convert.ToInt32(saveGraph);

            int brojrecenica = 10;

            decimal postotak = ((decimal)novo / (decimal)(brojrecenica)) * 100m;

            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;
            circularProgressBar2.Text = string.Format("{0:0.00}", postotak);

            for (int i = 1; i < 100; i++)
            {
                circularProgressBar2.Value = Convert.ToInt32(postotak);
                circularProgressBar2.Update();
            }           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (saveVocabularyCategory == "common")
            {
                openChildForm(new Vocabulary_test());
            }
            else if (saveVocabularyCategory == "people")
            {
                openChildForm(new Vocabulary_test());
            }
            else
            {
                openChildForm(new Vocabulary_test());
            }

            
            Vocabulary_test myResult = new Vocabulary_test();
            string saveVocabularyCategoryClick = saveVocabularyCategory;

            myResult.VocabularyCategoryClick(saveVocabularyCategoryClick);

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
