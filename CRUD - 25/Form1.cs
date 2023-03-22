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
        #endregion

        #region funzioni di servizio
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
    }
}
