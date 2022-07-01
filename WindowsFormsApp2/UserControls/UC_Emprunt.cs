using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.UserControls.EmpruntUserControls;

namespace WindowsFormsApp2.UserControls
{
    public partial class UC_Emprunt : UserControl
    {
        public UC_Emprunt()
        {
            InitializeComponent();
            UC_GestionEmprunt uc = new UC_GestionEmprunt();
            Program.addUserControl(panelContainer, uc);
        }

        private void manageEmprunt_Click(object sender, EventArgs e)
        {
            UC_GestionEmprunt uc = new UC_GestionEmprunt();
            Program.addUserControl(panelContainer, uc);
        }

        private void addEmprunt_Click(object sender, EventArgs e)
        {
            UC_NewEmprunt uc = new UC_NewEmprunt();
            Program.addUserControl(panelContainer, uc);
        }
    }
}
