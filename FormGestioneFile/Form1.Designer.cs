﻿namespace FormStrutture
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prodinpt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prezinpt = new System.Windows.Forms.TextBox();
            this.agg = new System.Windows.Forms.Button();
            this.ext = new System.Windows.Forms.Button();
            this.modprin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modprezzin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(472, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(316, 396);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prodotto:";
            // 
            // prodinpt
            // 
            this.prodinpt.Location = new System.Drawing.Point(17, 81);
            this.prodinpt.Name = "prodinpt";
            this.prodinpt.Size = new System.Drawing.Size(100, 20);
            this.prodinpt.TabIndex = 18;
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
            // prezinpt
            // 
            this.prezinpt.Location = new System.Drawing.Point(154, 81);
            this.prezinpt.Name = "prezinpt";
            this.prezinpt.Size = new System.Drawing.Size(100, 20);
            this.prezinpt.TabIndex = 5;
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
            // modprin
            // 
            this.modprin.Location = new System.Drawing.Point(17, 242);
            this.modprin.Name = "modprin";
            this.modprin.Size = new System.Drawing.Size(114, 20);
            this.modprin.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modifica nome e prezzo del prodotto:";
            // 
            // modprezzin
            // 
            this.modprezzin.Location = new System.Drawing.Point(140, 242);
            this.modprezzin.Name = "modprezzin";
            this.modprezzin.Size = new System.Drawing.Size(114, 20);
            this.modprezzin.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prezzo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modprezzin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modprin);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.agg);
            this.Controls.Add(this.prezinpt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodinpt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prodinpt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prezinpt;
        private System.Windows.Forms.Button agg;
        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.TextBox modprin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modprezzin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
