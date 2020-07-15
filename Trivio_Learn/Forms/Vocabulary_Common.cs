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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Basic_Words Trivio_Learn = new Basic_Words();
            Trivio_Learn.Show();
            Visible = false;
        }
    }
}
