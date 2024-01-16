namespace DLWMS.WinForms.IspitIB210156
{
    partial class frmPorukeIB210156
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPorukeStudenta = new Label();
            btnNovaPoruka = new Button();
            btnPrintaj = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label3 = new Label();
            btnDodaj = new Button();
            dtpValidnost = new DateTimePicker();
            label2 = new Label();
            cmbPredmeti = new ComboBox();
            lblPredmeti = new Label();
            txtBrojPoruka = new TextBox();
            label1 = new Label();
            dgvPorukeStudenta = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPorukeStudenta).BeginInit();
            SuspendLayout();
            // 
            // lblPorukeStudenta
            // 
            lblPorukeStudenta.AutoSize = true;
            lblPorukeStudenta.Location = new Point(12, 22);
            lblPorukeStudenta.Name = "lblPorukeStudenta";
            lblPorukeStudenta.Size = new Size(117, 20);
            lblPorukeStudenta.TabIndex = 0;
            lblPorukeStudenta.Text = "Poruke studenta:";
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(881, 13);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(122, 29);
            btnNovaPoruka.TabIndex = 1;
            btnNovaPoruka.Text = "Nova poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(913, 367);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(90, 29);
            btnPrintaj.TabIndex = 3;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(dtpValidnost);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbPredmeti);
            groupBox1.Controls.Add(lblPredmeti);
            groupBox1.Controls.Add(txtBrojPoruka);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 412);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(991, 293);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(318, 58);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(656, 216);
            txtInfo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 35);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 6;
            label3.Text = "Info:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(9, 245);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(242, 29);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(9, 194);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(242, 27);
            dtpValidnost.TabIndex = 5;
            dtpValidnost.Value = new DateTime(2024, 3, 16, 19, 28, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 171);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 4;
            label2.Text = "Poruka je validna do:";
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(9, 125);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(242, 28);
            cmbPredmeti.TabIndex = 3;
            // 
            // lblPredmeti
            // 
            lblPredmeti.AutoSize = true;
            lblPredmeti.Location = new Point(6, 102);
            lblPredmeti.Name = "lblPredmeti";
            lblPredmeti.Size = new Size(72, 20);
            lblPredmeti.TabIndex = 2;
            lblPredmeti.Text = "Predmeti:";
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(9, 58);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(242, 27);
            txtBrojPoruka.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Broj poruka:";
            // 
            // dgvPorukeStudenta
            // 
            dgvPorukeStudenta.AllowUserToAddRows = false;
            dgvPorukeStudenta.AllowUserToDeleteRows = false;
            dgvPorukeStudenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPorukeStudenta.Columns.AddRange(new DataGridViewColumn[] { Id, Predmet, Sadrzaj, Slika, Validnost, Brisi });
            dgvPorukeStudenta.Location = new Point(12, 56);
            dgvPorukeStudenta.Name = "dgvPorukeStudenta";
            dgvPorukeStudenta.ReadOnly = true;
            dgvPorukeStudenta.RowHeadersWidth = 51;
            dgvPorukeStudenta.RowTemplate.Height = 29;
            dgvPorukeStudenta.Size = new Size(991, 295);
            dgvPorukeStudenta.TabIndex = 5;
            dgvPorukeStudenta.CellContentClick += dgvPorukeStudenta_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.MinimumWidth = 6;
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.MinimumWidth = 6;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.MinimumWidth = 6;
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.DataPropertyName = "Brisi";
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // frmPorukeIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 742);
            Controls.Add(dgvPorukeStudenta);
            Controls.Add(groupBox1);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaPoruka);
            Controls.Add(lblPorukeStudenta);
            Name = "frmPorukeIB210156";
            Text = "frmPorukeIB210156";
            Load += frmPorukeIB210156_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPorukeStudenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPorukeStudenta;
        private Button btnNovaPoruka;
        private Button btnPrintaj;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbPredmeti;
        private Label lblPredmeti;
        private TextBox txtBrojPoruka;
        private TextBox txtInfo;
        private Label label3;
        private Button btnDodaj;
        private DateTimePicker dtpValidnost;
        private Label label2;
        private DataGridView dgvPorukeStudenta;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
    }
}