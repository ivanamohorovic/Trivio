using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MySql.Data.MySqlClient;

namespace Trivio_Learn.Forms
{
    public partial class Physical_appearance : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=trivio_learn;username=root;password=nov23dku");
        MySqlCommand command;
        MySqlDataAdapter da;

        private SoundPlayer soundPlayer;
        public Physical_appearance()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer();
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
            dataGridView1.Hide();
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Physical_appearance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trivio_learnDataSet1.terms_vocabulary' table. You can move, or remove it, as needed.
            this.terms_vocabularyTableAdapter.Fill(this.trivio_learnDataSet1.terms_vocabulary);
            string selectQuery = "SELECT term, audio_path, description FROM terms_vocabulary WHERE id_vocabulary =5";

            command = new MySqlCommand(selectQuery, connection);
            connection.Open();
            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            da.Fill(table);

            dataGridView1.DataSource = table;

            da.Dispose();

            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "play")
            {
                var path = dataGridView1.Rows[e.RowIndex].Cells[1].Value;

                soundPlayer = new SoundPlayer(path.ToString());
                soundPlayer.Play();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new Vocabulary_people());

        }
    }
}
