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
    public partial class UC_GestionComptes : UserControl
    {
        int selectedrowindex;
        DataGridViewRow selectedRow;
        Boolean isSelected = false;
        int id = -1;

        public UC_GestionComptes()
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
                id = Convert.ToInt32(selectedRow.Cells["id"].Value);
            }
        }

        private void loadComptes()
        {
            DataTable data = new DataTable();
            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql1 = "SELECT id,username,nom,prenom,role,IF(isActive = 1, 'activer','desactiver') as etat FROM user WHERE isActive in (-1,1) and id != @user";
            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
            cmd1.Parameters.AddWithValue("@user", Program.userID);
            cmd1.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
            adapter.Fill(data);
            dataGridComptes.DataSource = data;
            connection.Close();
        }

        private void UC_GestionComptes_Load(object sender, EventArgs e)
        {
            loadComptes();
            selectRow();
            colorActivateBtn();
        }

        private void cin_TextChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql1 = "SELECT id,username,nom,prenom,role,IF(isActive = 1, 'activer','desactiver') as etat FROM user WHERE username like @user";
            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
            cmd1.Parameters.AddWithValue("@user", usernameTxt.Text+"%");
            cmd1.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
            adapter.Fill(data);
            dataGridComptes.DataSource = data;
            connection.Close();
            selectRow();
        }

        private void colorActivateBtn()
        {
            if (selectedRow.Cells["etat"].Value.ToString() == "activer")
            {
                stateBtn.FillColor = Color.IndianRed;
                stateBtn.Text = "Desactiver le compte";
            }
            else if (selectedRow.Cells["etat"].Value.ToString() == "desactiver")
            {
                stateBtn.FillColor = Color.FromArgb(27, 188, 156);
                stateBtn.Text = "Activer le compte";
            }
        }

        private void dataGridComptes_Click(object sender, EventArgs e)
        {
            selectRow();
            colorActivateBtn();
        }

        private void stateBtn_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                if (selectedRow.Cells["etat"].Value.ToString() == "activer")
                {
                    MessageForm msg = new MessageForm("Desactivation", "Voulez vous desactiver ce compte !", 1);
                    msg.ShowDialog();
                    if (Program.MessageFormReplay == "yes")
                    {
                        MySqlConnection connection = new MySqlConnection(Program.cnx);
                        connection.Open();

                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "UPDATE user set isActive = -1 where id = @id";
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        connection.Close();

                        loadComptes();
                        selectRow();
                        MessageForm m = new MessageForm("Desactivation", "Compte bien desactiver !", 2);
                        m.ShowDialog();
                    }
                }
                else if (selectedRow.Cells["etat"].Value.ToString() == "desactiver")
                {
                    MessageForm msg = new MessageForm("Activation", "Voulez vous activer ce compte !", 1);
                    msg.ShowDialog();
                    if (Program.MessageFormReplay == "yes")
                    {
                        MySqlConnection connection = new MySqlConnection(Program.cnx);
                        connection.Open();

                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "UPDATE user set isActive = 1 where id = @id";
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        connection.Close();

                        loadComptes();
                        selectRow();
                        MessageForm m = new MessageForm("Activation", "Compte bien activer !", 2);
                        m.ShowDialog();
                    }
                }
            }
            else
            {
                MessageForm msg = new MessageForm("Information", "Selectionner un compte !", 2);
                msg.ShowDialog();
            }
        }

        private void dataGridComptes_SelectionChanged(object sender, EventArgs e)
        {
            selectRow();
            colorActivateBtn();
        }
    }
}
