using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistroMat2.Data;
using RegistroMat2.Registrosmatriculas;

namespace RegistroMat2.Pages.Estudiantecrud
{
    public class EditModel : PageModel
    {
        private readonly RegistroMat2.Data.RegistroMat2Context _context;

        public EditModel(RegistroMat2.Data.RegistroMat2Context context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(estudiante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!estudianteExists(estudiante.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool estudianteExists(int id)
        {
            return _context.estudiante.Any(e => e.ID == id);
        }
    }
}
