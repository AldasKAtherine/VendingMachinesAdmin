using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Microsoft.Reporting.WinForms;
using Negocio;

namespace ProyectoDesarrollo
{
    public partial class Form_ReportRecargas : Form
    {
        int idU;
        public Form_ReportRecargas()
        {
            InitializeComponent();
            idU = 1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CargarReporteRecargas();
        }

        private void CargarReporteRecargas()
        {
            DataTable dt = MetodosNegocio.ReportesRecargas(idU,comboBoxEstdo.SelectedItem.ToString());
           string ruta = @"E:\ProyectoDesarrollo\ProyectoDesarrollo\Reporte_Recargas.rdlc";
            string dataset = "DataSet_Recargas";
            ReportDataSource rds = new ReportDataSource(dataset, dt);
            reportViewer1.LocalReport.ReportPath = ruta;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void Form_ReportRecargas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
