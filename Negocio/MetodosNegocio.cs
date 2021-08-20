using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class MetodosNegocio
    {
        public static bool IniciarSesion(string cedula, string contrasena)
        {
            Usuario usuario = MetodosDatos.ObtenerUsuarioPorCedula(cedula);

            if (usuario.Cedula.Length == 0) {

                return false;
            } else
            {
                return usuario.Contrasena.Equals(contrasena);
            }

        }

        public static List<Maquina> ListarMaquinas(int idUsuario)
        {
            return MetodosDatos.ListarMaquinas(idUsuario);
        }

        public static Usuario ObtenerUsuarioPorCedula(string cedula)
        {
            return MetodosDatos.ObtenerUsuarioPorCedula(cedula);
        }

        public static bool InsertarMaquina(Maquina maquina)
        {
            try
            {
                Maquina maquinaInsertada = MetodosDatos.InsertarMaquina(maquina);

                int compartimentos = maquinaInsertada.NumCompartimentos;
                for (int i = 0; i < compartimentos; i++)
                {
                    MetodosDatos.InsertarCompartimento(maquina, i + 1);
                }
                return true;
            }
            catch (Exception) {
                throw;
            }
        }

        public static bool ModificarMaquina(Maquina maquina)
        {
            return MetodosDatos.ModificarMaquina(maquina);
        }

        public static List<Compartimento> ListarCompoartimentoDeMauina(int id)
        {
            return MetodosDatos.ListarComapartimentosDeMaquina(id);
        }

        public static bool EliminarMaquina(Maquina maquina)
        {
            return MetodosDatos.EliminarMaquina(maquina);
        }
      
         public static bool GuardarProducto(Producto producto)
        {
            return MetodosDatos.GuardarProductoDatos(producto);
        }

        public static DataTable ReportesRecargas(int idU, string v)
        {
            return MetodosDatos.ReportesRecargas(idU,v);
        }

        public static List<string> CargarcomboMaquinas(int idU)
        {
            return MetodosDatos.cargarListaMaquinas(idU);
        }

        public static DataTable ReporteMasVendidos(int idU)
        {
            return MetodosDatos.ReportMasVendido(idU);
        }

        public static DataTable CargarReporteEstados(int estado, int idU)
        {
             return MetodosDatos.CargarReporteEstadosProductos(estado,idU);
        }

        public static DataTable VentasMaquinas(int idU)
        {
            return MetodosDatos.VentasMaquinas(idU);
        }

        public static DataTable maquinasPorEstado(int estado, int idU)
        {
            return MetodosDatos.maquinasEstado(estado,idU);
        }

        public static DataTable CargarReporteEstadosTodos(int idU)
        {
            return MetodosDatos.CargarReportesEstadosTodos(idU);
        }

        public static List<Producto> CargarProductos(int idUsu)
        {
            return MetodosDatos.CargarProductos(idUsu);
        }

        public static DataTable MaquinasProductos(int idU)
        {
            return MetodosDatos.MaquinasProductos(idU);
        }

        public static DataTable maquinasTodas(int idU)
        {
            return MetodosDatos.maquinasLista(idU);
        }

        public static bool ModificarProducto(Producto producto)
        {
            return MetodosDatos.ModificarProducto(producto);
        }

        public static bool EliminarProducto(Producto producto)
        {
            return MetodosDatos.EliminarProducto(producto);
        }

        public static DataTable reportePorMaquina(int idU, string idM)
        {
            return MetodosDatos.reportePorMaquina(idU,idM);
        }
      
      // Catuc
      public static List<Empleado> listaEmpleados(int idUsuario)
        {
            return MetodosDatos.ObternerEmpleados(idUsuario);
        }
        public static Empleado CrearEmpleado(Empleado empleado)
        {
            return MetodosDatos.CrearEmpleado(empleado);
        }
        public static Empleado BorrarEmpleado(Empleado empleado)
        {
            return MetodosDatos.BorrarEmpleado(empleado);
        }
        public static Empleado ActualizarEmpleado(Empleado empleado)
        {
            return MetodosDatos.ActualizarEmpleado(empleado);
        }
        public static List<Maquina> ListarMaquinas2(int idUsuario)
        {
            return MetodosDatos.ListarMaquinas2(idUsuario);
        }
        public static List<Compartimento> ListarCompartimiento2(int idMaquina)
        {
            return MetodosDatos.ListarCompartimientos2(idMaquina);
        }
        public static List<Producto> ListarProductos2(int idUsu)
        {
            return MetodosDatos.ListarProductos2(idUsu);
        }
        public static Recargas CrearRecargas(Recargas recarga)
        {
            return MetodosDatos.CrearRecarga(recarga);
        }
        public static List<Recargas> LeerRecargas(int idUsus)
        {
            return MetodosDatos.LeerRecargas(idUsus);
        }
    }
}
