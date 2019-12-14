using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMat2.Registrosmatriculas
{
    public enum grado
    {
        A, B, C, D
    }
    public class seccion
    {
        public int ID { get; set; }
        public string ubicacion { get; set; }
        public int EscuelaID { get; set; }
    }
}
