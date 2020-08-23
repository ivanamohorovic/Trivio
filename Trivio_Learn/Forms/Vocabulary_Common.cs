using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivio_Learn.Forms
{
    public partial class Vocabulary_Common : Form
    {
        public Vocabulary_Common()
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
            panelVocabulary_Common.Controls.Add(childForm);
            panelVocabulary_Common.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
 
        private void Vocabulary_Common_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Basic_Words());
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            openChildForm(new Time_Date());

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Colours());

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new Numbers());

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button_test_basicwords_Click(object sender, EventArgs e)
        {
            openChildForm(new Common_test());

        }
    }
}
