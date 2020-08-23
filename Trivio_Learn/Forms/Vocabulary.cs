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
    public partial class Vocabulary : Form
    {
        public Vocabulary()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelVocabularySubmenu.Visible = false;
            panelReadingSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelVocabularySubmenu.Visible == true)
                panelVocabularySubmenu.Visible = false;
            if (panelReadingSubmenu.Visible == true)
                panelReadingSubmenu.Visible = false;
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


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
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


        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form1 Trivio_Learn = new Form1();
            Trivio_Learn.Show();
            Visible = false;
        }

        private void btnPresentmenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVocabularySubmenu);
        }

        private void btnCommonmenu_Click(object sender, EventArgs e)
        {

            openChildForm(new Vocabulary_Common());
            hideSubMenu();
        }

        private void btnPeoplemenu_Click(object sender, EventArgs e)
        {
            openChildForm(new Vocabulary_people());
            hideSubMenu();
        }

        private void btnPrivateLifemenu_Click(object sender, EventArgs e)
        {
            openChildForm(new Vocabulary_private_life());
            hideSubMenu();
        }

        private void btnReadingmenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReadingSubmenu);
        }

        private void btnReading3_Click(object sender, EventArgs e)
        {
            openChildForm(new Reading3());

            hideSubMenu();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReading1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Reading1());
            hideSubMenu();
        }

        private void btnReading2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Reading2());
            hideSubMenu();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
