using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Esercizio_11
{
    public partial class Form1 : Form
    {
        //connessione
        public SqlConnection sqlCnn;

        //percorso database 
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\workspaceC-Sharp\c-sharp-course-tutorial\DataBase\Biblioteca.mdf;Integrated Security=True;Connect Timeout=30";
        
        //oggetto predisposto a trasportare i dati
        public SqlDataAdapter adapter = new SqlDataAdapter();

        //specifica dell'operazione da svolgere
        public SqlCommand sqlCmd;

        //dove posizionare i dati
        public DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql_query = "SELECT * FROM tbl_Utenti";
            sqlCnn = new SqlConnection(connectionString);
            //aprire la connessione
            try
            {
                //apro la connessione al db
                sqlCnn.Open();
                //descrizione del comando
                sqlCmd = new SqlCommand(sql_query, sqlCnn);
                //oggetto che deve trasportare i dati
                adapter.SelectCommand = sqlCmd;
                //riempio il data set
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message.ToString());
            }
            //chiudo la connessione
            sqlCnn.Close();

            // Nel Dataset trovo tutti i dati che mi servono.

            int numberRows;
            numberRows = ds.Tables[0].Rows.Count;

            //popolare combobox iniziale
            for(int i=0; i<numberRows; i++)
            {
                cb_NomeUtente.Items.Add(ds.Tables[0].Rows[i][1].ToString());

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string PassInsert = txt_Password.Text;
            string sql_Query = "SELECT * FROM tbl_Utenti WHERE NomeUtente = '" + cb_NomeUtente.Text.ToString() + "'";
            sqlCnn = new SqlConnection(connectionString);
            ds.Tables.Clear();
            try
            {
                sqlCnn.Open();
                sqlCmd = new SqlCommand(sql_Query, sqlCnn);
                adapter.SelectCommand = sqlCmd;
                adapter.Fill(ds);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlCnn.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][2].ToString() == PassInsert)
                {
                    sslbl_Nome.Text = "Nome: " + ds.Tables[0].Rows[0][3].ToString();
                    sslbl_Cognome.Text = "Cognome: " + ds.Tables[0].Rows[0][4].ToString();
                    sslbl_Reparto.Text = "Reparto: " + ds.Tables[0].Rows[0][5].ToString();
                    sslbl_Livello.Text = "Livello: " + ds.Tables[0].Rows[0][6].ToString();
                    MessageBox.Show("Password corretta");
                }
                else
                {
                    MessageBox.Show("Password non corretta");
                }
            }
            else
            {
                MessageBox.Show("Utente non trovato");
            }

        }

        private void sslbl_Cognome_Click(object sender, EventArgs e)
        {

        }
    }
}
 