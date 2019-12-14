using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMat2.Registrosmatriculas
{
    public class escuelamaestro
    {
        public int escuelaID { get; set; }
        public int maestroID { get; set; }
        public escuela escuela { get; set; }
        public maestro maestro { get; set; }
    }
}
