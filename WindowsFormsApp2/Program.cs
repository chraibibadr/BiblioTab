using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    static class Program
    {
        public static string cnx = "SERVER=127.0.0.1; DATABASE=biblio; UID=root; PASSWORD=; convert zero datetime=True";
        public static string MessageFormReplay = "";
        public static int userID;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public static void addUserControl(Panel panelContainer, UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public static void colorGrid(Guna.UI2.WinForms.Guna2DataGridView dt)
        {
            foreach (DataGridViewRow row in dt.Rows)
            {
                if (Convert.ToInt32(row.Cells["quantite"].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(251, 160, 160);
                }
            }
        }

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
