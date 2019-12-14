using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMat2.Registrosmatriculas
{
    public class registro
    {
        public int ID { get; set; }
        public DateTime fecharegistro { get; set; }
        public int estudianteID { get; set; }
        public int maestroID { get; set; }
    }
}
