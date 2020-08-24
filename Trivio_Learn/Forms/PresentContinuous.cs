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
    public partial class PresentContinuous : Form
    {
        public PresentContinuous()
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
            panelChildFormPresentContinuous.Controls.Add(childForm);
            panelChildFormPresentContinuous.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void PresentContiuous_Load(object sender, EventArgs e)
        {

        }


        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PresentContinuousRules());
        }

        private void panelChildFormPresentContinuous_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Exercises_grammar());

            Exercises_grammar myResult = new Exercises_grammar();
            int id_tenses_main = 2;
            myResult.IdTensesMain(id_tenses_main);

            myResult.TopLevel = false;
            myResult.FormBorderStyle = FormBorderStyle.None;
            myResult.Dock = DockStyle.Fill;
            panelChildFormPresentContinuous.Controls.Add(myResult);
            panelChildFormPresentContinuous.Tag = myResult;
            myResult.BringToFront();

            myResult.Show();
        }
    }
}
