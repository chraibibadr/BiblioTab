using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.UserControls.OuvrageUserControls;

namespace WindowsFormsApp2.UserControls
{
    public partial class UC_Ouvrage : UserControl
    {
        public UC_Ouvrage()
        {
            InitializeComponent();
            UC_OuvrageLivre uc = new UC_OuvrageLivre();
            Program.addUserControl(panelContainer, uc);
        }

        private void cd_Click(object sender, EventArgs e)
        {
            UC_OuvrageCD uc = new UC_OuvrageCD();
            Program.addUserControl(panelContainer, uc);
        }

        private void livre_Click(object sender, EventArgs e)
        {
            UC_OuvrageLivre uc = new UC_OuvrageLivre();
            Program.addUserControl(panelContainer, uc);
        }

        private void periodique_Click(object sender, EventArgs e)
        {
            UC_OuvragePeriodique uc = new UC_OuvragePeriodique();
            Program.addUserControl(panelContainer, uc);
        }
    }
}
