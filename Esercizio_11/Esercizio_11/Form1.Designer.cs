
namespace Esercizio_11
{
    partial class Form1
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
            this.lbl_NomeUtente = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.cb_NomeUtente = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.ss_Login = new System.Windows.Forms.StatusStrip();
            this.sslbl_Nome = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslbl_Cognome = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslbl_Reparto = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslbl_Livello = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NomeUtente
            // 
            this.lbl_NomeUtente.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeUtente.Location = new System.Drawing.Point(164, 61);
            this.lbl_NomeUtente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NomeUtente.Name = "lbl_NomeUtente";
            this.lbl_NomeUtente.Size = new System.Drawing.Size(232, 43);
            this.lbl_NomeUtente.TabIndex = 0;
            this.lbl_NomeUtente.Text = "Nome Utente:";
            this.lbl_NomeUtente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(170, 163);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(226, 42);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password:";
            // 
            // cb_NomeUtente
            // 
            this.cb_NomeUtente.FormattingEnabled = true;
            this.cb_NomeUtente.Location = new System.Drawing.Point(414, 61);
            this.cb_NomeUtente.Name = "cb_NomeUtente";
            this.cb_NomeUtente.Size = new System.Drawing.Size(255, 43);
            this.cb_NomeUtente.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(414, 163);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(255, 42);
            this.txt_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(288, 252);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(189, 42);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // ss_Login
            // 
            this.ss_Login.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ss_Login.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslbl_Nome,
            this.sslbl_Cognome,
            this.sslbl_Reparto,
            this.sslbl_Livello});
            this.ss_Login.Location = new System.Drawing.Point(0, 339);
            this.ss_Login.Name = "ss_Login";
            this.ss_Login.Size = new System.Drawing.Size(1115, 22);
            this.ss_Login.TabIndex = 5;
            this.ss_Login.Text = "statusStrip1";
            // 
            // sslbl_Nome
            // 
            this.sslbl_Nome.Name = "sslbl_Nome";
            this.sslbl_Nome.Size = new System.Drawing.Size(0, 15);
            // 
            // sslbl_Cognome
            // 
            this.sslbl_Cognome.Name = "sslbl_Cognome";
            this.sslbl_Cognome.Size = new System.Drawing.Size(0, 15);
            this.sslbl_Cognome.Click += new System.EventHandler(this.sslbl_Cognome_Click);
            // 
            // sslbl_Reparto
            // 
            this.sslbl_Reparto.Name = "sslbl_Reparto";
            this.sslbl_Reparto.Size = new System.Drawing.Size(0, 15);
            // 
            // sslbl_Livello
            // 
            this.sslbl_Livello.Name = "sslbl_Livello";
            this.sslbl_Livello.Size = new System.Drawing.Size(0, 15);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 361);
            this.Controls.Add(this.ss_Login);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.cb_NomeUtente);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_NomeUtente);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ss_Login.ResumeLayout(false);
            this.ss_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomeUtente;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.ComboBox cb_NomeUtente;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.StatusStrip ss_Login;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_Nome;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_Cognome;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_Reparto;
        private System.Windows.Forms.ToolStripStatusLabel sslbl_Livello;
    }
}

