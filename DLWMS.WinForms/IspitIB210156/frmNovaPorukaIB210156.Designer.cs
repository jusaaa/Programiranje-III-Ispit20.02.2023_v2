namespace DLWMS.WinForms.IspitIB210156
{
    partial class frmNovaPorukaIB210156
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cmbPredmeti = new ComboBox();
            label2 = new Label();
            dtpValidnost = new DateTimePicker();
            label3 = new Label();
            txtSadrzajPoruke = new TextBox();
            pbSlika = new PictureBox();
            label4 = new Label();
            btnSpasi = new Button();
            btnOdustani = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet:";
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(12, 32);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(279, 28);
            cmbPredmeti.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 2;
            label2.Text = "Poruka je validna do:";
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(12, 101);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(279, 27);
            dtpValidnost.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 4;
            label3.Text = "Sadržaj poruke:";
            // 
            // txtSadrzajPoruke
            // 
            txtSadrzajPoruke.Location = new Point(12, 189);
            txtSadrzajPoruke.Multiline = true;
            txtSadrzajPoruke.Name = "txtSadrzajPoruke";
            txtSadrzajPoruke.Size = new Size(279, 199);
            txtSadrzajPoruke.TabIndex = 5;
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(368, 32);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(403, 356);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 6;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 9);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 7;
            label4.Text = "Slika:";
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(654, 394);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(117, 29);
            btnSpasi.TabIndex = 8;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(531, 394);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(117, 29);
            btnOdustani.TabIndex = 9;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaPorukaIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOdustani);
            Controls.Add(btnSpasi);
            Controls.Add(label4);
            Controls.Add(pbSlika);
            Controls.Add(txtSadrzajPoruke);
            Controls.Add(label3);
            Controls.Add(dtpValidnost);
            Controls.Add(label2);
            Controls.Add(cmbPredmeti);
            Controls.Add(label1);
            Name = "frmNovaPorukaIB210156";
            Text = "Poruka";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPredmeti;
        private Label label2;
        private DateTimePicker dtpValidnost;
        private Label label3;
        private TextBox txtSadrzajPoruke;
        private PictureBox pbSlika;
        private Label label4;
        private Button btnSpasi;
        private Button btnOdustani;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}