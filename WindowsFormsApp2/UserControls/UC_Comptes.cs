using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.UserControls.CompteUserControls;

namespace WindowsFormsApp2.UserControls
{
    public partial class UC_Comptes : UserControl
    {
        public UC_Comptes()
        {
            InitializeComponent();
            UC_GestionComptes uc = new UC_GestionComptes();
            Program.addUserControl(panelContainer,uc);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            UC_GestionComptes uc = new UC_GestionComptes();
            Program.addUserControl(panelContainer, uc);
        }

        private void comptes_Click(object sender, EventArgs e)
        {
            UC_GComptes uc = new UC_GComptes();
            Program.addUserControl(panelContainer, uc);
        }
    }
}
