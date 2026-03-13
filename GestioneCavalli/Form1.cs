namespace GestioneCavalli
{
    public partial class Form1 : Form
    {
        string nome;
        int contatore = 0;
        struct Cavallo
        {
            public string Nome;
            public string Razza;
            public int AnnoNascita;
            public char Sesso;

            //costruttore
            public Cavallo(string nome, string razza, int annoNascita, char sesso)
            {
                Nome = nome;
                Razza = razza;
                AnnoNascita = annoNascita;
                Sesso = sesso;
            }
            public string Stampa()
            {
                return $"Nome: {Nome} | Razza: {Razza} | Anno di nascita: {AnnoNascita} | Sesso: {Sesso}";
            }
        }
        private List<Cavallo> cavalli = new List<Cavallo>();
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        //Carica i dati dal file all'avvio del programma
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("File Cavalli.txt"))
                return;

            using (StreamReader reader = new StreamReader("File Cavalli.txt"))
            {
                string linea;

                while ((linea = reader.ReadLine()) != null)
                {
                    string[] parti = linea.Split('|');

                    string nome = parti[0].Replace("Nome:", "").Trim();
                    string razza = parti[1].Replace("Razza:", "").Trim();
                    int anno = int.Parse(parti[2].Replace("Anno di nascita:", "").Trim());
                    char sesso = parti[3].Replace("Sesso:", "").Trim()[0];

                    Cavallo c = new Cavallo(nome, razza, anno, sesso);

                    cavalli.Add(c);
                    lstCavalli.Items.Add(c.Stampa());
                }
            }
            contatore = cavalli.Count;
        }

        //impedisce di inserire lettere nell'anno di nascita
        private void txtAnno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Aggiunge un cavallo alla lista
        private void btnAdd_Click(object sender, EventArgs e)
        {
            char genere;
            string nome = txtNome.Text;
            if (nome.Length == 0)
            {
                MessageBox.Show("Il nome non può essere vuoto.");
                return;
            }

            string razza = txtRazza.Text;
            if (razza.Length == 0)
            {
                MessageBox.Show("La razza non può essere vuota.");
                return;
            }

            bool x = int.TryParse(txtAnno.Text, out int annoNascita);

            if (annoNascita < DateTime.Now.Year - 35 || annoNascita > DateTime.Now.Year)
            {
                MessageBox.Show("Anno di nascita non valido!");
                return;
            }

            if (rdbMaschio.Checked)
            {
                genere = 'M';
            }
            else if (rdbFemmina.Checked)
            {
                genere = 'F';
            }
            else
            {
                MessageBox.Show("Seleziona il sesso del cavallo.");
                return;
            }

            contatore += 1;

            if (contatore > 10)
            {
                MessageBox.Show("Hai raggiunto il numero massimo di cavalli.");
                return;
            }

            Cavallo nuovoCavallo = new Cavallo(nome, razza, annoNascita, genere);
            cavalli.Add(nuovoCavallo);
            lstCavalli.Items.Add(nuovoCavallo.Stampa());
        }

        //cerca nella lista in base al nome 
        private void btnCerca_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;

            if (nome.Length == 0)
            {
                MessageBox.Show("Il nome non può essere vuoto.");
                return;
            }

            for (int i = 0; i < lstCavalli.Items.Count; i++)
            {
                if (lstCavalli.Items[i].ToString().Contains(nome))
                {
                    lstCavalli.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lstCavalli.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona prima un cavallo da modificare.");
                return;
            }

            string nome = txtNome.Text;
            if (nome.Length == 0)
            {
                MessageBox.Show("Il nome non può essere vuoto.");
                return;
            }

            string razza = txtRazza.Text;
            if (razza.Length == 0)
            {
                MessageBox.Show("La razza non può essere vuota.");
                return;
            }

            if (!int.TryParse(txtAnno.Text, out int annoNascita))
            {
                MessageBox.Show("Anno non valido.");
                return;
            }

            if (annoNascita < DateTime.Now.Year - 35 || annoNascita > DateTime.Now.Year)
            {
                MessageBox.Show("Anno di nascita non valido!");
                return;
            }

            char genere;

            if (rdbMaschio.Checked)
                genere = 'M';
            else if (rdbFemmina.Checked)
                genere = 'F';
            else
            {
                MessageBox.Show("Seleziona il sesso del cavallo.");
                return;
            }

            int index = lstCavalli.SelectedIndex;


            //modifica i valori del cavallo nella lista

            Cavallo cavalloModificato = new Cavallo(nome, razza, annoNascita, genere);

            //sostituisce il cavallo nella lista con quello modificato 
            cavalli[index] = cavalloModificato;

            lstCavalli.Items[index] = cavalloModificato.Stampa();

        }

        //Rimuove un cavallo
        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            if (lstCavalli.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona prima un cavallo da rimuovere.");
                return;
            }
            //elimina la riga selezionata
            int index = lstCavalli.SelectedIndex;

            cavalli.RemoveAt(index);

            lstCavalli.Items.RemoveAt(index);

        }

        //Salva i dati su file
        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (cavalli.Count == 0)
            {
                MessageBox.Show("Non ci sono persone");
                return;
            }

            using (StreamWriter writer = new StreamWriter("File Cavalli.txt", false))
            {
                foreach (var pers in cavalli)
                {
                    writer.WriteLine(pers.Stampa());
                }
            }
            MessageBox.Show ( "File salvato!");
        }
    }
}
