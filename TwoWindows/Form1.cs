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
                    btnajouter.Enabled = true;
                    nomtxt.Enabled = true;
                    prenomtxt.Enabled = true;
                    naissancetxt.Enabled = true;
                    
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
                    btnajouter.Enabled = false;
                    nomtxt.Enabled = false;
                    prenomtxt.Enabled = false;
                    naissancetxt.Enabled = false;
                    txtVoir.Enabled = true;
                    txtVoir.Text = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Err fin " + ex.ToString() + ": " + ex.Message);
                }
            }
        }
        private List<Personne> listPerson = new List<Personne>();


        private void bVoir_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM utilisateurs";
            MySqlCommand cmd = new MySqlCommand(query, cnx);

            MySqlDataReader dataReader = cmd.ExecuteReader();
            txtVoir.Text = "";
            listPerson.Clear();
            while (dataReader.Read())
            {
                listPerson.Add(new Personne(
                    dataReader["userFirstName"].ToString(),
                    dataReader["userLastName"].ToString(),
                    dataReader["userBirthDay"].ToString()));
            }
            dataReader.Close();
            foreach (Personne tttt in listPerson)
            {
                txtVoir.Text = txtVoir.Text + tttt.Prenom + "\t" + tttt.Nom + "\t" +
                tttt.Dnaissance + Environment.NewLine;
            }
        }
        public class Personne
        {
            // attributs de l'objet : un par colonne
            private String prenom;
            private String nom;
            private String dnaissance;
            // méthodes d'accès (get/set)
            public String Prenom { get => prenom; set => prenom = value; }
            public String Nom { get => nom; set => nom = value; }
            public String Dnaissance { get => dnaissance; set => dnaissance = value; }

            public Personne(String prenom, String nom, String madate)
            {
                this.prenom = prenom;
                this.nom = nom;
                this.dnaissance = madate;
            }

        }

        public void btnajouter_Click(object sender, EventArgs e)
        {
            string nom = nomtxt.Text;
            string prenom = prenomtxt.Text;
            DateTime Date = naissancetxt.Value;
            string DateNaissance = Date.ToShortDateString();

            string queryinsert = "INSERT INTO `utilisateurs`(`userFirstName` , `userLastName` , `userBirthDay`) VALUES ('" + nom + "' , '" + prenom + "' , '" + DateNaissance + "')";
            MySqlCommand cmdinsert = new MySqlCommand(queryinsert, cnx);
            cmdinsert.ExecuteNonQuery();

        }
    }
}
