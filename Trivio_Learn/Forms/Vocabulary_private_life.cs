﻿using System;
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
    public partial class Vocabulary_private_life : Form
    {
        public Vocabulary_private_life()
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new Family());
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            openChildForm(new Leisure_time());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new Travel_tourism());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Food());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new Drinks());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new Celebrations());
        }

        private void button_test_basicwords_Click(object sender, EventArgs e)
        {
            openChildForm(new Private_life_test());

        }
    }
}