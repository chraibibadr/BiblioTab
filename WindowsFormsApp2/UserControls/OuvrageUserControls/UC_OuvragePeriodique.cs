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

namespace WindowsFormsApp2.UserControls.OuvrageUserControls
{
    public partial class UC_OuvragePeriodique : UserControl
    {
        int selectedrowindex;
        DataGridViewRow selectedRow;
        Boolean isSelected = false;

        public UC_OuvragePeriodique()
        {
            InitializeComponent();
            modifierBtn.Enabled = false;
            loadGrid();
        }

        private void clearTxtBoxs()
        {
            numero.Clear();
            titre.Clear();
            periodacite.SelectedIndex = 0;
            qte.Clear();
        }

        private void loadGrid()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            String request = "SELECT id, titre, numero, periodicite, qte as quantite FROM ouvrage WHERE type = 'p'";
            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridPer.DataSource = data;
            Program.colorGrid(dataGridPer);

            connection.Close();
            clearTxtBoxs();
            isSelected = false;
            modifierBtn.Enabled = false;
            ajouterBtn.Enabled = true;

        }

        private void UC_OuvragePeriodique_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            if (numero.Text != "" && titre.Text != "" && periodacite.SelectedIndex >=  1 && qte.Text != "")
            {
                int a;
                if (int.TryParse(qte.Text, out a))
                {
                    MySqlConnection connection = new MySqlConnection(Program.cnx);
                    connection.Open();

                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO ouvrage (titre, numero, periodicite, type, qte, isEmprunt) VALUES (@titre, @numero, @periodicite, @type, @qte, false)";
                    cmd.Parameters.AddWithValue("@titre", titre.Text);
                    cmd.Parameters.AddWithValue("@numero", numero.Text);
                    cmd.Parameters.AddWithValue("@periodicite", periodacite.SelectedItem);
                    cmd.Parameters.AddWithValue("@qte", qte.Text);
                    cmd.Parameters.AddWithValue("@type", "p");

                    cmd.ExecuteNonQuery();

                    clearTxtBoxs();
                    connection.Close();

                    loadGrid();
                }
                else
                {
                    MessageForm msg = new MessageForm("Information", "Saisir une quantite avec une valeur numerique !", 2);
                    msg.ShowDialog();
                }
            }
            else
            {
                MessageForm msg = new MessageForm("Information", "Saisir d'abord les informations !", 2);
                msg.ShowDialog();
            }
        }

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            if (isSelected == false)
            {
                MessageForm msg = new MessageForm("Information", "Selectionner d'abord une Périodique !!", 2);
                msg.ShowDialog();
            }
            else
            {
                MessageForm msg = new MessageForm("Modification", "Voulez vous bien modifier cet périodique !", 1);
                msg.ShowDialog();
                if (Program.MessageFormReplay == "yes")
                {
                    int a;
                    if (int.TryParse(qte.Text, out a))
                    {
                        MySqlConnection connection = new MySqlConnection(Program.cnx);
                        connection.Open();

                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "UPDATE ouvrage set titre = @titre, numero = @numero, periodicite = @periodicite, qte = @qte where id = @id";
                        cmd.Parameters.AddWithValue("@titre", titre.Text);
                        cmd.Parameters.AddWithValue("@numero", numero.Text);
                        cmd.Parameters.AddWithValue("@periodicite", periodacite.SelectedItem);
                        cmd.Parameters.AddWithValue("@qte", qte.Text);
                        cmd.Parameters.AddWithValue("@id", Convert.ToString(selectedRow.Cells["id"].Value));

                        cmd.ExecuteNonQuery();

                        clearTxtBoxs();
                        connection.Close();

                        loadGrid();
                    }
                    else
                    {
                        MessageForm msg2 = new MessageForm("Information", "Saisir une quantite avec une valeur numerique !", 2);
                        msg2.ShowDialog();
                    }
                }
                else
                    loadGrid();

            }
        }

        private void dataGridPer_Click(object sender, EventArgs e)
        {
            if (dataGridPer.SelectedCells.Count > 0)
            {
                modifierBtn.Enabled = true;
                ajouterBtn.Enabled = false;

                isSelected = true;
                selectedrowindex = dataGridPer.SelectedCells[0].RowIndex;
                selectedRow = dataGridPer.Rows[selectedrowindex];
                titre.Text = Convert.ToString(selectedRow.Cells["titre"].Value);
                numero.Text = Convert.ToString(selectedRow.Cells["numero"].Value);
                qte.Text = Convert.ToString(selectedRow.Cells["quantite"].Value);
                periodacite.SelectedItem = Convert.ToString(selectedRow.Cells["periodicite"].Value);
            }
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            if (isSelected == false)
            {
                MessageForm msg = new MessageForm("Information", "Selectionner d'abord une périodique !!", 2);
                msg.ShowDialog();
            }
            else
            {
                MessageForm msg = new MessageForm("Suppression", "Voulez vous bien supprimer cet périodique !", 1);
                msg.ShowDialog();
                if (Program.MessageFormReplay == "yes")
                {
                    DataTable data = new DataTable();

                    MySqlConnection connection = new MySqlConnection(Program.cnx);
                    connection.Open();


                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "delete from ouvrage where id = @id";
                    cmd.Parameters.AddWithValue("@id", Convert.ToString(selectedRow.Cells["id"].Value));

                    cmd.ExecuteNonQuery();
                    clearTxtBoxs();
                    connection.Close();

                    loadGrid();
                }
                else
                    loadGrid();
            }
        }

        private void searchName_TextChanged(object sender, EventArgs e)
        {
            if (searchName.Text == "")
                loadGrid();
            else
            {
                DataTable data = new DataTable();

                MySqlConnection connection = new MySqlConnection(Program.cnx);
                connection.Open();

                string sql = "SELECT id, titre, numero, periodicite, qte as quantite FROM ouvrage WHERE type = 'p' and titre like @titre";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@titre", searchName.Text + "%");
                cmd.Prepare();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridPer.DataSource = data;
                connection.Close();
                Program.colorGrid(dataGridPer);
                dataGridPer_Click(sender, e);
            }
        }
    }
}
