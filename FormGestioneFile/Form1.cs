using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormStrutture
{
    public partial class Form1 : Form
    {
        #region Dichiarazioni
        public float somma;
        public string path;
        #endregion
        #region Funzioni evento
        public Form1()
        {
            InitializeComponent();
            path = @"ListaProdotti.csv";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            Visualizza(path);
        }
        private void agg_Click(object sender, EventArgs e)
        {
            int pos = Ricerca(Nome.Text, path);
            if (pos == -1)
            {
                Aggiunta(Nome.Text, float.Parse(Prezzo.Text), path);
            }
            else
            {
                AumentaQuantità(pos, path);
            }
            Lista.Clear();
            Visualizza(path);
        }
        private void modif_Click(object sender, EventArgs e)
        {
            int pos = Ricerca(Nome.Text, path);
            if (pos == -1)
            {
                MessageBox.Show("Elemento non presente!");
            }
            else
            {
                Modifica(pos, NomeMod.Text, float.Parse(PrezzoMod.Text), path);
            }
            Lista.Clear();
            Visualizza(path);
        }
        private void delete_Click(object sender, EventArgs e)
        {
            int pos = Ricerca(Nome.Text, path);
            if (pos == -1)
            {
                MessageBox.Show("Elemento non presente!");
            }
            else
            {
                Elimina(pos, path);
            }
            Lista.Clear();
            Visualizza(path);
        }
        private void ext_Click(object sender, EventArgs e)
        {
            var rispExt = MessageBox.Show("È sicuro di voler terminare l'applicazione?", "Uscita programma", MessageBoxButtons.YesNo);
            if (rispExt == DialogResult.Yes)
            {
                var savefile = MessageBox.Show("Salvare modifiche alla lista?", "Salvataggio lista", MessageBoxButtons.YesNo);
                if (savefile == DialogResult.No)
                {
                    File.Delete(path);
                }
                Application.Exit();
            }
        }
        #endregion
        #region Funzioni servizio
        public int Ricerca(string nome, string filePath)
        {
            int posizione = -1;
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s;
                int riga = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    riga++;
                    string[] dati = s.Split(';');
                    if(dati[3] == "0")
                    {
                        if (dati[0] == nome)
                        {
                            posizione = riga;
                            break;
                        }
                    }
                }
            }
            return posizione;
        }
        public void Aggiunta(string nome, float prezzo, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, append: true))
            {
                sw.WriteLine($"{nome};{prezzo.ToString("0.00")};1;0");
            }
        }
        public void AumentaQuantità(int posizione, string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s;
                using (StreamWriter sw = new StreamWriter("ListaTemp.csv", append: true))
                {
                    int riga = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        riga++;
                        string[] dati = s.Split(';');
                        if (riga != posizione)
                        {
                            sw.WriteLine(s);
                        }
                        else
                        {
                            int numero = int.Parse(dati[2]);
                            numero++;
                            sw.WriteLine($"{dati[0]};{dati[1]};{numero};0");
                        }
                    }
                }
            }
            File.Delete(filePath);
            File.Move("ListaTemp.csv", filePath);
            File.Delete("ListaTemp.csv");
        }
        public void Modifica(int posizione, string nome, float prezzo, string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s;
                using (StreamWriter sw = new StreamWriter("ListaTemp.csv", append: true))
                {
                    int riga = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        riga++;
                        string[] dati = s.Split(';');
                        if (dati[3] == "0")
                        {
                            if (riga != posizione)
                            {
                                sw.WriteLine(s);
                            }
                            else
                            {
                                sw.WriteLine($"{nome};{prezzo.ToString("0.00")};{dati[2]}");
                            } 
                        }
                    }
                }
            }
            File.Delete(filePath);
            File.Move("ListaTemp.csv", filePath);
            File.Delete("ListaTemp.csv");
        }
        public void Elimina(int posizione, string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s;
                using (StreamWriter sw = new StreamWriter("ListaTemp.csv", append: true))
                {
                    int riga = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        riga++;
                        string[] dati = s.Split(';');
                        if (riga != posizione)
                        {
                            sw.WriteLine(s);
                        }
                        else
                        {
                            int numero = int.Parse(dati[2]);
                            numero++;
                            sw.WriteLine($"{dati[0]};{dati[1]};{dati[2]};1");
                        }
                    }
                }
            }
            File.Delete(filePath);
            File.Move("ListaTemp.csv", filePath);
            File.Delete("ListaTemp.csv");
        }
        public void Visualizza(string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] dati = s.Split(';');
                    if (dati[3] == "0")
                    {
                        Lista.Items.Add($"Nome: {dati[0]}; Prezzo: {dati[1]} €; Quantità: {dati[2]};");
                    }  
                }
            }
        }
        #endregion
    }
}