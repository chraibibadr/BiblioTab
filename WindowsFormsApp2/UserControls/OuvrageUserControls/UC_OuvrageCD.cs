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
    public partial class UC_OuvrageCD : UserControl
    {
        int selectedrowindex;
        DataGridViewRow selectedRow;
        Boolean isSelected = false;

        public UC_OuvrageCD()
        {
            InitializeComponent();
            modifierBtn.Enabled = false;
            loadGrid();
        }

        private void clearTxtBoxs()
        {
            auteur.Clear();
            titre.Clear();
            qte.Clear();
        }

        private void loadGrid()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            String request = "SELECT id, titre, auteur,qte as quantite FROM ouvrage WHERE type = 'cd'";
            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridCD.DataSource = data;
            Program.colorGrid(dataGridCD);

            connection.Close();
            clearTxtBoxs();
            isSelected = false;
            modifierBtn.Enabled = false;
            ajouterBtn.Enabled = true;

        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            if (auteur.Text != "" && titre.Text != "" && qte.Text != "")
            {
                int a;
                if(int.TryParse(qte.Text, out a))
                {
                    MySqlConnection connection = new MySqlConnection(Program.cnx);
                    connection.Open();

                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO ouvrage (titre, auteur, type, qte, isEmprunt) VALUES (@titre, @auteur, @type, @qte, false)";
                    cmd.Parameters.AddWithValue("@titre", titre.Text);
                    cmd.Parameters.AddWithValue("@auteur", auteur.Text);
                    cmd.Parameters.AddWithValue("@qte", qte.Text);
                    cmd.Parameters.AddWithValue("@type", "cd");

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

        private void UC_OuvrageCD_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            if(isSelected == false)
            {
                MessageForm msg = new MessageForm("Information", "Selectionner d'abord un cd !!", 2);
                msg.ShowDialog();
            }
            else
            {
                MessageForm msg = new MessageForm("Suppression", "Voulez vous bien supprimer ce CD !", 1);
                msg.ShowDialog();
                if(Program.MessageFormReplay == "yes")
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

        private void modifierBtn_Click(object sender, EventArgs e)
        {
            if (isSelected == false)
            {
                MessageForm msg = new MessageForm("Information", "Selectionner d'abord un cd !!", 2);
                msg.ShowDialog();
            }
            else
            {
                MessageForm msg = new MessageForm("Modification", "Voulez vous bien modifier ce CD !", 1);
                msg.ShowDialog();
                if (Program.MessageFormReplay == "yes")
                {

                    int a;
                    if (int.TryParse(qte.Text, out a))
                    {
                        MySqlConnection connection = new MySqlConnection(Program.cnx);
                        connection.Open();

                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "UPDATE ouvrage set titre = @titre, auteur = @auteur, qte = @qte where id = @id";
                        cmd.Parameters.AddWithValue("@titre", titre.Text);
                        cmd.Parameters.AddWithValue("@auteur", auteur.Text);
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

        private void dataGridCD_Click(object sender, EventArgs e)
        {
            if (dataGridCD.SelectedCells.Count > 0)
            {
                modifierBtn.Enabled = true;
                ajouterBtn.Enabled = false;

                isSelected = true;
                selectedrowindex = dataGridCD.SelectedCells[0].RowIndex;
                selectedRow = dataGridCD.Rows[selectedrowindex];
                titre.Text = Convert.ToString(selectedRow.Cells["titre"].Value);
                auteur.Text = Convert.ToString(selectedRow.Cells["auteur"].Value);
                qte.Text = Convert.ToString(selectedRow.Cells["quantite"].Value);
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

                string sql = "SELECT id, titre, auteur,qte as quantite FROM ouvrage WHERE type = 'cd' and titre like @titre";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@titre", searchName.Text + "%");
                cmd.Prepare();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridCD.DataSource = data;
                connection.Close();
                Program.colorGrid(dataGridCD);
                dataGridCD_Click(sender,e);
            }
        }
    }
}
