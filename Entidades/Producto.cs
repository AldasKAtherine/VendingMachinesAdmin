using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        public int Estado { get; set; }

        public Producto(int id, string nombre, string descripcion, double precio, int stock, int idUsuario)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            IdUsuario = idUsuario;
        }

        public Producto()
        {
        }
    }

}

