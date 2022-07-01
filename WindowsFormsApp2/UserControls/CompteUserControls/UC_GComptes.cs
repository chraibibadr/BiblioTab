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

namespace WindowsFormsApp2.UserControls.CompteUserControls
{
    public partial class UC_GComptes : UserControl
    {
        int selectedrowindex;
        DataGridViewRow selectedRow;
        Boolean isSelected = false;

        public UC_GComptes()
        {
            InitializeComponent();
        }

        private void selectRow()
        {
            if (dataGridComptes.SelectedCells.Count > 0)
            {
                isSelected = true;
                selectedrowindex = dataGridComptes.SelectedCells[0].RowIndex;
                selectedRow = dataGridComptes.Rows[selectedrowindex];
                role.SelectedItem = selectedRow.Cells["role"].Value.ToString();
                username.Text = selectedRow.Cells["username"].Value.ToString();
                password.Text = selectedRow.Cells["password"].Value.ToString();
            }
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void loadComptes()
        {
            DataTable data = new DataTable();
            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql1 = "SELECT username,password,role FROM user WHERE isActive = @state";
            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
            cmd1.Parameters.AddWithValue("@state", 0);
            cmd1.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
            adapter.Fill(data);
            dataGridComptes.DataSource = data;
            connection.Close();
        }

        private void genererBtn_Click(object sender, EventArgs e)
        {
            string user = RandomString(8);
            string pass = RandomString(8);
            string compte = "";
            password.Text = pass;
            username.Text = user;
            if(role.SelectedIndex > 0 )
            {
                compte = "Nom d'utilisateur : " + user + " | Mot de passe : " + pass;
                System.Windows.Forms.Clipboard.SetText(compte);

                MySqlConnection connection = new MySqlConnection(Program.cnx);
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();
                cmd.CommandText = "INSERT INTO user (username, password, role, isActive) VALUES (@user, @pass, @role, @state)";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@role", role.SelectedItem.ToString().ToLower());
                cmd.Parameters.AddWithValue("@state", 0);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageForm msg = new MessageForm("Génaration de compte", "Compte bien générer", 2);
                    msg.ShowDialog();
                }

                loadComptes();
                selectRow();
            }
            else
            {
                MessageForm msg = new MessageForm("Information", "Selectionner d'abord le role !", 2);
                msg.ShowDialog();
            }
            

        }

        private void UC_GComptes_Load(object sender, EventArgs e)
        {
            loadComptes();
            selectRow();
        }

        private void dataGridComptes_Click(object sender, EventArgs e)
        {
            selectRow();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string compte = "Nom d'utilisateur : " + username.Text + " | Mot de passe : " + password.Text;
            System.Windows.Forms.Clipboard.SetText(compte);
            MessageForm msg = new MessageForm("Presse Papier", "Bien copier", 2);
            msg.ShowDialog();

        }
    }
}
