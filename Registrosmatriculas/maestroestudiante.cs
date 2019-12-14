using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMat2.Registrosmatriculas
{
    public class maestroestudiante
    {
        public int maestroID { get; set; }
        public int estudianteID { get; set; }
        public maestro maestro { get; set; }
        public estudiante estudiante { get; set; }
    }
}
