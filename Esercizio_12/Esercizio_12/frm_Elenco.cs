using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_12
{
    public partial class frm_Elenco : Form
    {
        BibliotecaEntities library;

        public frm_Elenco()
        {
            InitializeComponent();
        }

        private void frm_Elenco_Load(object sender, EventArgs e)
        {
            //visualizzazione tabella Utenti 
            library = new BibliotecaEntities();
            grd_Utenti.DataSource = library.tbl_Utenti.ToArray();
        }

        private void grd_Utenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
