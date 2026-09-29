using System.Security.Cryptography.X509Certificates;

namespace EsercizioListBox
{
    public partial class Form1 : Form
    {
        List<string> origineDati = new List<string>();
        public Form1()
        {
            InitializeComponent();
            AggiornaFile("Animali.txt");
            AggiornoLista();
        }

        private void Rimuovi_Click(object sender, EventArgs e)
        {

        }
        private void AggiornoLista()
        {
            ListBoxAnimali.Items.Clear();
            foreach (string a in origineDati)
            {
                ListBoxAnimali.Items.Add(a);
            }
        }
        private bool ControllaSpazi(string parola)
        {
            if (parola == null)
            {
                return false;
            }  
            else if (parola == "")
            {
                return false;
            }
            for (int i = 0; i < origineDati.Count; i++)
            {
                if (parola[i] != ' ')
                {
                    return true;
                }
            }
            return false;
        }
        private void AggiornaFile(string fileName)
        {
            fileName = "Animali.txt";

            if (!File.Exists(fileName))
            {
                MessageBox.Show("il file non esiste");
            }
            else
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string riga = sr.ReadLine();
                        if(ControllaSpazi(riga) != false)
                        {
                            riga = riga.Trim();
                            riga = riga.ToLower();
                            origineDati.Add(riga);

                        }
                    }
                }
            }
            
        }
        private void Aggiungi_Click(object sender, EventArgs e)
        {
            if (ControllaSpazi(TxtAgg.Text) == false)
            {
                MessageBox.Show("Errore! Non hai scritto nulla");
            }
            else
            {
                string PAgg = TxtAgg.Text;
                PAgg = PAgg.Trim();
                PAgg = PAgg.ToLower();
                ListBoxAnimali.Items.Add(PAgg);
                origineDati.Add(PAgg);
                AggiornoLista();             

            }

        }
    }
}
