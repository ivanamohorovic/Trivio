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
    public partial class FutureWill : Form
    {
        public FutureWill()
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
            panelChildFormFutureWill.Controls.Add(childForm);
            panelChildFormFutureWill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new FutureWillRules());
        }
    }
}
