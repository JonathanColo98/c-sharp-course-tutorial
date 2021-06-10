using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Esercizio_9
{
    public partial class Form_Home : Form
    {
        //per indiciare un percorso inserire la @ all'inizio della String
        String Path = @"C:\workspaceC-Sharp\c-sharp-course-tutorial\TEMP\Accessi.txt";

        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            using (FileStream FS = new FileStream(Path, FileMode.Append, FileAccess.Write))
            
            using (StreamWriter SW = new StreamWriter(FS))
            {
                SW.WriteLine("Accesso del: " + DateTime.Now);
            }

        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            int Count = 0;

            using (StreamReader SR = new StreamReader(Path))
            {
                string Line = "";
                while ((Line = SR.ReadLine()) != null)
                {
                    if (Count != 0)
                    {
                        // ci sono più righe 
                        txt_Read.Text = txt_Read.Text + "\r\n" + Line;
                    } 
                    else
                    {
                        // c'è una riga sola
                        txt_Read.Text = Line;
                    }
                    Count++;
                }

            }



        }
    }
}
