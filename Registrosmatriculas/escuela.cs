using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMat2.Registrosmatriculas
{
    public class escuela
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }

        public List<seccion> seccions { get; set; }
    }
}
