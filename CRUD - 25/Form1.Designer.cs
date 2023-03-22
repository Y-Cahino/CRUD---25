namespace CRUD___25
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
            this.Name = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Prezzo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Stampa = new System.Windows.Forms.Button();
            this.cancella = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.newn = new System.Windows.Forms.TextBox();
            this.newp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(74, 79);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 0;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(74, 60);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(283, 78);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 2;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // Prezzo
            // 
            this.Prezzo.AutoSize = true;
            this.Prezzo.Location = new System.Drawing.Point(283, 59);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(39, 13);
            this.Prezzo.TabIndex = 3;
            this.Prezzo.Text = "Prezzo";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(535, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(253, 363);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Stampa
            // 
            this.Stampa.Location = new System.Drawing.Point(74, 160);
            this.Stampa.Name = "Stampa";
            this.Stampa.Size = new System.Drawing.Size(75, 23);
            this.Stampa.TabIndex = 5;
            this.Stampa.Text = "Stampa";
            this.Stampa.UseVisualStyleBackColor = true;
            this.Stampa.Click += new System.EventHandler(this.Stampa_Click);
            // 
            // cancella
            // 
            this.cancella.Location = new System.Drawing.Point(202, 159);
            this.cancella.Name = "cancella";
            this.cancella.Size = new System.Drawing.Size(75, 23);
            this.cancella.TabIndex = 6;
            this.cancella.Text = "Cancella";
            this.cancella.UseVisualStyleBackColor = true;
            this.cancella.Click += new System.EventHandler(this.cancella_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(77, 238);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(75, 23);
            this.modifica.TabIndex = 8;
            this.modifica.Text = "Modifica";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // newn
            // 
            this.newn.Location = new System.Drawing.Point(202, 240);
            this.newn.Name = "newn";
            this.newn.Size = new System.Drawing.Size(100, 20);
            this.newn.TabIndex = 9;
            this.newn.TextChanged += new System.EventHandler(this.newn_TextChanged);
            // 
            // newp
            // 
            this.newp.Location = new System.Drawing.Point(353, 240);
            this.newp.Name = "newp";
            this.newp.Size = new System.Drawing.Size(100, 20);
            this.newp.TabIndex = 10;
            this.newp.TextChanged += new System.EventHandler(this.newp_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newp);
            this.Controls.Add(this.newn);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cancella);
            this.Controls.Add(this.Stampa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label Prezzo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Stampa;
        private System.Windows.Forms.Button cancella;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.TextBox newn;
        private System.Windows.Forms.TextBox newp;
    }
}

