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
    public partial class ExerPresentSimple : Form
    {
        
        public ExerPresentSimple()
        {
            InitializeComponent();
  
        }

        MySqlConnection connection;


        private void ExerPresentSimple_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
            connection.Open();

            DataTable dt = new DataTable();
            MySqlCommand sqlCmd= new MySqlCommand("select text_1, text_2, verb_insert from sentence where id_tenses = 1", connection);

            MySqlDataAdapter sqlDa = new MySqlDataAdapter(sqlCmd);


            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                label1.Text = dt.Rows[0]["text_1"].ToString(); 
                label2.Text = dt.Rows[1]["text_1"].ToString();
                label3.Text = dt.Rows[2]["text_1"].ToString();
                label4.Text = dt.Rows[3]["text_1"].ToString();
                label5.Text = dt.Rows[4]["text_1"].ToString();
                label6.Text = dt.Rows[5]["text_1"].ToString();
                label7.Text = dt.Rows[6]["text_1"].ToString();
                label8.Text = dt.Rows[7]["text_1"].ToString();
                label9.Text = dt.Rows[8]["text_1"].ToString();
                label10.Text = dt.Rows[9]["text_1"].ToString();
                label11.Text = dt.Rows[0]["text_2"].ToString();
                label12.Text = dt.Rows[1]["text_2"].ToString();
                label13.Text = dt.Rows[2]["text_2"].ToString();
                label14.Text = dt.Rows[3]["text_2"].ToString();
                label15.Text = dt.Rows[4]["text_2"].ToString();
                label16.Text = dt.Rows[5]["text_2"].ToString();
                label17.Text = dt.Rows[6]["text_2"].ToString();
                label18.Text = dt.Rows[7]["text_2"].ToString();
                label19.Text = dt.Rows[8]["text_2"].ToString();
                label20.Text = dt.Rows[9]["text_2"].ToString();
                label25.Text = dt.Rows[0]["verb_insert"].ToString();
                label24.Text = dt.Rows[1]["verb_insert"].ToString();
                label23.Text = dt.Rows[2]["verb_insert"].ToString();
                label22.Text = dt.Rows[3]["verb_insert"].ToString();
                label21.Text = dt.Rows[4]["verb_insert"].ToString();
                label30.Text = dt.Rows[5]["verb_insert"].ToString();
                label29.Text = dt.Rows[6]["verb_insert"].ToString();
                label28.Text = dt.Rows[7]["verb_insert"].ToString();
                label27.Text = dt.Rows[8]["verb_insert"].ToString();
                label26.Text = dt.Rows[9]["verb_insert"].ToString();



            }           
  
            connection.Close();

        }


        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //1
            connection.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=1", connection);
            cmd1.Parameters.AddWithValue("@verb", textBox1.Text);
            object result = cmd1.ExecuteScalar();
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();
            int count = ds.Tables[0].Rows.Count;
            int brojac = 0;

            if (count == 1)
            {
                brojac++;

            }

            //2
            connection.Open();
            MySqlCommand cmd2 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=2", connection);
            cmd2.Parameters.AddWithValue("@verb", textBox2.Text);
            result = cmd2.ExecuteScalar();
            MySqlDataAdapter adapt2 = new MySqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            adapt2.Fill(ds2);
            connection.Close();
            int count2 = ds2.Tables[0].Rows.Count;

            if (count2 == 1)
            {
                brojac++;

            }

            //3
            connection.Open();
            MySqlCommand cmd3 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=3", connection);
            cmd3.Parameters.AddWithValue("@verb", textBox3.Text);
            result = cmd3.ExecuteScalar();
            MySqlDataAdapter adapt3 = new MySqlDataAdapter(cmd3);
            DataSet ds3 = new DataSet();
            adapt3.Fill(ds3);
            connection.Close();
            int count3 = ds3.Tables[0].Rows.Count;

            if (count3 == 1)
            {
                brojac++;

            }

            //4
            connection.Open();
            MySqlCommand cmd4 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=4", connection);
            cmd4.Parameters.AddWithValue("@verb", textBox4.Text);
            result = cmd4.ExecuteScalar();
            MySqlDataAdapter adapt4 = new MySqlDataAdapter(cmd4);
            DataSet ds4 = new DataSet();
            adapt4.Fill(ds4);
            connection.Close();
            int count4 = ds4.Tables[0].Rows.Count;

            connection.Open();
            MySqlCommand cmd4_1 = new MySqlCommand("Select * from sentence where verb_2=@verb && id_sentence=4", connection);
            cmd4_1.Parameters.AddWithValue("@verb", textBox4.Text);
            result = cmd4_1.ExecuteScalar();
            MySqlDataAdapter adapt4_1 = new MySqlDataAdapter(cmd4_1);
            DataSet ds4_1 = new DataSet();
            adapt4_1.Fill(ds4_1);
            connection.Close();
            int count4_1 = ds4_1.Tables[0].Rows.Count;


            if (count4 == 1 || count4_1 == 1)
            {
                brojac++;

            }

            //5
            connection.Open();
            MySqlCommand cmd5 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=5", connection);
            cmd5.Parameters.AddWithValue("@verb", textBox5.Text);
            result = cmd5.ExecuteScalar();
            MySqlDataAdapter adapt5 = new MySqlDataAdapter(cmd5);
            DataSet ds5 = new DataSet();
            adapt5.Fill(ds5);
            connection.Close();
            int count5 = ds5.Tables[0].Rows.Count;

            connection.Open();
            MySqlCommand cmd5_1 = new MySqlCommand("Select * from sentence where verb_2=@verb && id_sentence=5", connection);
            cmd5_1.Parameters.AddWithValue("@verb", textBox5.Text);
            result = cmd5_1.ExecuteScalar();
            MySqlDataAdapter adapt5_1 = new MySqlDataAdapter(cmd5_1);
            DataSet ds5_1 = new DataSet();
            adapt5_1.Fill(ds5_1);
            connection.Close();
            int count5_1 = ds5_1.Tables[0].Rows.Count;


            if (count5 == 1 || count5_1 == 1)
            {
                brojac++;

            }

            //6
            connection.Open();
            MySqlCommand cmd6 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=6", connection);
            cmd6.Parameters.AddWithValue("@verb", textBox6.Text);
            result = cmd6.ExecuteScalar();
            MySqlDataAdapter adapt6 = new MySqlDataAdapter(cmd6);
            DataSet ds6 = new DataSet();
            adapt6.Fill(ds6);
            connection.Close();
            int count6 = ds6.Tables[0].Rows.Count;


            connection.Open();
            MySqlCommand cmd6_1 = new MySqlCommand("Select * from sentence where verb_2=@verb && id_sentence=6", connection);
            cmd6_1.Parameters.AddWithValue("@verb", textBox6_1.Text);
            result = cmd6_1.ExecuteScalar();
            MySqlDataAdapter adapt6_1 = new MySqlDataAdapter(cmd6_1);
            DataSet ds6_1 = new DataSet();
            adapt6_1.Fill(ds6_1);
            connection.Close();
            int count6_1 = ds6_1.Tables[0].Rows.Count;

            if (count6_1 == 1 && count6 == 1)
            {
                brojac++;

            }

            //7
            connection.Open();
            MySqlCommand cmd7 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=7", connection);
            cmd7.Parameters.AddWithValue("@verb", textBox7.Text);
            result = cmd7.ExecuteScalar();
            MySqlDataAdapter adapt7 = new MySqlDataAdapter(cmd7);
            DataSet ds7 = new DataSet();
            adapt7.Fill(ds7);
            connection.Close();
            int count7 = ds7.Tables[0].Rows.Count;

            if (count7 == 1)
            {
                brojac++;

            }

            //8
            connection.Open();
            MySqlCommand cmd8 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=8", connection);
            cmd8.Parameters.AddWithValue("@verb", textBox8.Text);
            result = cmd8.ExecuteScalar();
            MySqlDataAdapter adapt8 = new MySqlDataAdapter(cmd8);
            DataSet ds8 = new DataSet();
            adapt8.Fill(ds8);
            connection.Close();
            int count8 = ds8.Tables[0].Rows.Count;

            connection.Open();
            MySqlCommand cmd8_1 = new MySqlCommand("Select * from sentence where verb_2=@verb && id_sentence=8", connection);
            cmd8_1.Parameters.AddWithValue("@verb", textBox8.Text);
            result = cmd8_1.ExecuteScalar();
            MySqlDataAdapter adapt8_1 = new MySqlDataAdapter(cmd8_1);
            DataSet ds8_1 = new DataSet();
            adapt8_1.Fill(ds8_1);
            connection.Close();
            int count8_1 = ds8_1.Tables[0].Rows.Count;


            if (count8 == 1 || count8_1 == 1)
            {
                brojac++;

            }

            //9
            connection.Open();
            MySqlCommand cmd9 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=9", connection);
            cmd9.Parameters.AddWithValue("@verb", textBox9.Text);
            result = cmd9.ExecuteScalar();
            MySqlDataAdapter adapt9 = new MySqlDataAdapter(cmd9);
            DataSet ds9 = new DataSet();
            adapt9.Fill(ds9);
            connection.Close();
            int count9 = ds9.Tables[0].Rows.Count;

            if (count9 == 1)
            {
                brojac++;

            }

            //10
            connection.Open();
            MySqlCommand cmd10 = new MySqlCommand("Select * from sentence where verb_1=@verb && id_sentence=10", connection);
            cmd10.Parameters.AddWithValue("@verb", textBox10.Text);
            result = cmd10.ExecuteScalar();
            MySqlDataAdapter adapt10 = new MySqlDataAdapter(cmd10);
            DataSet ds10 = new DataSet();
            adapt10.Fill(ds10);
            connection.Close();
            int count10 = ds10.Tables[0].Rows.Count;

            if (count10 == 1)
            {
                brojac++;

            }



            string broj = Convert.ToString (brojac);
            Result_Present_Simple myResult = new Result_Present_Simple();
            myResult.graph(broj);



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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

      
}

