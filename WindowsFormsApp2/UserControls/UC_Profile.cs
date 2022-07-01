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

namespace WindowsFormsApp2.UserControls
{
    public partial class UC_Profile : UserControl
    {
        public UC_Profile()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(nom.Text != "" && cin.Text != "" && prenom.Text != "" && tele.Text != "" && username.Text != "" && password.Text != "" )
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
                cmd.Parameters.AddWithValue("@id", Program.userID);
                cmd.Prepare();
                int n = cmd.ExecuteNonQuery();
                connection.Close();

                if (n > 0)
                {
                    MessageForm msg = new MessageForm("Modification", "Bien modifier !", 2);
                    msg.ShowDialog();
                }
                else
                {
                    MessageForm msg = new MessageForm("Erreur", "Ressayer plus tard !", 2);
                    msg.ShowDialog();
                }
            }
            else
            {
                MessageForm msg = new MessageForm("Modification", "Remplir tous les champs !", 2);
                msg.ShowDialog();
            }


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            nom.Text = cin.Text = prenom.Text = tele.Text = username.Text = password.Text = "";
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "SELECT * FROM user where id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id", Program.userID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();

            nom.Text = data.Rows[0]["nom"].ToString();
            prenom.Text = data.Rows[0]["prenom"].ToString();
            cin.Text = data.Rows[0]["cin"].ToString();
            tele.Text = data.Rows[0]["tele"].ToString();
            username.Text = data.Rows[0]["username"].ToString();
            password.Text = data.Rows[0]["password"].ToString();
        }
    }
}
