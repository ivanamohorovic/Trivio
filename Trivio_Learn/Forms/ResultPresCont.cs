using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trivio_Learn.Forms
{
    public partial class ResultPresCont : Form
    {
        public ResultPresCont()
        {
            InitializeComponent();
        }

        MySqlConnection connection;

        string saveGraph;

        public void graph(string getResult)
        {
            saveGraph = getResult;
        }

        private void ResultPresCont_Load(object sender, EventArgs e)
        {
           
        }

   

        private void panelResultPresentCont_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = saveGraph;
           /* Convert.ToInt32(saveGraph);
            int novo = Convert.ToInt32(saveGraph);

            int brojrecenica = 10;

            var rezultat = brojrecenica - (brojrecenica - novo);
            decimal postotak = ((decimal)novo / (decimal)(brojrecenica)) * 100m;


            circularProgressBar3.Minimum = 0;
            circularProgressBar3.Maximum = 100;
            circularProgressBar3.Text = Convert.ToString(postotak);

            for (int i = 1; i < 100; i++)
            {
                circularProgressBar3.Value = Convert.ToInt32(postotak);
                circularProgressBar3.Update();
            }*/
        }
    }
}
