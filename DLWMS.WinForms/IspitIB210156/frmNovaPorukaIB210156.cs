using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Helpers;
using DLWMS.Data.IspitIB210156;
using Validator = DLWMS.WinForms.Helpers.Validator;

namespace DLWMS.WinForms.IspitIB210156
{
    public partial class frmNovaPorukaIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student student;

        public frmNovaPorukaIB210156()
        {
            InitializeComponent();
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            var predmeti = db.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DataSource = predmeti;
        }

        public frmNovaPorukaIB210156(Student student) : this()
        {
            this.student = student;
        }
        private bool ValidirajFormu()
        {
            if (!Validator.ValidirajKontrolu(cmbPredmeti, errorProvider1, "Odaberite predmet!"))
            {
                return false;
            }
            if (!Validator.ValidirajKontrolu(txtSadrzajPoruke, errorProvider1, "Unesite sadržaj poruke!"))
            {
                return false;
            }
            if (!Validator.ValidirajKontrolu(pbSlika, errorProvider1, "Odaberite sliku!"))
            {
                return false;
            }
            return true;
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!ValidirajFormu())
            {
                MessageBox.Show("Molimo Vas da ispunite sva obavezna polja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StudentiPorukeIB210156 novaPoruka = new StudentiPorukeIB210156
            {
                StudentId = this.student.Id,
                PredmetId = Convert.ToInt32(cmbPredmeti.SelectedValue),
                Validnost = dtpValidnost.Value,
                Sadrzaj = txtSadrzajPoruke.Text,
                Slika = ImageHelper.FromImageToByte(pbSlika.Image)
            };
            db.StudentiPorukeIB210156.Add(novaPoruka);
            db.SaveChanges();

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
