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
    public partial class Vocabulary_people : Form
    {
        public Vocabulary_people()
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
            panelVocabulary_people.Controls.Add(childForm);
            panelVocabulary_people.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new Physical_appearance());

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            openChildForm(new Clothes());

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new Body());

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Health_Care());

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new Emotions_feelings());

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new Communication());

        }

        private void panelVocabulary_people_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_test_basicwords_Click(object sender, EventArgs e)
        {
            openChildForm(new People_test());

        }
    }
}
