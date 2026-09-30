namespace EsercizioListBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListBoxAnimali = new ListBox();
            Aggiungi = new Button();
            Rimuovi = new Button();
            Modifica = new Button();
            TxtAgg = new TextBox();
            LblAgg = new Label();
            label1 = new Label();
            label2 = new Label();
            TxtModifica = new TextBox();
            buttonSalva = new Button();
            SuspendLayout();
            // 
            // ListBoxAnimali
            // 
            ListBoxAnimali.FormattingEnabled = true;
            ListBoxAnimali.ItemHeight = 15;
            ListBoxAnimali.Location = new Point(98, 72);
            ListBoxAnimali.Name = "ListBoxAnimali";
            ListBoxAnimali.Size = new Size(193, 229);
            ListBoxAnimali.TabIndex = 0;
            // 
            // Aggiungi
            // 
            Aggiungi.Location = new Point(404, 143);
            Aggiungi.Name = "Aggiungi";
            Aggiungi.Size = new Size(75, 23);
            Aggiungi.TabIndex = 1;
            Aggiungi.Text = "Aggiungi";
            Aggiungi.UseVisualStyleBackColor = true;
            Aggiungi.Click += Aggiungi_Click;
            // 
            // Rimuovi
            // 
            Rimuovi.Location = new Point(98, 311);
            Rimuovi.Name = "Rimuovi";
            Rimuovi.Size = new Size(75, 23);
            Rimuovi.TabIndex = 2;
            Rimuovi.Text = "Rimuovi";
            Rimuovi.UseVisualStyleBackColor = true;
            Rimuovi.Click += Rimuovi_Click;
            // 
            // Modifica
            // 
            Modifica.Location = new Point(404, 243);
            Modifica.Name = "Modifica";
            Modifica.Size = new Size(75, 23);
            Modifica.TabIndex = 3;
            Modifica.Text = "Modifica";
            Modifica.UseVisualStyleBackColor = true;
            Modifica.Click += Modifica_Click;
            // 
            // TxtAgg
            // 
            TxtAgg.Location = new Point(404, 114);
            TxtAgg.Name = "TxtAgg";
            TxtAgg.Size = new Size(100, 23);
            TxtAgg.TabIndex = 4;
            TxtAgg.TextChanged += TxtAgg_TextChanged;
            // 
            // LblAgg
            // 
            LblAgg.AutoSize = true;
            LblAgg.Location = new Point(404, 87);
            LblAgg.Name = "LblAgg";
            LblAgg.Size = new Size(109, 15);
            LblAgg.TabIndex = 5;
            LblAgg.Text = "Aggiungi Elemento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 45);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 6;
            label1.Text = "Lista Elementi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 196);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 7;
            label2.Text = "Modifica Elemento";
            // 
            // TxtModifica
            // 
            TxtModifica.Location = new Point(404, 214);
            TxtModifica.Name = "TxtModifica";
            TxtModifica.Size = new Size(100, 23);
            TxtModifica.TabIndex = 9;
            TxtModifica.TextChanged += textBox1_TextChanged;
            // 
            // buttonSalva
            // 
            buttonSalva.Location = new Point(404, 311);
            buttonSalva.Name = "buttonSalva";
            buttonSalva.Size = new Size(75, 23);
            buttonSalva.TabIndex = 10;
            buttonSalva.Text = "Salva";
            buttonSalva.UseVisualStyleBackColor = true;
            buttonSalva.Click += buttonSalva_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalva);
            Controls.Add(TxtModifica);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblAgg);
            Controls.Add(TxtAgg);
            Controls.Add(Modifica);
            Controls.Add(Rimuovi);
            Controls.Add(Aggiungi);
            Controls.Add(ListBoxAnimali);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxAnimali;
        private Button Aggiungi;
        private Button Rimuovi;
        private Button Modifica;
        private TextBox TxtAgg;
        private Label LblAgg;
        private Label label1;
        private Label label2;
        private TextBox TxtModifica;
        private Button buttonSalva;
    }
}
