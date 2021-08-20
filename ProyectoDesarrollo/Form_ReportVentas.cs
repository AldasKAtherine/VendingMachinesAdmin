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
    public partial class Form_ReportVentas : Form
    {
        int idU;
        public Form_ReportVentas()
        {
            InitializeComponent();
            idU = 1;
            cargarcomboMaquinas();
 
        }

        private void cargarcomboMaquinas()
        {
            List<string> listaMaquinas = MetodosNegocio.CargarcomboMaquinas(idU);
            comboBox2.Items.Clear();
            foreach (var item in listaMaquinas)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            string ruta="";
            string dataset="";
            DataTable dt = null;
            if (op==0)
            {
                dt = MetodosNegocio.ReporteMasVendidos(idU);
                ruta = @"E:\ProyectoDesarrollo\ProyectoDesarrollo\Reporte_venta1.rdlc";
                dataset = "DataSet_masVentasProduc";
            }else if (op == 1)
            {
                dt = MetodosNegocio.VentasMaquinas(idU);
                ruta = @"E:\ProyectoDesarrollo\ProyectoDesarrollo\Reporte_Venta2.rdlc";
                dataset = "DataSet_VentasMaquina";
            }
            ReportDataSource rds = new ReportDataSource(dataset, dt);
            reportViewer_ventas.LocalReport.ReportPath = ruta;
            reportViewer_ventas.LocalReport.DataSources.Clear();
            reportViewer_ventas.LocalReport.DataSources.Add(rds);
            reportViewer_ventas.RefreshReport();
        }

        private void Form_ReportVentas_Load(object sender, EventArgs e)
        {

            this.reportViewer_ventas.RefreshReport();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string idM = comboBox2.SelectedItem.ToString().Split(' ')[0];
       
            DataTable dt = null;
            dt = MetodosNegocio.reportePorMaquina(idU,idM);
           
            ReportDataSource rds = new ReportDataSource("DataSet_IndividualM", dt);
            reportViewer_ventas.LocalReport.ReportPath = @"E:\ProyectoDesarrollo\ProyectoDesarrollo\Report_individual.rdlc";
            reportViewer_ventas.LocalReport.DataSources.Clear();
            reportViewer_ventas.LocalReport.DataSources.Add(rds);
            reportViewer_ventas.RefreshReport();

        }
    }
}
