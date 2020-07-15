using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trivio_Learn.Forms;

namespace Trivio_Learn.Forms
{
    public partial class Grammar : Form
    {
        public Grammar()
        {
            InitializeComponent();
            customizeDesign();

        }

        private void customizeDesign()
        {
            panelPresentSubmenu.Visible = false;
            panelPastSubmenu.Visible = false;
            panelFutureSubmenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelPresentSubmenu.Visible == true)
                panelPresentSubmenu.Visible = false;
            if (panelPastSubmenu.Visible == true)
                panelPastSubmenu.Visible = false;
            if (panelFutureSubmenu.Visible == true)
                panelFutureSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            else
                subMenu.Visible = false;

        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPresentSubmenu);

        }

        private void btnPresentSimplemenu_Click(object sender, EventArgs e)
        {
            openChildForm(new PresentSimple());
            hideSubMenu();
        }

        private void btnPresentContmenu_Click(object sender, EventArgs e)
        {
            openChildForm(new PresentContinuous());
            hideSubMenu();
        }

        private void btnPresentExermenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPastmenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPastSubmenu);
        }

        private void btnPastSimplemenu_Click(object sender, EventArgs e)
        {
            openChildForm(new PastSimple());
            hideSubMenu();
        }

        private void btnPastContmenu_Click(object sender, EventArgs e)
        {
            openChildForm(new PastContinuous());
            hideSubMenu();

        }

        private void btnPastExermenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnFuturemenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFutureSubmenu);
        }

        private void btnFutureWillmenu_Click(object sender, EventArgs e)
        {
            openChildForm(new FutureWill());
            hideSubMenu();

        }

        private void btnFutureGoingmenu_Click(object sender, EventArgs e)
        {
            openChildForm(new FutureGoing());
            hideSubMenu();

        }

        private void btnFutureExermenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm!=null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Grammar_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
                        
            Form1 Trivio_Learn = new Form1 ();
            Trivio_Learn.Show();
            Visible = false;
        }
    }
}
