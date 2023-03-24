namespace FormStrutture
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
            this.label1 = new System.Windows.Forms.Label();
            this.ext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.agg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Prezzo = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.ListView();
            this.modif = new System.Windows.Forms.Button();
            this.NomeMod = new System.Windows.Forms.TextBox();
            this.PrezzoMod = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.comp = new System.Windows.Forms.Button();
            this.racq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestione prodotti";
            // 
            // ext
            // 
            this.ext.Location = new System.Drawing.Point(12, 415);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(62, 23);
            this.ext.TabIndex = 9;
            this.ext.Text = "Uscita";
            this.ext.UseVisualStyleBackColor = true;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prodotto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezzo:";
            // 
            // agg
            // 
            this.agg.Location = new System.Drawing.Point(17, 134);
            this.agg.Name = "agg";
            this.agg.Size = new System.Drawing.Size(114, 23);
            this.agg.TabIndex = 6;
            this.agg.Text = "Aggiunta";
            this.agg.UseVisualStyleBackColor = true;
            this.agg.Click += new System.EventHandler(this.agg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modifica nome e prezzo del prodotto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prezzo:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(17, 82);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 15;
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(154, 82);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(100, 20);
            this.Prezzo.TabIndex = 16;
            // 
            // Lista
            // 
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(411, 27);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(377, 372);
            this.Lista.TabIndex = 17;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.List;
            // 
            // modif
            // 
            this.modif.Location = new System.Drawing.Point(17, 271);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(223, 23);
            this.modif.TabIndex = 18;
            this.modif.Text = "Modifica";
            this.modif.UseVisualStyleBackColor = true;
            this.modif.Click += new System.EventHandler(this.modif_Click);
            // 
            // NomeMod
            // 
            this.NomeMod.Location = new System.Drawing.Point(17, 245);
            this.NomeMod.Name = "NomeMod";
            this.NomeMod.Size = new System.Drawing.Size(100, 20);
            this.NomeMod.TabIndex = 19;
            // 
            // PrezzoMod
            // 
            this.PrezzoMod.Location = new System.Drawing.Point(140, 245);
            this.PrezzoMod.Name = "PrezzoMod";
            this.PrezzoMod.Size = new System.Drawing.Size(100, 20);
            this.PrezzoMod.TabIndex = 20;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(154, 133);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 23);
            this.delete.TabIndex = 21;
            this.delete.Text = "Cancella";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // comp
            // 
            this.comp.Location = new System.Drawing.Point(154, 339);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(100, 23);
            this.comp.TabIndex = 22;
            this.comp.Text = "Compatta";
            this.comp.UseVisualStyleBackColor = true;
            this.comp.Click += new System.EventHandler(this.comp_Click);
            // 
            // racq
            // 
            this.racq.Location = new System.Drawing.Point(17, 339);
            this.racq.Name = "racq";
            this.racq.Size = new System.Drawing.Size(114, 23);
            this.racq.TabIndex = 23;
            this.racq.Text = "Recupera";
            this.racq.UseVisualStyleBackColor = true;
            this.racq.Click += new System.EventHandler(this.racq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.racq);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.PrezzoMod);
            this.Controls.Add(this.NomeMod);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.agg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button agg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Prezzo;
        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.TextBox NomeMod;
        private System.Windows.Forms.TextBox PrezzoMod;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button comp;
        private System.Windows.Forms.Button racq;
    }
}

