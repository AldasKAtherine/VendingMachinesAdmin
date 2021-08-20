using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }

        public int NumCompartimentos { get; set; }

        public List<Compartimento> Compartimentos;
    }
}
