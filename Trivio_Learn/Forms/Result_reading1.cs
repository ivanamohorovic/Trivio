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
    public partial class Result_reading1 : Form
    {
        public Result_reading1()
        {
            InitializeComponent();
        }

        string saveGraph;

        public void Graph(string getResult)
        {
            saveGraph = getResult;
        }

        private void Result_reading1_Load(object sender, EventArgs e)
        {
            int novo = Convert.ToInt32(saveGraph);

            int brojrecenica = 5;

            decimal postotak = ((decimal)novo / (decimal)(brojrecenica)) * 100m;

            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;
            circularProgressBar2.Text = string.Format("{0:0.00}", postotak);

            for (int i = 1; i < 100; i++)
            {
                circularProgressBar2.Value = Convert.ToInt32(postotak);
                circularProgressBar2.Update();
            }
        }
    }
}
