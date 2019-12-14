using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMat2.Registrosmatriculas
{
    public class estudiante
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public double edad { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public string grado { get; set; }
        public List<registro> registros { get; set; }
    }
}
