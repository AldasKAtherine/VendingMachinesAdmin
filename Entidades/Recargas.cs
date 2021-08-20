using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recargas
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaHora { get; set; }
        public int id_compartimiento { get; set; }
        public int id_producto { get; set; }
        public int id_Empleado { get; set; }
        public int Id_Maquina { get; set; }
        public int Pos_Recarga { get; set; }
    }
}
