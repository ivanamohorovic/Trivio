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
    public partial class FutureWillRules : Form
    {
        public FutureWillRules()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            int id_tenses_type = 5;
            int id_rule_type = 1;
            Rules_grammar myResult = new Rules_grammar();
            myResult.IdRuleType(id_rule_type);

            myResult.IdTensesType(id_tenses_type);


            myResult.TopLevel = false;
            myResult.FormBorderStyle = FormBorderStyle.None;
            myResult.Dock = DockStyle.Fill;
            panelChildFormFutureWillRules.Controls.Add(myResult);
            panelChildFormFutureWillRules.Tag = myResult;
            myResult.BringToFront();

            myResult.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            int id_tenses_type = 5;
            int id_rule_type = 2;
            Rules_grammar myResult = new Rules_grammar();
            myResult.IdRuleType(id_rule_type);

            myResult.IdTensesType(id_tenses_type);


            myResult.TopLevel = false;
            myResult.FormBorderStyle = FormBorderStyle.None;
            myResult.Dock = DockStyle.Fill;
            panelChildFormFutureWillRules.Controls.Add(myResult);
            panelChildFormFutureWillRules.Tag = myResult;
            myResult.BringToFront();

            myResult.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int id_tenses_type = 5;
            int id_rule_type = 3;
            Rules_grammar myResult = new Rules_grammar();
            myResult.IdRuleType(id_rule_type);

            myResult.IdTensesType(id_tenses_type);


            myResult.TopLevel = false;
            myResult.FormBorderStyle = FormBorderStyle.None;
            myResult.Dock = DockStyle.Fill;
            panelChildFormFutureWillRules.Controls.Add(myResult);
            panelChildFormFutureWillRules.Tag = myResult;
            myResult.BringToFront();

            myResult.Show();
        }
    }
}
