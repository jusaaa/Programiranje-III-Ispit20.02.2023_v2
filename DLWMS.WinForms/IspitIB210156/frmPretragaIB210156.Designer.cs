namespace DLWMS.WinForms.IspitIB210156
{
    partial class frmPretragaIB210156
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
            label1 = new Label();
            cmbOcjenaOd = new ComboBox();
            label2 = new Label();
            cmbOcjenaDo = new ComboBox();
            label3 = new Label();
            dtpPolozenaOd = new DateTimePicker();
            dtpPolozenaDo = new DateTimePicker();
            label4 = new Label();
            dgvPretraga = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Ocjena od";
            // 
            // cmbOcjenaOd
            // 
            cmbOcjenaOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjenaOd.FormattingEnabled = true;
            cmbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjenaOd.Location = new Point(95, 6);
            cmbOcjenaOd.Name = "cmbOcjenaOd";
            cmbOcjenaOd.Size = new Size(68, 28);
            cmbOcjenaOd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 9);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 2;
            label2.Text = "do";
            // 
            // cmbOcjenaDo
            // 
            cmbOcjenaDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjenaDo.FormattingEnabled = true;
            cmbOcjenaDo.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjenaDo.Location = new Point(202, 6);
            cmbOcjenaDo.Name = "cmbOcjenaDo";
            cmbOcjenaDo.Size = new Size(68, 28);
            cmbOcjenaDo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 9);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 4;
            label3.Text = "položena u periodu od";
            // 
            // dtpPolozenaOd
            // 
            dtpPolozenaOd.Location = new Point(443, 4);
            dtpPolozenaOd.Name = "dtpPolozenaOd";
            dtpPolozenaOd.Size = new Size(250, 27);
            dtpPolozenaOd.TabIndex = 5;
            dtpPolozenaOd.Value = new DateTime(2004, 1, 14, 22, 28, 0, 0);
            // 
            // dtpPolozenaDo
            // 
            dtpPolozenaDo.Location = new Point(758, 4);
            dtpPolozenaDo.Name = "dtpPolozenaDo";
            dtpPolozenaDo.Size = new Size(250, 27);
            dtpPolozenaDo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(712, 6);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 7;
            label4.Text = "do";
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { Id, Indeks, ImePrezime, Predmet, Ocjena, DatumPolaganja, Poruke });
            dgvPretraga.Location = new Point(12, 59);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.RowTemplate.Height = 29;
            dgvPretraga.Size = new Size(996, 319);
            dgvPretraga.TabIndex = 8;
            dgvPretraga.CellContentClick += dgvPretraga_CellContentClick;
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
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
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
            // Ocjena
            // 
            Ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.MinimumWidth = 6;
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "Datum polaganja";
            DatumPolaganja.MinimumWidth = 6;
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // Poruke
            // 
            Poruke.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Poruke.DataPropertyName = "Poruke";
            Poruke.HeaderText = "";
            Poruke.MinimumWidth = 6;
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 413);
            Controls.Add(dgvPretraga);
            Controls.Add(label4);
            Controls.Add(dtpPolozenaDo);
            Controls.Add(dtpPolozenaOd);
            Controls.Add(label3);
            Controls.Add(cmbOcjenaDo);
            Controls.Add(label2);
            Controls.Add(cmbOcjenaOd);
            Controls.Add(label1);
            Name = "frmPretragaIB210156";
            Text = "Pretraga studenata";
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOcjenaOd;
        private Label label2;
        private ComboBox cmbOcjenaDo;
        private Label label3;
        private DateTimePicker dtpPolozenaOd;
        private DateTimePicker dtpPolozenaDo;
        private Label label4;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private DataGridViewButtonColumn Poruke;
    }
}