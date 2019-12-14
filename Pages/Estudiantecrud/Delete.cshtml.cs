using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistroMat2.Data;
using RegistroMat2.Registrosmatriculas;

namespace RegistroMat2.Pages.Estudiantecrud
{
    public class DeleteModel : PageModel
    {
        private readonly RegistroMat2.Data.RegistroMat2Context _context;

        public DeleteModel(RegistroMat2.Data.RegistroMat2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public estudiante estudiante { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            estudiante = await _context.estudiante.FirstOrDefaultAsync(m => m.ID == id);

            if (estudiante == null)
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

            estudiante = await _context.estudiante.FindAsync(id);

            if (estudiante != null)
            {
                _context.estudiante.Remove(estudiante);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
