using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroMat2.Registrosmatriculas;

namespace RegistroMat2.Data
{
    public class RegistroMat2Context : DbContext
    {
        public RegistroMat2Context (DbContextOptions<RegistroMat2Context> options)
            : base(options)
        {
        }

        public DbSet<RegistroMat2.Registrosmatriculas.escuela> escuela { get; set; }

        public DbSet<RegistroMat2.Registrosmatriculas.estudiante> estudiante { get; set; }

        public DbSet<RegistroMat2.Registrosmatriculas.maestro> maestro { get; set; }

        public DbSet<RegistroMat2.Registrosmatriculas.registro> registro { get; set; }

        public DbSet<RegistroMat2.Registrosmatriculas.seccion> seccion { get; set; }
    }
}
