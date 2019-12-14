using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistroMat2.Data;
using RegistroMat2.Registrosmatriculas;

namespace RegistroMat2
{
    public class Start : PageModel
    {
        private readonly RegistroMat2.Data.RegistroMat2Context _context;

        public Start(RegistroMat2.Data.RegistroMat2Context context)
        {
            _context = context;
        }

        public IList<escuela> escuela { get;set; }

        public async Task OnGetAsync()
        {
            escuela = await _context.escuela.ToListAsync();
        }
    }
}
