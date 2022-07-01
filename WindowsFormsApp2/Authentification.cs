using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using WindowsFormsApp2.UserControls;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void login()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "SELECT * FROM user where username = @user and password = @pass";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@user", username.Text);
            cmd.Parameters.AddWithValue("@pass", password.Text);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();

            if (username.Text == "" || password.Text == "")
            {
                error.Visible = true;
                error.Text = "Saisi d'abord vos informations !";
            }
            else if (data.Rows.Count == 0)
            {
                error.Visible = true;
                error.Text = "Utilisateur non trouver !";
            }
            else if (Convert.ToInt32(data.Rows[0]["isActive"]) == 1)
            {
                if (username.Text == data.Rows[0]["username"].ToString() && password.Text == data.Rows[0]["password"].ToString())
                {
                    Program.userID = int.Parse(data.Rows[0]["id"].ToString());
                    AdminMenu m = new AdminMenu();
                    m.name = data.Rows[0]["prenom"].ToString() + " " + data.Rows[0]["nom"].ToString();
                    if (data.Rows[0]["role"].ToString() == "administrateur")
                    {
                        m.showMenu = true;
                        m.userRole = "Administrateur";
                        m.Show();
                        
                        this.Hide();
                    }
                    else if (data.Rows[0]["role"].ToString() == "moderateurr")
                    {
                        m.showMenu = false;
                        m.userRole = "Moderateur";
                        m.Show();
                       
                        this.Hide();
                    }
                }
            }
            else if (Convert.ToInt32(data.Rows[0]["isActive"]) == 0)
            {
                Program.userID = int.Parse(data.Rows[0]["id"].ToString());
                Register r = new Register();
                r.id = int.Parse(data.Rows[0]["id"].ToString());
                r.Show();
                this.Hide();
            }
            else if (Convert.ToInt32(data.Rows[0]["isActive"]) == -1)
            {
                error.Visible = true;
                error.Text = "Votre compte est desactivé";
            }
                
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
