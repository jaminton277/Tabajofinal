using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistroMat2.Data;
using RegistroMat2.Registrosmatriculas;

namespace RegistroMat2.Pages.Maestrocrud
{
    public class DetailsModel : PageModel
    {
        private readonly RegistroMat2.Data.RegistroMat2Context _context;

        public DetailsModel(RegistroMat2.Data.RegistroMat2Context context)
        {
            _context = context;
        }

        public maestro maestro { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            maestro = await _context.maestro.FirstOrDefaultAsync(m => m.ID == id);

            if (maestro == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
