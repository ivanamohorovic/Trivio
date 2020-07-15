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
    public partial class PresentContinuousRules : Form
    {
        public PresentContinuousRules()
        {
            InitializeComponent();
        }

        private void PresentContinuousRules_Load_1(object sender, EventArgs e)
        {
            presentContRulePlus1.Hide();
            presentContRuleMinus1.Hide();
            presentContRuleQuestion1.Hide();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            presentContRuleMinus1.Hide();
            presentContRuleQuestion1.Hide();
            presentContRulePlus1.Show();
            presentContRulePlus1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            presentContRulePlus1.Hide();
            presentContRuleQuestion1.Hide();
            presentContRuleMinus1.Show();
            presentContRuleMinus1.BringToFront();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            presentContRulePlus1.Hide();
            presentContRuleMinus1.Hide();
            presentContRuleQuestion1.Show();
            presentContRuleQuestion1.BringToFront();

        }

        
    }
}
