using Entidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class MetodosDatos
    {
        public static Usuario ObtenerUsuarioPorCedula(string cedula)
        {
            Usuario usuario = new Usuario();
            try
            {
                
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT *
                              FROM [dbo].[Usuarios]
                                Where CEDULA = @cedula";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cedula", cedula);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        usuario.Id = Convert.ToInt32(dr["Id"].ToString());
                        usuario.Nombre = dr["Nombre"].ToString();
                        usuario.Apellido = dr["Apellido"].ToString();
                        usuario.Cedula = dr["Cedula"].ToString();
                        usuario.Contrasena = dr["Contrasena"].ToString();
                    }
                }

                conexion.Close();
                return usuario ;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        
        public static bool ModificarMaquina(Maquina maquina)
        {

            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                //Va a hacer las operaciones 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Maquinas]
                                   SET DESCRIPCION = @descripcion
                                   ,NOMBRE = @nombre
                                   ,UBICACION = @ubicacion
                                    WHERE ID = @id
                                    ";
                cmd.Parameters.AddWithValue("@descripcion", maquina.Descripcion);
                cmd.Parameters.AddWithValue("@nombre", maquina.Nombre);
                cmd.Parameters.AddWithValue("@ubicacion", maquina.Ubicacion);
                cmd.Parameters.AddWithValue("@id", maquina.Id);

                //
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteScalar();
                return true;

            }
            catch (Exception)
            {

                throw;

            }

        }

        public static List<Compartimento> ListarComapartimentosDeMaquina(int id)
        {
            try
            {
                List<Compartimento> compartimentos = new List<Compartimento>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT *
                              FROM [dbo].[Compartimentos] 
                                Where ID_MAQUINA = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Compartimento compartimento = new Compartimento();
                        compartimento.Id = Convert.ToInt32(dr["Id"].ToString());
                        compartimento.Capacidad = Convert.ToInt32(dr["Capacidad"].ToString());
                        compartimento.Cantidad = Convert.ToInt32(dr["Cantidad"].ToString());
                        compartimento.Posicion = Convert.ToInt32(dr["Posicion"].ToString());
                        if (dr["ID_PRODUCTO"].ToString().Length > 0 && dr["ID_PRODUCTO"].ToString() != "null")
                        {
                            compartimento.Producto = ObtenerProductoPorId(Convert.ToInt32(dr["ID_PRODUCTO"].ToString()));
                        }
                        else {
                            compartimento.Producto = new Producto();
                        }
                        
                        compartimentos.Add(compartimento);
                    }
                }

                conexion.Close();
                return compartimentos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Producto ObtenerProductoPorId(int idProducto) {

            try
            {
                Producto producto = new Producto();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT *
                              FROM [dbo].[Productos] 
                                Where ID = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", idProducto);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {

                        producto.Id = Convert.ToInt32(dr["Id"].ToString());
                        producto.Nombre = dr["NOMBRE"].ToString();

                    }
                }

                conexion.Close();
                return producto;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static bool EliminarMaquina(Maquina maquina)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                //Va a hacer las operaciones 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Maquinas]
                                   SET ACTIVO = 0
                                   
                                    WHERE ID = @id
                                    ";
                
                cmd.Parameters.AddWithValue("@id", maquina.Id);

                //
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteScalar();
                return true;

            }
            catch (Exception)
            {

                return false;

            }
        }

        public static void InsertarCompartimento(Maquina maquina, int posicion)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                //Va a hacer las operaciones 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [dbo].[Compartimentos]
                                           ([CANTIDAD]
                                           ,[ID_MAQUINA]
                                           ,[ID_PRODUCTO]
                                           ,[CAPACIDAD]
                                           ,[POSICION])
                                     VALUES
                                           (@cantidad
                                           ,@idMaquina
                                           ,@idProducto
                                           ,@capacidad
                                           ,@posicion) 
                                    ";
                cmd.Parameters.AddWithValue("@cantidad", 0);
                cmd.Parameters.AddWithValue("@idMaquina", maquina.Id);
                cmd.Parameters.AddWithValue("@idProducto", DBNull.Value);
                cmd.Parameters.AddWithValue("@capacidad", 5);
                cmd.Parameters.AddWithValue("@posicion", posicion);


                //
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteScalar();

            }
            catch (Exception)
            {

                throw;

            }
        }

        public static Maquina InsertarMaquina(Maquina maquina)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                //Va a hacer las operaciones 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [dbo].[Maquinas]
                                   ([DESCRIPCION]
                                   ,[ID_USUARIO]
                                   ,[NOMBRE]
                                   ,[UBICACION])
                             VALUES
                                   (@descripcion
                                   ,@idUsuarion
                                   ,@nombre
                                   ,@ubicacion)
                                        SELECT SCOPE_IDENTITY(); 
                                    ";
                cmd.Parameters.AddWithValue("@descripcion", maquina.Descripcion);
                cmd.Parameters.AddWithValue("@idUsuarion", maquina.IdUsuario);
                cmd.Parameters.AddWithValue("@nombre",  maquina.Nombre);
                cmd.Parameters.AddWithValue("@ubicacion", maquina.Ubicacion);

                //
                cmd.CommandType = CommandType.Text;

                var id = Convert.ToInt32(cmd.ExecuteScalar());
                maquina.Id = id;

                return maquina;

            }
            catch (Exception)
            {

                throw;

            }
        }

        public static List<Maquina> ListarMaquinas(int idUsuario) {
            try
            {
                List<Maquina> maquinas = new List<Maquina>();
            SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = @"SELECT M.*, ( 
                                            SELECT COUNT(ID_MAQUINA)
                                            FROM [dbo].[Compartimentos]
                                            WHERE ID_MAQUINA  = M.ID
                                            
                                ) AS Compartimentos
                              FROM [dbo].[Maquinas] AS M
                                Where ID_USUARIO = @id AND M.ACTIVO = 1";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", idUsuario);

            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                    {
                        Maquina maquina = new Maquina();
                    maquina.Id = Convert.ToInt32(dr["Id"].ToString());
                    maquina.Nombre = dr["Nombre"].ToString();
                    maquina.Descripcion = dr["Descripcion"].ToString();
                    maquina.Ubicacion = dr["Ubicacion"].ToString();
                    maquina.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"].ToString());
                        maquina.NumCompartimentos = Convert.ToInt32(dr["Compartimentos"].ToString());
                        maquinas.Add(maquina);
                    }
            }

            conexion.Close();
            return maquinas;
        }
            catch (Exception)
            {

                throw;
            }
       }
      
       public static DataTable ReportesRecargas(int idU, string v)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select * from vista_RepRec where idUsuario=@idUsu and ESTADO = @idMa";
                cmd.Parameters.AddWithValue("@idUsu", idU);
                cmd.Parameters.AddWithValue("@idMa", v);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<string> cargarListaMaquinas(int idU)
        {
            try
            {
                List<string> lista = new List<string>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select ID,NOMBRE from Maquinas where ID_USUARIO = @idUsu";
                cmd.Parameters.AddWithValue("@idUsu", idU);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(dr["ID"].ToString() + " " + dr["NOMBRE"].ToString());
                    }
                }

                conexion.Close();
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable reportePorMaquina(int idU, string idM)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select * from vista_VentasMaquina where ID_USUARIO=@idUsu and idMaquina = @idMa";
                cmd.Parameters.AddWithValue("@idUsu", idU);
                cmd.Parameters.AddWithValue("@idMa", idM);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable VentasMaquinas(int idU)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select * from vista_VentasMaquina where ID_USUARIO=@idUsu";
                cmd.Parameters.AddWithValue("@idUsu", idU);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable ReportMasVendido(int idU)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select * from vista_ventas where ID_USUARIO=@idUsu";
                cmd.Parameters.AddWithValue("@idUsu", idU);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable MaquinasProductos(int idU)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select * from View_MaquiCompar where ID_USUARIO=@idUsu";
                cmd.Parameters.AddWithValue("@idUsu", idU);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable maquinasLista(int idU)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select * from vista_maquinas where ID_USUARIO=@idUsu";
                cmd.Parameters.AddWithValue("@idUsu", idU);
    
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable maquinasEstado(int estado, int idU)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select * from vista_maquinas where ID_USUARIO=@idUsu and ACTIVO = @estado";
                cmd.Parameters.AddWithValue("@idUsu",idU);
                cmd.Parameters.AddWithValue("@estado", estado);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable CargarReportesEstadosTodos(int idU)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [ID]
                                      ,[NOMBRE]
                                      ,[DESCRIPCION]
                                      ,[PRECIO]
                                      ,[STOCK]
                                      ,[ID_USUARIO]
                                      ,[ACTIVO]
                                  FROM [dbo].[Productos] where ID_USUARIO=@idUsu;";
                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@idUsu", idU);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable CargarReporteEstadosProductos(int estado, int idU)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [ID]
                                      ,[NOMBRE]
                                      ,[DESCRIPCION]
                                      ,[PRECIO]
                                      ,[STOCK]
                                      ,[ID_USUARIO]
                                      ,[ACTIVO]
                                  FROM [dbo].[Productos] where ACTIVO = @estado and ID_USUARIO=@idUsu;";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@idUsu", idU);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();

                return dt;
            }
            catch (Exception )
            {
                throw;
            }

        }

        public static bool EliminarProducto(Producto producto)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                //Va a hacer las operaciones 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Productos]
                                   SET [NOMBRE] =@nombre
                                      ,[DESCRIPCION] = @descripcion
                                      ,[PRECIO] = @precio
                                      ,[STOCK] = @stock
                                      ,ESTADO=0
                                 WHERE ID= @id ";
                cmd.Parameters.AddWithValue("@id", producto.Id);
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);

                //
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexion.Close();
                return true;

            }
            catch (Exception)
            {
                throw;

            }

        }

        public static bool ModificarProducto(Producto producto)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                //Va a hacer las operaciones 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Productos]
                                   SET [NOMBRE] =@nombre
                                      ,[DESCRIPCION] = @descripcion
                                      ,[PRECIO] = @precio
                                      ,[STOCK] = @stock
                                 WHERE ID = @id;";
                cmd.Parameters.AddWithValue("@id", producto.Id);
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
              

                //
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();


                conexion.Close();
                return true;


            }
            catch (Exception)
            {
                return false;

            }

        }

        public static List<Producto> CargarProductos(int idUsu)
        {
            List<Producto> listaPro = new List<Producto>();
            try
            {

                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [ID]
                                  ,[NOMBRE]
                                  ,[DESCRIPCION]
                                  ,[PRECIO]
                                  ,[STOCK]
                                  ,[ID_USUARIO]
                                   ,ESTADO
                              FROM [dbo].[Productos] where ID_USUARIO=@idUsuario AND ESTADO=1";
                cmd.Parameters.AddWithValue("@idUsuario", idUsu);
                cmd.CommandType = CommandType.Text;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Producto produc = new Producto();
                        produc.Id = Convert.ToInt32(dr["ID"]);
                        produc.Nombre = dr["NOMBRE"].ToString();
                        produc.Descripcion = dr["DESCRIPCION"].ToString();

                        produc.Precio =Convert.ToDouble(dr["PRECIO"].ToString()) ;


                        produc.Stock =Convert.ToInt32(dr["STOCK"]);
                        produc.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                        produc.Estado = Convert.ToInt32(dr["ESTADO"]);
                        listaPro.Add(produc);
                    }
                }

                
                conexion.Close();
                return listaPro;

            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public static bool GuardarProductoDatos(Producto producto)
        {
            try
            {
                SqlConnection coneccion = new SqlConnection(Configuracion.Default.CadenaConexion);
                coneccion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = coneccion;
                cmd.CommandText = @"INSERT INTO [dbo].[Productos]
                                       ([NOMBRE]
                                       ,[DESCRIPCION]
                                       ,[PRECIO]
                                       ,[STOCK]
                                       ,[ID_USUARIO])
                                    VALUES(@nombre,@descripcion, @precio,@stock,@idUsuario)";

                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@idUsuario", producto.IdUsuario);
               
                cmd.CommandType = CommandType.Text;
               
                cmd.ExecuteScalar();
                coneccion.Close();
                return true;
                

            }
            catch (Exception)
            {
                return false;

            }
           
        }
      
        // Catuc
      
        public static List<Empleado> ObternerEmpleados(int id_Usuario)
        {
            try
            {
                List<Empleado> listaEmpeleados = new List<Empleado>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [ID]
                                ,[NOMBRE]
                                ,[APELLIDO]
                                ,[CEDULA]
                                ,[CONTRASENA]
                                ,[ID_USUARIO]
                                FROM [dbo].[Enpleados] WHERE [ID_USUARIO]=@idUsu AND ACTIVO=1";
                cmd.Parameters.AddWithValue("@idUsu", id_Usuario);

                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Empleado _empleado = new Empleado();
                        _empleado.Id = Convert.ToInt32(dr["id"].ToString());
                        _empleado.Nombre = dr["nombre"].ToString();
                        _empleado.Apellido = dr["apellido"].ToString();
                        _empleado.Cedula = dr["cedula"].ToString();
                        _empleado.Contrasena = Desencriptar(dr["contrasena"].ToString());
                        _empleado.Id_usuario = Convert.ToInt32(dr["id_usuario"].ToString());
                        listaEmpeleados.Add(_empleado);
                    }
                }

                return listaEmpeleados;
            }
            catch (Exception)
            {

                throw;
            }

        }
       
        public static string Desencriptar(string cadena)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadena);
            Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = Encoding.Unicode.GetString(decryted);
            return result;
        }
        public static Empleado ActualizarEmpleado(Empleado empleado)
        {

            try
            {

                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Enpleados]
                                    SET [NOMBRE] = @nombre,
                                    [APELLIDO] = @apellido,
                                    [CEDULA] = @cedula,
                                    [CONTRASENA] = @contrasena
                                    WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id", empleado.Id);
                cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("@contrasena", empleado.Contrasena);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexion.Close();

                return empleado;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static Empleado BorrarEmpleado(Empleado empleado)
        {

            try
            {

                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [dbo].[Enpleados]
                                    SET [ACTIVO] = 0
                                    WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id", empleado.Id);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexion.Close();

                return empleado;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static Empleado CrearEmpleado(Empleado empleado)
        {

            try
            {

                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [dbo].[Enpleados]
                                     ([NOMBRE]
                                     ,[APELLIDO]
                                     ,[CEDULA]
                                    ,[CONTRASENA]
                                    ,[ID_USUARIO]
                                    ,[ACTIVO])
                                    VALUES
                                     (@nombre,@apellido,@cedula,@contrasena,@id_usu,1);";
                cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("@contrasena", empleado.Contrasena);
                cmd.Parameters.AddWithValue("@id_usu", empleado.Id_usuario);



                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexion.Close();

                return empleado;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static List<Maquina> ListarMaquinas2(int id_Usuario)
        {
            try
            {
                List<Maquina> listaMaquinas = new List<Maquina>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [ID]
                                    ,[DESCRIPCION]
                                    ,[ID_USUARIO]
                                    ,[NOMBRE]
                                    ,[UBICACION]
                                    FROM [dbo].[Maquinas]
                                    WHERE[ID_USUARIO]=@idUsu AND ACTIVO=1";
                cmd.Parameters.AddWithValue("@idUsu", id_Usuario);

                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Maquina _maquina = new Maquina();
                        _maquina.Id = Convert.ToInt32(dr["ID"].ToString());
                        _maquina.Descripcion = dr["DESCRIPCION"].ToString();
                        _maquina.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"].ToString());
                        _maquina.Nombre = dr["NOMBRE"].ToString();
                        _maquina.Ubicacion = dr["UBICACION"].ToString();

                        listaMaquinas.Add(_maquina);
                    }
                }

                return listaMaquinas;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<Compartimento> ListarCompartimientos2(int id_maquina)
        {
            try
            {
                List<Compartimento> listacompartimentos = new List<Compartimento>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [ID]
                                 ,[CANTIDAD]
                                 ,[CAPACIDAD]
                                 ,[POSICION]
                                 FROM [dbo].[Compartimentos]
                                 WHERE CANTIDAD<CAPACIDAD AND ID_MAQUINA=@id_maquina";
                cmd.Parameters.AddWithValue("@id_maquina", id_maquina);

                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Compartimento _comprtamiento = new Compartimento();
                        _comprtamiento.Id = Convert.ToInt32(dr["ID"].ToString());
                        _comprtamiento.Cantidad = Convert.ToInt32(dr["CANTIDAD"].ToString());
                        _comprtamiento.Capacidad = Convert.ToInt32(dr["CAPACIDAD"].ToString());
                        _comprtamiento.Posicion = Convert.ToInt32(dr["POSICION"].ToString());
                       

                        listacompartimentos.Add(_comprtamiento);
                    }
                }

                return listacompartimentos;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<Producto> ListarProductos2(int id_Usuario)
        {
            try
            {
                List<Producto> listaproductos = new List<Producto>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [ID]
                                    ,[NOMBRE]
                                    ,[DESCRIPCION]
                                    ,[PRECIO]
                                    ,[STOCK]
                                    FROM [Expendedoras].[dbo].[Productos]
                                    WHERE [ACTIVO]=1 AND STOCK>0 AND 
                                     [ID_USUARIO]=@id_usuario";
                cmd.Parameters.AddWithValue("@id_usuario", id_Usuario);

                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Producto _producto = new Producto();
                        _producto.Id = Convert.ToInt32(dr["ID"].ToString());
                        _producto.Nombre = dr["NOMBRE"].ToString();
                        _producto.Descripcion = dr["DESCRIPCION"].ToString();
                        _producto.Precio = Convert.ToDouble(dr["PRECIO"].ToString());
                        _producto.Stock = Convert.ToInt32(dr["STOCK"].ToString());


                        listaproductos.Add(_producto);
                    }
                }

                return listaproductos;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Recargas CrearRecarga(Recargas recarga)
        {
            try
            {

                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [dbo].[Recargas]
                                    ([CANTIDAD]
                                    ,[FECHA_HORA]
                                    ,[ID_COMPARTIMENTO]
                                    ,[ID_PRODUCTO]
                                    ,[ID_EMPLEADO]
                                    ,[ESTADO])
                                    VALUES
                                    (@cantidad,@fecha_hora,@id_compartimiento,@id_producto,
                                    @id_empleado,'PENDIENTE');";
                cmd.Parameters.AddWithValue("@cantidad", recarga.Cantidad);
                cmd.Parameters.AddWithValue("@fecha_hora", recarga.FechaHora);
                cmd.Parameters.AddWithValue("@id_compartimiento", recarga.id_compartimiento);
                cmd.Parameters.AddWithValue("@id_producto", recarga.id_producto);
                cmd.Parameters.AddWithValue("@id_empleado", recarga.id_Empleado);



                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexion.Close();

                return recarga;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<Recargas> LeerRecargas(int idUsu)
        {
            try
            {
                List<Recargas> listaRecargas = new List<Recargas>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT M.ID AS MAQUINA, 
                                    C.POSICION AS POSICION, R.ID AS ID_RECARGA, 
                                    R.CANTIDAD AS CANTIDAD, R.FECHA_HORA AS FECHA,
                                    R.ID_PRODUCTO AS ID_PRODUCTO,R.ID_EMPLEADO AS ID_EMPLEADO 
                                    FROM Maquinas M 
                                    INNER JOIN Compartimentos C ON M.ID=C.ID_MAQUINA
                                    INNER JOIN Recargas R ON C.ID=R.ID_COMPARTIMENTO 
                                    WHERE M.ID_USUARIO=@idUsu AND R.ESTADO='PENDIENTE';";
                cmd.Parameters.AddWithValue("@idUsu", idUsu);

                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Recargas _recargas = new Recargas();
                        _recargas.Id_Maquina = Convert.ToInt32(dr["MAQUINA"].ToString());
                        _recargas.Pos_Recarga = Convert.ToInt32(dr["POSICION"].ToString());
                        _recargas.Id = Convert.ToInt32(dr["ID_RECARGA"].ToString());
                        _recargas.Cantidad = Convert.ToInt32(dr["CANTIDAD"].ToString());
                        _recargas.FechaHora = Convert.ToDateTime(dr["FECHA"].ToString());
                        _recargas.id_producto = Convert.ToInt32(dr["ID_PRODUCTO"].ToString());
                        _recargas.id_Empleado = Convert.ToInt32(dr["ID_EMPLEADO"].ToString());
                        listaRecargas.Add(_recargas);
                    }
                }

                return listaRecargas;
            }
            catch (Exception)
            {

                throw;
            }

        }
      
    }
}
