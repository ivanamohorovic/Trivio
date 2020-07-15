using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Trivio_Learn.Forms
{
    public partial class Basic_Words : Form
    {
        private SoundPlayer soundPlayer;
        public Basic_Words()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("home.wav");
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Stop";
                soundPlayer.Play();
            }
            else
            {
                checkBox1.Text = "Play";
                soundPlayer.Stop();
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("yes.wav");
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Stop";
                soundPlayer.Play();
            }
            else
            {
                checkBox2.Text = "Play";
                soundPlayer.Stop();
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("please.wav");
            if (checkBox3.Checked)
            {
                checkBox3.Text = "Stop";
                soundPlayer.Play();
            }
            else
            {
                checkBox3.Text = "Play";
                soundPlayer.Stop();
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("welcome.wav");
            if (checkBox4.Checked)
            {
                checkBox4.Text = "Stop";
                soundPlayer.Play();
            }
            else
            {
                checkBox4.Text = "Play";
                soundPlayer.Stop();
            }
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("good.wav");
            if (checkBox5.Checked)
            {
                checkBox5.Text = "Stop";
                soundPlayer.Play();
            }
            else
            {
                checkBox5.Text = "Play";
                soundPlayer.Stop();
            }
        }

    }
}
