using DLWMS.Data;
using DLWMS.WinForms.IspitIB210156;
using Microsoft.Reporting.WinForms;
using System.Web;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private dtoPoruke dtoPoruke;

        public frmIzvjestaji(dtoPoruke dtoPoruke)
        {
            InitializeComponent();
            this.dtoPoruke = dtoPoruke;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {           
            var rpc=new ReportParameterCollection();
            rpc.Add(new ReportParameter("pImePrezime",dtoPoruke.ImePrezime));

            var poruke=new dsDLWMS.PorukeStudentaDataTable();
            for (int i = 0; i < dtoPoruke.StudentiPoruke.Count; i++)
            {
                var red = poruke.NewPorukeStudentaRow();
                red.Rb =(i+1).ToString();
                red.Predmet = dtoPoruke.StudentiPoruke[i].Predmet.Naziv;
                red.Poruka = dtoPoruke.StudentiPoruke[i].Sadrzaj;
                red.Validnost=dtoPoruke.StudentiPoruke[i].Validnost.ToString("dd.MM.yyyy");
                poruke.AddPorukeStudentaRow(red);
            }

            var rds=new ReportDataSource();
            rds.Value=poruke;
            rds.Name = "dsPoruke";
            
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
