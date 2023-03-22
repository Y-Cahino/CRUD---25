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

namespace CRUD___25
{
    public partial class Form1 : Form
    {
        #region declare
        string file;
        public Form1()
        {
            InitializeComponent();
            file = @"carrello.csv";
        }
        #endregion

        
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region pulsanti
        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void modifica_Click(object sender, EventArgs e)
        {

        }

        private void newn_TextChanged(object sender, EventArgs e)
        {

        }

        private void newp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stampa_Click(object sender, EventArgs e)
        {

        }

        private void cancella_Click(object sender, EventArgs e)
        {

        }
        private void Ricerca_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region funzioni di servizio
        //funzione di aggiornamento del file
        void upd(string n, string p)
        {
            if(!File.Exists(file))
            {
                using (StreamWriter sw = new StreamWriter(file, append: false))
                {
                    sw.WriteLine(n + " €" + p);
                }
                
            }
            else
            {
                using (StreamWriter sr = new StreamWriter(file))
                {
                    sr.WriteLine(n + " €" + p);
                }
            }
        }
        //funzione di stampa
        void vis()
        {
            listView1.Items.Clear();
            if(!File.Exists(file))
            {
                MessageBox.Show("Il file non è presente");
            }
            else
            {
                using (StreamReader st = File.OpenText(file))
                {
                    string s;
                    while((s=st.ReadLine())!=null)
                    {
                        listView1.Items.Add(s);
                    }
                }
            }
        }
        //funzione di ricerca
        void research()
        {

        }
        //funzione cancella
        void delete()
        {

        }
        //funzione modifica
        void mod()
        {

        }
        #endregion

        
    }
}
