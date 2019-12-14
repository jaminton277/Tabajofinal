using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistroMat2.Data;
using RegistroMat2.Registrosmatriculas;

namespace RegistroMat2.Pages.Registrocrud
{
    public class DeleteModel : PageModel
    {
        private readonly RegistroMat2.Data.RegistroMat2Context _context;

        public DeleteModel(RegistroMat2.Data.RegistroMat2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public registro registro { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            registro = await _context.registro.FirstOrDefaultAsync(m => m.ID == id);

            if (registro == null)
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

            registro = await _context.registro.FindAsync(id);

            if (registro != null)
            {
                _context.registro.Remove(registro);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
