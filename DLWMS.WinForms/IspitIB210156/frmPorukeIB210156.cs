using DLWMS.Data;
using DLWMS.Data.IspitIB210156;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB210156
{
    public partial class frmPorukeIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student student;

        public frmPorukeIB210156(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvPorukeStudenta.AutoGenerateColumns = false;
            DodajPredmeteUCmb();
        }

        private void DodajPredmeteUCmb()
        {
            var predmeti=db.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DataSource = predmeti;
        }

        private void frmPorukeIB210156_Load(object sender, EventArgs e)
        {
            PrikaziPorukeStudenta();
            lblPorukeStudenta.Text = $"Poruke studenta: {student.Ime} {student.Prezime}";
        }

        private void PrikaziPorukeStudenta()
        {
            var porukeStudenta = db.StudentiPorukeIB210156.Where(s => s.StudentId == student.Id && s.Validnost > DateTime.Now)
                .Include(s => s.Student)
                .Include(s => s.Predmet)
                .ToList();

            var brojac = porukeStudenta.Count();
            this.Text = $"Broj poruka: {brojac}";

            foreach (var poruka in porukeStudenta)
            {
                var slika = ImageHelper.FromByteToImage(poruka.Slika);

                dgvPorukeStudenta.Rows.Add(
                    poruka.Id,
                    poruka.Predmet.Naziv,
                    poruka.Sadrzaj,
                    slika,
                    poruka.Validnost
                    );
            }
        }
        private void ObrisiPoruku(int porukaId)
        {
            var poruka = db.StudentiPorukeIB210156.Find(porukaId);
            if (poruka != null)
            {
                db.StudentiPorukeIB210156.Remove(poruka);
                db.SaveChanges();
            }
        }
        private void dgvPorukeStudenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvPorukeStudenta.Columns["Brisi"].Index)
            {
                if (MessageBox.Show("Da li ste sigurni da želite obrisati poruku?", "Sigurnosna potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var porukaId = Convert.ToInt32(dgvPorukeStudenta.Rows[e.RowIndex].Cells["Id"].Value);
                    ObrisiPoruku(porukaId);

                    dgvPorukeStudenta.Rows.RemoveAt(e.RowIndex);

                    int brojac = dgvPorukeStudenta.Rows.Count;
                    this.Text = $"Broj poruka: {brojac.ToString()}";
                }
            }
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIB210156 novaPoruka = new frmNovaPorukaIB210156(this.student);
            DialogResult newDialog = novaPoruka.ShowDialog();

            if (newDialog == DialogResult.Cancel)
            {
                dgvPorukeStudenta.Rows.Clear();
                PrikaziPorukeStudenta();
                dgvPorukeStudenta.Refresh();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var dtoPoruke = new dtoPoruke
            {
                ImePrezime = this.student.ToString(),
                StudentiPoruke = db.StudentiPorukeIB210156.Where(st => st.StudentId == this.student.Id)
                .Include(st => st.Student)
                .Include(st => st.Predmet)
                .ToList()
            };
            var print = new frmIzvjestaji(dtoPoruke);
            print.ShowDialog();
        }
        private byte[] DohvatiPrvuSliku(int studentId)
        {
            var prvaSlika = db.StudentiPorukeIB210156.Where(s => s.StudentId == this.student.Id)
                .Select(s => s.Slika)
                .FirstOrDefault();

            return prvaSlika;
        }
        private string DohvatiNazivPredmeta(int predmetId)
        {
            var predmet=db.Predmeti.Find(predmetId);

            return $"{predmet.Naziv}";

        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            int brojPoruka=Convert.ToInt32(txtBrojPoruka.Text);
            int studentId=this.student.Id;
            int predmetId = Convert.ToInt32(cmbPredmeti.SelectedValue);

            await Task.Run(()=> DodajPoruke(studentId, predmetId,brojPoruka));

            PrikaziPorukeStudenta();
        }
        private void DodajPoruke(int studentId, int predmetId, int brojPoruka)
        {
            for (int i = 0; i < brojPoruka; i++)
            {
                StudentiPorukeIB210156 novaPoruka = new StudentiPorukeIB210156
                {
                    StudentId = studentId,
                    PredmetId = predmetId,
                    Sadrzaj = $"{i + 1}. GENERISANA PORUKA",
                    Validnost=dtpValidnost.Value,
                    Slika=DohvatiPrvuSliku(studentId)
                };
                db.StudentiPorukeIB210156.Add(novaPoruka);

               string infoPoruka= $"{novaPoruka.Validnost} -> generisana poruka za {this.student.ToString()} na predmetu {DohvatiNazivPredmeta(predmetId)}{Environment.NewLine}";

                Task.Delay(300).Wait();

                db.SaveChanges();

                Invoke(new Action(() =>
                {
                    txtInfo.AppendText(infoPoruka);
                    txtInfo.SelectionStart = txtInfo.TextLength;
                    txtInfo.ScrollToCaret();              
                }));
            }
            MessageBox.Show("Dodavanje poruka završeno!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class dtoPoruke
    {
        public string ImePrezime { get; set; }
        public List<StudentiPorukeIB210156> StudentiPoruke { get; set; }
    }
}

