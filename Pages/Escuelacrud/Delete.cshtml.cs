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
    public class DeleteModel : PageModel
    {
        private readonly RegistroMat2.Data.RegistroMat2Context _context;

        public DeleteModel(RegistroMat2.Data.RegistroMat2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public escuela escuela { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            escuela = await _context.escuela.FirstOrDefaultAsync(m => m.ID == id);

            if (escuela == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            escuela = await _context.escuela.FindAsync(id);

            if (escuela != null)
            {
                _context.escuela.Remove(escuela);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Start");
        }
    }
}
