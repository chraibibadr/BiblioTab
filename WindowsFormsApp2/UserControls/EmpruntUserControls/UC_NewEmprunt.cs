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

namespace WindowsFormsApp2.UserControls.EmpruntUserControls
{
    public partial class UC_NewEmprunt : UserControl
    {
        int selectedrowindex;
        DataGridViewRow selectedRow;
        Boolean isSelected = false;
        int idOuvrage;

        public UC_NewEmprunt()
        {
            InitializeComponent();
            radioCD.Checked = true;
        }

        private void loadCD()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string request = "SELECT id, titre, auteur,qte as quantite FROM ouvrage WHERE type = 'cd'";
            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridEmprunt.DataSource = data;

            connection.Close();
        }

        private void loadLivre()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string request = "SELECT id, titre, auteur, editeur,qte as quantite FROM ouvrage WHERE type = 'l'";
            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridEmprunt.DataSource = data;

            connection.Close();
        }

        private void loadPeriodique()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string request = "SELECT id, titre, numero, periodicite, qte as quantite FROM ouvrage WHERE type = 'p'";
            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridEmprunt.DataSource = data;

            connection.Close();
        }

        private void loadGrid()
        {
            if (radioCD.Checked == true)
                loadCD();
            if (radioLivre.Checked == true)
                loadLivre();
            if (radioPer.Checked == true)
                loadPeriodique();

            Program.colorGrid(dataGridEmprunt);

            cin.Clear();
            nom.Clear();
            prenom.Clear();
            tele.Clear();
        }

        private void selectRow()
        {
            idOuvrage = -1;
            if (dataGridEmprunt.SelectedCells.Count > 0)
            {
                isSelected = true;
                selectedrowindex = dataGridEmprunt.SelectedCells[0].RowIndex;
                selectedRow = dataGridEmprunt.Rows[selectedrowindex];
                if(selectedRow.Cells["id"].Value.ToString() != "")
                idOuvrage = int.Parse(selectedRow.Cells["id"].Value.ToString());
            }
        }

        private void UC_NewEmprunt_Load(object sender, EventArgs e)
        {
            loadGrid();
            selectRow();
            dateRP.MinDate = DateTime.Now.AddDays(1);
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            if(recherche.Text == "")
                loadGrid();
            else
            {
                if(radioCD.Checked == true)
                {
                    DataTable data = new DataTable();

                    MySqlConnection connection = new MySqlConnection(Program.cnx);
                    connection.Open();

                    string sql = "SELECT id, titre, auteur,qte as quantite FROM ouvrage WHERE type = 'cd' and titre like @titre";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@titre", recherche.Text + "%");
                    cmd.Prepare();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(data);
                    dataGridEmprunt.DataSource = data;
                    connection.Close();
                }
                if (radioLivre.Checked == true)
                {
                    DataTable data = new DataTable();

                    MySqlConnection connection = new MySqlConnection(Program.cnx);
                    connection.Open();

                    string sql = "SELECT id, titre, auteur,editeur, qte as quantite FROM ouvrage WHERE type = 'l' and titre like @titre";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@titre", recherche.Text + "%");
                    cmd.Prepare();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(data);
                    dataGridEmprunt.DataSource = data;
                    connection.Close();
                }
                if (radioPer.Checked == true)
                {
                    DataTable data = new DataTable();

                    MySqlConnection connection = new MySqlConnection(Program.cnx);
                    connection.Open();

                    string sql = "SELECT id, titre, numero, periodicite, qte as quantite FROM ouvrage WHERE type = 'p' and titre like @titre";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@titre", recherche.Text + "%");
                    cmd.Prepare();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(data);
                    dataGridEmprunt.DataSource = data;
                    connection.Close();
                }

            }
            selectRow();
        }

        private void radioPer_CheckedChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void radioCD_CheckedChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void radioLivre_CheckedChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void dataGridEmprunt_Click(object sender, EventArgs e)
        {
            selectRow();
        }

        private int getClientId()
        {
            DataTable data = new DataTable();
            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql1 = "SELECT * FROM client WHERE cin = @cin";
            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
            cmd1.Parameters.AddWithValue("@cin", cin.Text);
            cmd1.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
            adapter.Fill(data);
            connection.Close();
            if (data.Rows.Count > 0)
                return int.Parse(data.Rows[0]["id"].ToString());
            return -1;
        }

        private void emprunterBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(Program.cnx);
            MySqlCommand cmd = connection.CreateCommand();
            if (idOuvrage == -1)
            {
                MessageForm msg = new MessageForm("Information", "Selectionner d'abord un ouvrage", 2);
                msg.ShowDialog();
            }
            else
            {
                if (cin.Text != "" && nom.Text != "" && prenom.Text != "" && tele.Text != "")
                {
                    int tel;
                    if (int.TryParse(tele.Text, out tel))
                    {
                        int idClient = getClientId();
                        if (idClient == -1)
                        {
                            connection.Open();
                            cmd.CommandText = "INSERT INTO client (nom, prenom, cin, tele) VALUES (@nom, @prenom, @cin, @tele)";
                            cmd.Parameters.AddWithValue("@nom", nom.Text);
                            cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                            cmd.Parameters.AddWithValue("@cin", cin.Text);
                            cmd.Parameters.AddWithValue("@tele", tele.Text);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            idClient = getClientId();
                        }
                        if (idClient != -1)
                        {
                            connection.Open();
                            DataTable data = new DataTable();
                            string sql1 = "select id,id_ouvrage,dateEmprunt from emprunt WHERE dateRetour is null AND id_client = @id_client ORDER BY dateEmprunt ASC";
                            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
                            cmd1.Parameters.AddWithValue("@id_client", idClient);
                            cmd1.Prepare();
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
                            adapter.Fill(data);
                            connection.Close();

                            if (data.Rows.Count >= 3)
                            {
                                MessageForm msg = new MessageForm("Information", "Ce client a déjà atteint 3 emprunts !", 2);
                                msg.ShowDialog();
                            }
                            else
                            {
                                bool commit = true;
                                bool commit2 = true;
                                for (int i = 0; i < data.Rows.Count; i++)
                                {
                                    if (int.Parse(data.Rows[i]["id_ouvrage"].ToString()) == idOuvrage)
                                    {
                                        commit = false;
                                        break;
                                    }
                                }
                                if (data.Rows.Count > 0)
                                {
                                    DateTime d1 = DateTime.Parse(data.Rows[0]["dateEmprunt"].ToString());
                                    double days = 0;
                                    days = (d1 - DateTime.Now).TotalDays;
                                    if (days < 0)
                                        days *= -1;
                                    if (days > 7)
                                        commit2 = false;
                                    //}

                                    if (commit == true && commit2 == true)
                                    {
                                        if (int.Parse(selectedRow.Cells["quantite"].Value.ToString()) > 0)
                                        {
                                            bool upEmp = false;
                                            bool upQte = false;
                                            connection.Open();
                                            cmd.CommandText = "INSERT INTO emprunt (id_ouvrage, id_client, id_user, dateRetourP, dateEmprunt) VALUES (@id_ouvrage, @id_client, @id_user, @dateRetourP, @dateEmprunt)";
                                            cmd.Parameters.AddWithValue("@id_ouvrage", idOuvrage);
                                            cmd.Parameters.AddWithValue("@id_client", idClient);
                                            cmd.Parameters.AddWithValue("@id_user", Program.userID);
                                            cmd.Parameters.AddWithValue("@dateRetourP", dateRP.Value);
                                            cmd.Parameters.AddWithValue("@dateEmprunt", DateTime.Now);

                                            if (cmd.ExecuteNonQuery() > 0)
                                                upEmp = true;

                                            MySqlCommand cmdQte = connection.CreateCommand();
                                            cmdQte.CommandText = "UPDATE ouvrage set qte = qte - 1 where id = @id_ouvrage";
                                            cmdQte.Parameters.AddWithValue("@id_ouvrage", idOuvrage);

                                            if (cmdQte.ExecuteNonQuery() > 0)
                                                upQte = true;

                                            connection.Close();

                                            if (upEmp == true && upQte == true)
                                            {
                                                MessageForm msg = new MessageForm("Emprunter", "Bien emprunter!", 2);
                                                msg.ShowDialog();
                                            }
                                            else
                                            {
                                                MessageForm msg = new MessageForm("Error", "Une erreur est survenue!", 2);
                                                msg.ShowDialog();
                                            }
                                            loadGrid();
                                        }
                                        else
                                        {
                                            MessageForm msg = new MessageForm("Emprunter", "L'ouvrage choisi est complètement épuisé !", 2);
                                            msg.ShowDialog();
                                        }
                                    }
                                    else if (commit == false)
                                    {
                                        MessageForm msg = new MessageForm("Emprunter", "Ce client a deja umprunter cette ouvrage !", 2);
                                        msg.ShowDialog();
                                    }
                                    else if (commit2 == false)
                                    {
                                        MessageForm msg = new MessageForm("Emprunter", "Ce client a depassé la periode de 7j", 2);
                                        msg.ShowDialog();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageForm msg = new MessageForm("Information", "Saisir un numero de telephone avec des valeurs numeriques !", 2);
                            msg.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageForm msg = new MessageForm("Information", "Saisir d'abord les informations du client !", 2);
                        msg.ShowDialog();
                    }
                }

            }
        }

        private void cin_TextChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql1 = "SELECT * FROM client WHERE cin = @cin";
            MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
            cmd1.Parameters.AddWithValue("@cin", cin.Text);
            cmd1.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
            adapter.Fill(data);
            connection.Close();
            if (data.Rows.Count > 0)
            {
                nom.Text = data.Rows[0]["nom"].ToString();
                prenom.Text = data.Rows[0]["prenom"].ToString();
                tele.Text = data.Rows[0]["tele"].ToString();
            }
                
        }
    }
}