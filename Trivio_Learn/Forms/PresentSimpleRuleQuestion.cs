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
    public partial class PresentSimpleRuleQuestion : UserControl
    {
        public PresentSimpleRuleQuestion()
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
            panelPresentSimpleRuleQuestion.Controls.Add(childForm);
            panelPresentSimpleRuleQuestion.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new PresentSimpleRules());
        }
    }
}
