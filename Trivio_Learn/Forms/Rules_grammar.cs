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
    public partial class Rules_grammar : Form
    {
        public Rules_grammar()
        {
            InitializeComponent();
        }

        MySqlConnection connection;

        int saveIdRuleType;
        int saveIdTensesType;

        public void IdRuleType(int getResult)
        {
            saveIdRuleType = getResult;
        }

        public void IdTensesType(int getResult)
        {
            saveIdTensesType = getResult;
        }

        Label[] lbl = new Label[5];
        Label lblTitle = new Label();

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

        private void Rules_grammar_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT sentence.id_sentence, sentence.id_tenses," +
                "sentence.full_sentence, sentence.id_type, sentence_type.type_name FROM sentence " +
                "INNER JOIN sentence_type ON sentence.id_type=sentence_type.id_type" +
                " WHERE sentence.id_tenses ='"+saveIdTensesType+"' AND" +
                " sentence.id_type='"+saveIdRuleType+"' ORDER BY RAND() LIMIT 5", connection);


            MySqlDataReader reader = cmd.ExecuteReader();

            int counter = 0;
            int space = 0;

            while (reader.Read())
            {

                lblTitle = new Label();
                lblTitle.Text = reader["type_name"].ToString();
                lblTitle.Visible = true;
                lblTitle.AutoSize = true;
                lblTitle.Location = new Point(60, 3);
                lblTitle.Font = new Font("Century Gothic", 20);
                lblTitle.ForeColor = Color.FromArgb(90,90,90) ;
                panel1.Controls.Add(lblTitle);

                lbl[counter] = new Label();
                lbl[counter].Text = reader["full_sentence"].ToString();
                lbl[counter].AutoSize = true;
                lbl[counter].Visible = true;
                lbl[counter].Location = new Point(60, 100 + space);
                lbl[counter].Font = new Font("Century Gothic", 14);
                lbl[counter].ForeColor = Color.FromArgb(0, 192, 192);
                panel1.Controls.Add(lbl[counter]);

                space += 40;
                counter++;

            }
            reader.Close();
            connection.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (saveIdTensesType==1)
            {
                openChildForm(new PresentSimpleRules());
            }
            else if (saveIdTensesType==2)
            {
                openChildForm(new PresentContinuousRules());
            }
            else if (saveIdTensesType == 3)
            {
                openChildForm(new PastSimpleRules());
            }
            else if (saveIdTensesType == 4)
            {
                openChildForm(new PastContinuousRules());
            }
            else if (saveIdTensesType == 5)
            {
                openChildForm(new FutureWillRules());
            }
            else
            {
                openChildForm(new FutureGoingRules());
            }

        }
    }
}
