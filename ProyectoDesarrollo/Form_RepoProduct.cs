using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using Microsoft.Reporting.WinForms;

namespace ProyectoDesarrollo
{
    public partial class Form_RepoProduct : Form
    {
        int idU;
        public Form_RepoProduct()
        {
            
            InitializeComponent();
            //idU = usuario.Id;
            idU = 1;
        }

        private void Button_estados_Click(object sender, EventArgs e)
        {
            int estado = comboBox_estado.SelectedIndex;
            DataTable dt = null;
            if (estado<2)
            {
                dt = MetodosNegocio.CargarReporteEstados(estado, idU);
            }
            else
            {
               dt = MetodosNegocio.CargarReporteEstadosTodos(idU);
            }
            
            
           
            ReportDataSource rds = new ReportDataSource("DataSet_productos", dt);
            reportViewer1.LocalReport.ReportPath = @"E:\ProyectoDesarrollo\ProyectoDesarrollo\Reporte_productos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void RepoProduct_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
