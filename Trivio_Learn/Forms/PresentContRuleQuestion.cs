using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivio_Learn.Forms
{
    public partial class PresentContRuleQuestion : UserControl
    {
        public PresentContRuleQuestion()
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
            panelPresentContRuleQuestion.Controls.Add(childForm);
            panelPresentContRuleQuestion.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new PresentContinuousRules());
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
