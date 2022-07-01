using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        internal int id;

        public Register()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "UPDATE user SET cin = @cin, nom = @nom, prenom = @prenom, tele = @tele, username = @username, password = @password, isActive = 1 WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@cin", cin.Text);
            cmd.Parameters.AddWithValue("@nom", nom.Text);
            cmd.Parameters.AddWithValue("@prenom", prenom.Text);
            cmd.Parameters.AddWithValue("@tele", tele.Text);
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            int n = cmd.ExecuteNonQuery();
            connection.Close();

            if (n > 0)
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }
            else
                error.Text = "Ressayer plus tard !!";

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
