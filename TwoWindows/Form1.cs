using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TwoWindows
{
    public partial class Form1 : Form
    {
        private MySqlConnection cnx;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            string chaineConnexion;
            chaineConnexion = "SERVER=" + txtHost.Text + ";" + "DATABASE=" + txtDB.Text + ";" + "UID=" + txtID.Text + ";" + "PASSWORD=" + txtMDP.Text + ";";
            if (btnConnecter.Text == "Connecter")
            {
                cnx = new MySqlConnection(chaineConnexion);
                try
                {
                    cnx.Open();
                    btnConnecter.Text = "Déconnecter";
                    btnVoir.Enabled = true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Err ouv." + ex.ToString() + ": " + ex.Message);
                }
            }
            else
            {
                try
                {
                    cnx.Close();
                    btnConnecter.Text = "Connecter";
                    btnVoir.Enabled = false;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Err fin " + ex.ToString() + ": " + ex.Message);
                }
            }
        }
        private List<Personne> listPerson = new List<Personne>();

        public DateTime Convert2C(String sqlDate)
        {
            return DateTime.Parse(sqlDate);
        }

        private void bVoir_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM utilisateurs";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            txtVoir.Text = "";
            listPerson.Clear();
            while (dataReader.Read())
            {
                listPerson.Add(new Personne(dataReader["userFirstName"].ToString(),
                dataReader["userLastName"].ToString(),
                Convert2C(dataReader["userBirthDay"].ToString())));
            }
            dataReader.Close();
            foreach (Personne tttt in listPerson)
            {
                txtVoir.Text = txtVoir.Text + tttt.Prenom + "\t" + tttt.Nom + "\t" +
                tttt.Dnaissance.ToString("dd-MM-yyyy") + Environment.NewLine;
            }
        }
        public class Personne
        {
            // attributs de l'objet : un par colonne
            private String prenom;
            private String nom;
            private DateTime dnaissance;
            // méthodes d'accès (get/set)
            public String Prenom { get => prenom; set => prenom = value; }
            public String Nom { get => nom; set => nom = value; }
            public DateTime Dnaissance { get => dnaissance; set => dnaissance = value; }
            // méthodes de conversion SQL <-> C# (les formats sont différents)
            public String Convert2MySQL(DateTime dt)
            {
                return dt.ToString("yyyy-MM-dd HH:mm:ss");
            }
            public Personne(String prenom, String nom, DateTime madate)
            {
                this.prenom = prenom;
                this.nom = nom;
                this.dnaissance = madate;
            }

        }
    }
}
