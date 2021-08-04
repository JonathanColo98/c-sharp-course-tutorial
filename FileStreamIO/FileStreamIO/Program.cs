using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamIO
{
    class Program
    {
        /*
        - path: dove è localizzato il file.
        - append: se il file esiste vengono aggiunti dati alla fine del file, se non esite il file viene sovrascritto.
        - text: testo da salvare.
        - contents: collezione di stringhe scritte.
        - source: locazione del file che vuoi usare.
        - dest: locazione del file che vuoi raggiungere.
        */

        static async Task Main(string[] args)
        {
            // lettura del contenuto di un file 
            string text = File.ReadAllText(@"C:\MyFolder\MyTextFile.txt");

            // lettura come un array di righe
            string[] lines = File.ReadAllLines(@"C:\MyFolder\MyTextFile.txt");

            // per leggere file di grandi dimensioni incapsulare all'interno di IEnumerable
            // il secondo parametro è opzionale
            IEnumerable<string> AllLines = File.ReadLines("file_name.txt", Encoding.Default);

            // per scrivere in maniera asincrona su un file 
            string filename = @"C:\MyFolder\MyTextFile.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
            {
                // si può scrivere una stringa o un array di char
                await file.WriteAsync(text);
            }

            // copia di un file
            // NB: valutare l'utilizzo di opportuno thread
            File.Copy(@"sourcePath\abc.txt", @"destinationPath\abc.txt");

            // scrivere linee su un file tramite uno Stream Writer
            string[] linesString = { "My first string", "My second string", "and even a third string" };
            using (StreamWriter sw = new StreamWriter(@"C:\MyFolder\OutputText.txt"))
            {
                foreach (string line in linesString)
                {
                    sw.WriteLine(line);
                }
            }

            // scrivere su un file usando System.IO.File
            string textFile = "String that will be stored in the file";
            File.WriteAllText(@"C:\MyFolder\OutputFile.txt", textFile);

            // creare un file in più modi

            //1)
            var fileStream1 = File.Create("samplePath");

            //2)
            using (var fileStream = File.Create("samplePath"))
            {
                /// you can write to the fileStream
            }

            //3)
            File.Create("samplePath").Close();

            /**
             * FileMode: "Dovrei crearlo? Aprirlo? Crearlo se non esiste o aprirlo?" .
               FileAccess: "Dovrei leggerlo, scriverlo o entrambi?".
               FileShare: "Gli utenti dovrebbero leggerlo, scriverlo mentre anche io lo sto usando?"
             */

            var fileStream2 = new FileStream("samplePath", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            // spostare un file
            File.Move(@"sourcePath\abc.txt", @"destinationPath\xyz.txt");

            // cancellazione di un file
            string path = @"c:\path\to\file.txt";
            File.Delete(path);

            // vedere tutti i file di una cartella
            var FileSearchRes = Directory.GetFiles(@"path", "*.*", SearchOption.AllDirectories);

            // vedere tutti i file di una cartella con estensione specificata
            var FileSearchResWithExtension = Directory.GetFiles(@"path", "*.pdf", SearchOption.AllDirectories);

        }
    }
}
