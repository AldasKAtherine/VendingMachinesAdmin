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
    public partial class Form_RepoMaquina : Form
    {
        int idU;
        public Form_RepoMaquina()
        {
            InitializeComponent();
            idU = 1;
        }

        private void Form_RepoMaquina_Load(object sender, EventArgs e)
        {

            this.reportViewer_maquinas.RefreshReport();
        }

        private void Button_ver_Click(object sender, EventArgs e)
        {
           
        }

        private void Form_RepoMaquina_Load_1(object sender, EventArgs e)
        {
            this.reportViewer_maquinas.RefreshReport();
        }

        private void Button_ver_Click_1(object sender, EventArgs e)
        {
            int estado = comboBox_Estado.SelectedIndex;
            DataTable dt = null;
            string ruta = "";
            string dataset = "";
            if (estado < 2)
            {
                dt = MetodosNegocio.maquinasPorEstado(estado, idU);
                ruta = @"E:\ProyectoDesarrollo\ProyectoDesarrollo\Reporte_venta1.rdlc";
                dataset = "DataSet_masVentasProduc";


            }
            else if(estado == 2)
            {
                dt = MetodosNegocio.maquinasTodas(idU);
                ruta = @"E:\ProyectoDesarrollo\ProyectoDesarrollo\Report_maquina.rdlc";
                dataset = "DataSet_maquina";
            }
            else
            {
                dt = MetodosNegocio.MaquinasProductos(idU);
                ruta = @"E:\ProyectoDesarrollo\ProyectoDesarrollo\Report_MaquinasCompart.rdlc";
                dataset = "DataSet_MaquinasComp";
                
            }
            ReportDataSource rds = new ReportDataSource(dataset, dt);
            reportViewer_maquinas.LocalReport.ReportPath = ruta;
            reportViewer_maquinas.LocalReport.DataSources.Clear();
            reportViewer_maquinas.LocalReport.DataSources.Add(rds);
            reportViewer_maquinas.RefreshReport();
        }
    }
}
