using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivio_Learn.Forms
{
    public partial class PresentSimpleRules : Form
    {
        public PresentSimpleRules()
        {
            InitializeComponent();
        }


        private void PresentSimpleRules_Load(object sender, EventArgs e)
        {
            presentSimpleRulePlus1.Hide();
            presentSimpleRuleMinus1.Hide();
            presentSimpleRuleQuestion1.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            presentSimpleRuleMinus1.Hide();
            presentSimpleRuleQuestion1.Hide();
            presentSimpleRulePlus1.Show();
            presentSimpleRulePlus1.BringToFront();
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            presentSimpleRulePlus1.Hide();
            presentSimpleRuleQuestion1.Hide();
            presentSimpleRuleMinus1.Show();
            presentSimpleRuleMinus1.BringToFront();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            presentSimpleRulePlus1.Hide();
            presentSimpleRuleMinus1.Hide();
            presentSimpleRuleQuestion1.Show();
            presentSimpleRuleQuestion1.BringToFront();
        }
    }
}
