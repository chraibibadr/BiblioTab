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
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void loadDispoLivres()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "select SUM(qte) as disponible from ouvrage WHERE type LIKE 'l'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();
            disLivre.Text = data.Rows[0]["disponible"].ToString();
        }

        private void loadEmpLivres()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "select count(id_ouvrage) emprunter from emprunt WHERE dateRetour is null  and id_ouvrage in (SELECT id from ouvrage WHERE type like 'l')";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();
            emLivre.Text = data.Rows[0]["emprunter"].ToString();
        }

        private void loadDispoCDs()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "select SUM(qte) as disponible from ouvrage WHERE type LIKE 'cd'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();
            disCD.Text = data.Rows[0]["disponible"].ToString();
        }

        private void loadEmpCDs()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "select count(id_ouvrage) emprunter from emprunt WHERE dateRetour is null  and id_ouvrage in (SELECT id from ouvrage WHERE type like 'cd')";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();
            emCD.Text = data.Rows[0]["emprunter"].ToString();
        }

        private void loadDispoPer()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "select SUM(qte) as disponible from ouvrage WHERE type LIKE 'p'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();
            disPer.Text = data.Rows[0]["disponible"].ToString();
        }
        private void loadEmpPer()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "select count(id_ouvrage) emprunter from emprunt WHERE dateRetour is null  and id_ouvrage in (SELECT id from ouvrage WHERE type like 'p')";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();
            emPer.Text = data.Rows[0]["emprunter"].ToString();
        }

        private void fillChart()
        {
            DataTable data = new DataTable();

            MySqlConnection connection = new MySqlConnection(Program.cnx);
            connection.Open();

            string sql = "select COUNT(e.id) as 'Nombre des emprunts',c.cin FROM emprunt e inner JOIN client c on e.id_client = c.id GROUP BY e.id_client";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            chart1.DataSource = data;
            connection.Close();
            chart1.Series["Emprunts"].XValueMember = "CIN";
            chart1.Series["Emprunts"].YValueMembers = "Nombre des emprunts";
            chart1.Series["Emprunts"].Color = Color.FromArgb(26, 188, 156);
            chart1.Series["Emprunts"].LabelBackColor = Color.FromArgb(26, 188, 156);
            chart1.Series["Emprunts"].LabelForeColor = Color.White;
            chart1.Series["Emprunts"].IsValueShownAsLabel = true;

            //chart1.Titles.Add("Nombres des emprunts par clients");
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            loadDispoLivres();
            loadDispoCDs();
            loadDispoPer();
            loadEmpLivres();
            loadEmpCDs();
            loadEmpPer();
            fillChart();
        }
    }
}
