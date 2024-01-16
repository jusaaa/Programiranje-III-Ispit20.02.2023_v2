using DLWMS.Data;
using DLWMS.Data.IspitIB210156;
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
    public partial class frmPretragaIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPretragaIB210156()
        {
            InitializeComponent();
            PoveziDogadjaje();
            PostaviDefaultVrijednosti();
            dgvPretraga.AutoGenerateColumns = false;
        }
        private void PostaviDefaultVrijednosti()
        {
            cmbOcjenaOd.SelectedIndex = 0;
            cmbOcjenaDo.SelectedIndex = cmbOcjenaDo.Items.Count - 1;
        }
        private void PoveziDogadjaje()
        {
            cmbOcjenaOd.SelectedIndexChanged += PretraziStudente;
            cmbOcjenaDo.SelectedIndexChanged += PretraziStudente;
            dtpPolozenaOd.ValueChanged += PretraziStudente;
            dtpPolozenaDo.ValueChanged += PretraziStudente;
        }
        private void PretraziStudente(object sender, EventArgs e)
        {
            int ocjenaOd = Convert.ToInt32(cmbOcjenaOd.SelectedItem);
            int ocjenaDo = Convert.ToInt32(cmbOcjenaDo.SelectedItem);
            DateTime datumOd = dtpPolozenaOd.Value;
            DateTime datumDo = dtpPolozenaDo.Value;

            List<StudentiPredmetiIB210156> rezultati = PretragaStudenataUBazi(ocjenaOd, ocjenaDo, datumOd, datumDo);
            //if (rezultati.Count == 0)
            //{
            //    MessageBox.Show($"U periodu od {datumOd} do {datumDo}. godine ne postoje evidentirane ocjene u opsegu od {ocjenaOd} do {ocjenaDo} za" +
            //        $" bilo kojeg studenta.","Nema rezultata",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
            AzurirajRezultateUDgv(rezultati);
        }
        public List<StudentiPredmetiIB210156> PretragaStudenataUBazi(int ocjenaOd, int ocjenaDo, DateTime datumOd, DateTime datumDo)
        {
            var rezultati = db.StudentiPredmeti.Where(s => s.Ocjena >= ocjenaOd && s.Ocjena <= ocjenaDo && s.Datum >= datumOd && s.Datum <= datumDo)
                .Include(s => s.Student)
                .Include(s => s.Predmet)
                .ToList();

            return rezultati;
        }
        private void AzurirajRezultateUDgv(List<StudentiPredmetiIB210156> rezultati)
        {
            dgvPretraga.Rows.Clear();


            foreach (var rezultat in rezultati)
            {
                string brojIndeksa = rezultat.Student?.BrojIndeksa ?? "N/A";
                string studentImePrezime = rezultat.Student != null ? $"{rezultat.Student.Ime} {rezultat.Student.Prezime}" : "N/A";
                string predmetNaziv = rezultat.Predmet?.Naziv ?? "N/A";
                int studentId=rezultat.Student.Id;

                dgvPretraga.Rows.Add(
                 studentId,
                 brojIndeksa,
                 studentImePrezime,
                 predmetNaziv,
                 rezultat.Ocjena,
                 rezultat.Datum
                    );
            }
            dgvPretraga.Refresh();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvPretraga.Columns["Poruke"].Index)
            {
                int studentId = Convert.ToInt32(dgvPretraga.Rows[e.RowIndex].Cells["Id"].Value);
                var student=db.Studenti.Find(studentId);

                frmPorukeIB210156 formaPoruke = new frmPorukeIB210156(student);
                formaPoruke.ShowDialog();
            }
        }
    }
}
