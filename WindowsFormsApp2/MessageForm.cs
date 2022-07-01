using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MessageForm : Form
    {
        public MessageForm(string title, string msg, int type)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            titre.Text = title;
            message.Text = msg;
            if(type == 1)
            {
                yesBtn.Visible = true;
                noBtn.Visible = true;
                okBtn.Visible = false;
            }
            if (type == 2)
            {
                yesBtn.Visible = false;
                noBtn.Visible = false;
                okBtn.Visible = true;
            }

            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Exclamation.wav");

            simpleSound.Play();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            Program.MessageFormReplay = "yes";
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Program.MessageFormReplay = "no";
            this.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
