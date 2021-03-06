﻿using System;
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
    public partial class Exercises_grammar : Form
    {
        MySqlConnection connection;

        public static List<string> list;

        public Exercises_grammar()
        {
            InitializeComponent();
            list = new List<string>();


        }

        int saveIdTensesMain;
        public void IdTensesMain(int getResult)
        {
            saveIdTensesMain = getResult;
        }

        int space = 0;

        MySqlCommand com;

        TextBox[] txtBox = new TextBox[10];
        TextBox[] txtBox2 = new TextBox[10];
        Label[] lbl = new Label[10];
        Label[] lbl2 = new Label[10];
        Label[] lbl3 = new Label[10];


        private void ExerPresentSimple_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
            connection.Open();
            string str = "SELECT * FROM sentence WHERE id_tenses='"+saveIdTensesMain+"' ORDER BY RAND() LIMIT 10";
            com = new MySqlCommand(str, connection);
            MySqlDataReader reader = com.ExecuteReader();

            int counter = 0;

            while (reader.Read())
            {
                if (Convert.ToInt32(reader["id_type"]) == 3)
                {
                    txtBox[counter] = new TextBox();
                    txtBox[counter].Name = reader["id_sentence"].ToString();
                    txtBox[counter].AutoSize = true;
                    txtBox[counter].Visible = true;
                    txtBox[counter].Location = new Point(40, 10 + space);
                    txtBox[counter].BackColor = Color.FromArgb(70, 70, 70);
                    txtBox[counter].BorderStyle = BorderStyle.None;
                    txtBox[counter].Font = new Font("Century Gothic", 12);
                    txtBox[counter].ForeColor = Color.LightCyan;
                    panelExerPresentSimple.Controls.Add(txtBox[counter]);

                    lbl[counter] = new Label();
                    lbl[counter].Text = reader["text_1"].ToString();
                    lbl[counter].AutoSize = true;
                    lbl[counter].Visible = true;
                    lbl[counter].Location = new Point(170, 10 + space);
                    lbl[counter].Font = new Font("Century Gothic", 14);
                    lbl[counter].ForeColor = Color.MediumSeaGreen;
                    panelExerPresentSimple.Controls.Add(lbl[counter]);

                    txtBox2[counter] = new TextBox();
                    txtBox2[counter].Name = reader["id_sentence"].ToString();
                    txtBox2[counter].AutoSize = true;
                    txtBox2[counter].Visible = true;
                    txtBox2[counter].Location = new Point(240, 10 + space);
                    txtBox2[counter].BackColor = Color.FromArgb(70, 70, 70);
                    txtBox2[counter].BorderStyle = BorderStyle.None;
                    txtBox2[counter].Font = new Font("Century Gothic", 12);
                    txtBox2[counter].ForeColor = Color.LightCyan;
                    panelExerPresentSimple.Controls.Add(txtBox2[counter]);

                    lbl3[counter] = new Label();
                    lbl3[counter].Text = reader["verb_insert"].ToString();
                    lbl3[counter].AutoSize = true;
                    lbl3[counter].Visible = true;
                    lbl3[counter].Location = new Point(350, 10 + space);
                    lbl3[counter].Font = new Font("Century Gothic", 12);
                    lbl3[counter].ForeColor = Color.LightCyan;
                    panelExerPresentSimple.Controls.Add(lbl3[counter]);

                    lbl2[counter] = new Label();
                    lbl2[counter].Text = reader["text_2"].ToString();
                    lbl2[counter].AutoSize = true;
                    lbl2[counter].Visible = true;
                    lbl2[counter].Location = new Point(420, 10 + space);
                    lbl2[counter].Font = new Font("Century Gothic", 14);
                    lbl2[counter].ForeColor = Color.MediumSeaGreen;
                    panelExerPresentSimple.Controls.Add(lbl2[counter]);

                    list.Add(reader["id_sentence"].ToString());
                    Console.WriteLine(reader["id_sentence"]);




                    space += 40;
                    counter++;
                }
                else
                {
                    lbl[counter] = new Label();
                    lbl[counter].Text = reader["text_1"].ToString();
                    lbl[counter].AutoSize = true;
                    lbl[counter].Visible = true;
                    lbl[counter].Location = new Point(40, 10 + space);
                    lbl[counter].Font = new Font("Century Gothic", 14);
                    lbl[counter].ForeColor = Color.MediumSeaGreen;
                    panelExerPresentSimple.Controls.Add(lbl[counter]);

                    txtBox[counter] = new TextBox();
                    txtBox[counter].Name = reader["id_sentence"].ToString();
                    txtBox[counter].Visible = true;
                    txtBox[counter].Size = new Size(130, 24);
                    txtBox[counter].Location = new Point(120, 10 + space);
                    txtBox[counter].BackColor = Color.FromArgb(70, 70, 70);
                    txtBox[counter].BorderStyle = BorderStyle.None;
                    txtBox[counter].Font = new Font("Century Gothic", 12);
                    txtBox[counter].ForeColor = Color.LightCyan;
                    panelExerPresentSimple.Controls.Add(txtBox[counter]);

                    lbl3[counter] = new Label();
                    lbl3[counter].Text = reader["verb_insert"].ToString();
                    lbl3[counter].AutoSize = true;
                    lbl3[counter].Visible = true;
                    lbl3[counter].Location = new Point(250, 10 + space);
                    lbl3[counter].Font = new Font("Century Gothic", 12);
                    lbl3[counter].ForeColor = Color.LightCyan;
                    panelExerPresentSimple.Controls.Add(lbl3[counter]);

                    lbl2[counter] = new Label();
                    lbl2[counter].Text = reader["text_2"].ToString();
                    lbl2[counter].AutoSize = true;
                    lbl2[counter].Visible = true;
                    lbl2[counter].Location = new Point(350, 10 + space);
                    lbl2[counter].Font = new Font("Century Gothic", 14);
                    lbl2[counter].ForeColor = Color.MediumSeaGreen;
                    panelExerPresentSimple.Controls.Add(lbl2[counter]);

                    list.Add(reader["id_sentence"].ToString());

                    space += 40;
                    counter++;

                    Console.WriteLine(reader["id_sentence"]);
                }

            }
            reader.Close();
            connection.Close();


        }


        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            int correct = 0;
            int verb_number = 0;

            foreach (Control c in panelExerPresentSimple.Controls)
            {
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");

                    string sql = "SELECT * FROM sentence WHERE id_tenses='" + saveIdTensesMain + "'" +
                        "AND id_sentence = '" + c.Name + "" +
                        "' AND verb_1=@Text OR id_sentence = '" + c.Name + "' AND verb_2=@Text";
            
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
                    verb_number++;
                }
            }

       
            string broj = Convert.ToString (correct);
            Result_grammar myResult = new Result_grammar();
            myResult.graph(broj);

            myResult.verb_number(verb_number.ToString());

            myResult.IdTensesMain(saveIdTensesMain);
            myResult.Lista(list);


            myResult.TopLevel = false;
            myResult.FormBorderStyle = FormBorderStyle.None;
            myResult.Dock = DockStyle.Fill;
            panelExerPresentSimple.Controls.Add(myResult);
            panelExerPresentSimple.Tag = myResult;
            myResult.BringToFront();
           
            myResult.Show();

         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }

      
}

