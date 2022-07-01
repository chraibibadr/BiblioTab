using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.UserControls;

namespace WindowsFormsApp2
{
    public partial class AdminMenu : Form
    {
        internal string name;
        internal string userRole;
        internal bool showMenu;

        public AdminMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            UC_Home uc = new UC_Home();
            addUserControl(uc);

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            AdminName.Text = name;
            role.Text = userRole;
            comptes.Visible = showMenu;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Ouvrage uc = new UC_Ouvrage();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Emprunt uc = new UC_Emprunt();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Profile uc = new UC_Profile();
            addUserControl(uc);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_Parametres uc = new UC_Parametres();
            addUserControl(uc);

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_Comptes uc = new UC_Comptes();
            addUserControl(uc);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }
    }
}
