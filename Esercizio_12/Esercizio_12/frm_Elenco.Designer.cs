
namespace Esercizio_12
{
    partial class frm_Elenco
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grd_Utenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Utenti)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Utenti
            // 
            this.grd_Utenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Utenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Utenti.Location = new System.Drawing.Point(0, 0);
            this.grd_Utenti.Name = "grd_Utenti";
            this.grd_Utenti.RowHeadersWidth = 62;
            this.grd_Utenti.RowTemplate.Height = 28;
            this.grd_Utenti.Size = new System.Drawing.Size(952, 450);
            this.grd_Utenti.TabIndex = 0;
            this.grd_Utenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Utenti_CellContentClick);
            // 
            // frm_Elenco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.grd_Utenti);
            this.Name = "frm_Elenco";
            this.Text = "Elenco Utenti";
            this.Load += new System.EventHandler(this.frm_Elenco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Utenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Utenti;
    }
}

