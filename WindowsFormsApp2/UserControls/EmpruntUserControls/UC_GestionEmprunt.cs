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
    public partial class UC_GestionEmprunt : UserControl
    {
        int selectedrowindex;
        DataGridViewRow selectedRow;
        bool isSelected = false;
        int idEmprunt;

        public UC_GestionEmprunt()
        {
            InitializeComponent();
        }

        private void loadGrid()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string request = "SELECT e.id,c.cin,o.titre,e.dateEmprunt as 'Date emprunt',e.dateRetourP as 'Date a retour', e.dateRetour as 'Date de retour' from ouvrage o INNER JOIN emprunt e on o.id = e.id_ouvrage INNER JOIN client c on e.id_client = c.id  order by e.id desc";
            MySqlCommand cmd = new MySqlCommand(request, connection);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


            adapter.Fill(data);

            dataGridEmprunt.DataSource = data;

            connection.Close();

        }

        private void selectRow()
        {
            if (dataGridEmprunt.SelectedCells.Count > 0)
            {
                isSelected = true;
                selectedrowindex = dataGridEmprunt.SelectedCells[0].RowIndex;
                selectedRow = dataGridEmprunt.Rows[selectedrowindex];
                if (selectedRow.Cells["id"].Value.ToString() != "")
                    idEmprunt = int.Parse(selectedRow.Cells["id"].Value.ToString());
            }
        }

        private void validerEmpruntBtn_Click(object sender, EventArgs e)
        {
            bool upEmp = false;
            bool upOuv = false;
            if(isSelected)
            {
                MySqlConnection connection = new MySqlConnection(Program.cnx);
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();
                cmd.CommandText = "UPDATE emprunt set dateRetour = @dateRetour where id = @id";
                cmd.Parameters.AddWithValue("@dateRetour", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", idEmprunt);

                if (cmd.ExecuteNonQuery() > 0)
                    upEmp = true;

                DataTable data = new DataTable();
                string sql1 = "select id_ouvrage from emprunt WHERE id = @id_emprunt";
                MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
                cmd1.Parameters.AddWithValue("@id_emprunt", idEmprunt);
                cmd1.Prepare();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
                adapter.Fill(data);

                cmd.CommandText = "UPDATE ouvrage set qte = qte + 1 where id = @id_ouvrage";
                cmd.Parameters.AddWithValue("@id_ouvrage", data.Rows[0]["id_ouvrage"].ToString());
                if (cmd.ExecuteNonQuery() > 0)
                    upOuv = true;

                connection.Close();

                if (upEmp == true && upOuv == true)
                {
                    MessageForm msg = new MessageForm("Information", "Emprunt validé!", 2);
                    msg.ShowDialog();
                }
                loadGrid();
            }
            else
            {
                MessageForm msg = new MessageForm("Information", "Aucune emprunt est selectionné !", 2);
                msg.ShowDialog();
            }
            
        }

        private void cin_TextChanged(object sender, EventArgs e)
        {
            if (cin.Text == "")
                loadGrid();
            else
            {
                DataTable data = new DataTable();

                MySqlConnection connection = new MySqlConnection(Program.cnx);
                connection.Open();

                string sql = "SELECT e.id, c.cin,o.titre,e.dateEmprunt as 'Date emprunt',e.dateRetourP as 'Date a retour', e.dateRetour as 'Date de retour' from ouvrage o INNER JOIN emprunt e on o.id = e.id_ouvrage INNER JOIN client c on e.id_client = c.id WHERE e.dateRetour is null and c.cin like @cin order by e.id desc";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@cin", cin.Text+"%");
                cmd.Prepare();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data);
                dataGridEmprunt.DataSource = data;
                connection.Close();
                selectRow();
            }
        }

        private void UC_GestionEmprunt_Load(object sender, EventArgs e)
        {
            loadGrid();
            selectRow();
        }

        private void dataGridEmprunt_Click_1(object sender, EventArgs e)
        {
            selectRow();
        }
    }
}
