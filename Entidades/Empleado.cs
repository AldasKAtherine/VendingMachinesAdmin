﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }
        public string Cedula { get; set; }
        public string Contrasena { get; set; }
        public int Id_usuario { get; set; }
    }
}