namespace GestioneCavalli
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
            lblNome = new Label();
            lblRazza = new Label();
            lblAnno = new Label();
            lblSesso = new Label();
            txtNome = new TextBox();
            txtRazza = new TextBox();
            txtAnno = new TextBox();
            lstCavalli = new ListBox();
            btnAdd = new Button();
            btnModifica = new Button();
            btnRimuovi = new Button();
            btnCerca = new Button();
            btnSalva = new Button();
            rdbMaschio = new RadioButton();
            rdbFemmina = new RadioButton();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(49, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(85, 32);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblRazza
            // 
            lblRazza.AutoSize = true;
            lblRazza.Location = new Point(437, 60);
            lblRazza.Name = "lblRazza";
            lblRazza.Size = new Size(79, 32);
            lblRazza.TabIndex = 1;
            lblRazza.Text = "Razza:";
            // 
            // lblAnno
            // 
            lblAnno.AutoSize = true;
            lblAnno.Location = new Point(807, 60);
            lblAnno.Name = "lblAnno";
            lblAnno.Size = new Size(183, 32);
            lblAnno.TabIndex = 2;
            lblAnno.Text = "Anno di nascita:";
            // 
            // lblSesso
            // 
            lblSesso.AutoSize = true;
            lblSesso.Location = new Point(1273, 60);
            lblSesso.Name = "lblSesso";
            lblSesso.Size = new Size(79, 32);
            lblSesso.TabIndex = 3;
            lblSesso.Text = "Sesso:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(149, 53);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 39);
            txtNome.TabIndex = 4;
            // 
            // txtRazza
            // 
            txtRazza.Location = new Point(549, 53);
            txtRazza.Name = "txtRazza";
            txtRazza.Size = new Size(200, 39);
            txtRazza.TabIndex = 5;
            // 
            // txtAnno
            // 
            txtAnno.Location = new Point(1015, 53);
            txtAnno.Name = "txtAnno";
            txtAnno.Size = new Size(200, 39);
            txtAnno.TabIndex = 6;
            // 
            // lstCavalli
            // 
            lstCavalli.FormattingEnabled = true;
            lstCavalli.Location = new Point(49, 178);
            lstCavalli.Name = "lstCavalli";
            lstCavalli.Size = new Size(1086, 772);
            lstCavalli.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1357, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(216, 90);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Aggiungi";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(1357, 528);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(216, 86);
            btnModifica.TabIndex = 10;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnRimuovi
            // 
            btnRimuovi.Location = new Point(1357, 694);
            btnRimuovi.Name = "btnRimuovi";
            btnRimuovi.Size = new Size(216, 94);
            btnRimuovi.TabIndex = 11;
            btnRimuovi.Text = "Rimuovi";
            btnRimuovi.UseVisualStyleBackColor = true;
            btnRimuovi.Click += btnRimuovi_Click;
            // 
            // btnCerca
            // 
            btnCerca.Location = new Point(1357, 358);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(216, 94);
            btnCerca.TabIndex = 12;
            btnCerca.Text = "Cerca";
            btnCerca.UseVisualStyleBackColor = true;
            btnCerca.Click += btnCerca_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(1357, 856);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(216, 94);
            btnSalva.TabIndex = 13;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // rdbMaschio
            // 
            rdbMaschio.AutoSize = true;
            rdbMaschio.Location = new Point(1389, 30);
            rdbMaschio.Name = "rdbMaschio";
            rdbMaschio.Size = new Size(134, 36);
            rdbMaschio.TabIndex = 14;
            rdbMaschio.TabStop = true;
            rdbMaschio.Text = "Maschio";
            rdbMaschio.UseVisualStyleBackColor = true;
            // 
            // rdbFemmina
            // 
            rdbFemmina.AutoSize = true;
            rdbFemmina.Location = new Point(1389, 72);
            rdbFemmina.Name = "rdbFemmina";
            rdbFemmina.Size = new Size(144, 36);
            rdbFemmina.TabIndex = 15;
            rdbFemmina.TabStop = true;
            rdbFemmina.Text = "Femmina";
            rdbFemmina.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1694, 1000);
            Controls.Add(rdbFemmina);
            Controls.Add(rdbMaschio);
            Controls.Add(btnSalva);
            Controls.Add(btnCerca);
            Controls.Add(btnRimuovi);
            Controls.Add(btnModifica);
            Controls.Add(btnAdd);
            Controls.Add(lstCavalli);
            Controls.Add(txtAnno);
            Controls.Add(txtRazza);
            Controls.Add(txtNome);
            Controls.Add(lblSesso);
            Controls.Add(lblAnno);
            Controls.Add(lblRazza);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblRazza;
        private Label lblAnno;
        private Label lblSesso;
        private TextBox txtNome;
        private TextBox txtRazza;
        private TextBox txtAnno;
        private ListBox lstCavalli;
        private Button btnAdd;
        private Button btnModifica;
        private Button btnRimuovi;
        private Button btnCerca;
        private Button btnSalva;
        private RadioButton rdbMaschio;
        private RadioButton rdbFemmina;
    }
}
