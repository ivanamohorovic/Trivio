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
    public partial class PastSimple : Form
    {
        public PastSimple()
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
            panelChildFormPastSimple.Controls.Add(childForm);
            panelChildFormPastSimple.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new PastSimpleRules());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Exercises_grammar());

            Exercises_grammar myResult = new Exercises_grammar();
            int id_tenses_main = 3;
            myResult.IdTensesMain(id_tenses_main);

            myResult.TopLevel = false;
            myResult.FormBorderStyle = FormBorderStyle.None;
            myResult.Dock = DockStyle.Fill;
            panelChildFormPastSimple.Controls.Add(myResult);
            panelChildFormPastSimple.Tag = myResult;
            myResult.BringToFront();

            myResult.Show();

        }
    }
}
