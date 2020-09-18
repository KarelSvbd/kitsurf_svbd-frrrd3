using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net;


namespace kitesurf
{
    
    public partial class Frm1 : Form
    {
        public string resultatRequette;

        public static string jsonStr;


        public Frm1()
        {
            InitializeComponent();
            listeMethodes();

        }

        private void listeMethodes()
        {
            string donneesDeConnexion = @"server=localhost;userid=root;password=;database=kitesurf";
            string nomTable = "Windsurf";

            DbConnector(donneesDeConnexion);
            //CreationTable(nomTable, donneesDeConnexion);
            
        }

        private void Frm1_Load(object sender, EventArgs e)
        {


        }

        private void DbConnector(string cs)
        {
            var con = new MySqlConnection(cs);
            con.Open();

            var cmd = new MySqlCommand();
            cmd.Connection = con;




        }
        private void CreationTable(string nomTable, string cs)
        {
            var con = new MySqlConnection(cs);
            con.Open();

            var cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DROP TABLE IF EXISTS " + nomTable;
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE " + nomTable + "(id INTEGER PRIMARY KEY AUTO_INCREMENT, dateHeure TEXT, forceVent INT, directionVent INT)";
            cmd.ExecuteNonQuery();
        }

        private void SupprimerTable(string nomTable, string cs)
        {
            var con = new MySqlConnection(cs);
            con.Open();

            var cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DROP TABLE IF EXISTS " + nomTable;
        }

        //connexion au fichier json

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            RestClient.RestClient rClient = new RestClient.RestClient();

            rClient.endPoint = "https://data.geo.admin.ch/ch.meteoschweiz.messwerte-windgeschwindigkeit-kmh-10min/ch.meteoschweiz.messwerte-windgeschwindigkeit-kmh-10min_en.json";
            debugOutput("RESTClient Object created.");

            string strJSON = string.Empty;

            strJSON = rClient.makeRequest();

            debugOutput(strJSON);

            string resultatRequete = strJSON;
            //Deserialiseur strconvert = new Deserialiseur(resultatRequete);

        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                tbxAiles.Text = tbxAiles.Text + strDebugText + Environment.NewLine;
                tbxAiles.SelectionStart = tbxAiles.TextLength;
                tbxAiles.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void nudPoids_KeyPress(object sender, KeyPressEventArgs e)
        {
            //force à saisir uniquement des int
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
                //test de la sésie du poids
                int poids = Convert.ToInt32(nudPoids.Text);

                if (poids > 300 || poids < 0)
                {
                    MessageBox.Show("Veuillez séléctionner un poids valide", "Mauvaise saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        
    }
}
