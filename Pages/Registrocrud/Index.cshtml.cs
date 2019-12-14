﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly RegistroMat2.Data.RegistroMat2Context _context;

        public IndexModel(RegistroMat2.Data.RegistroMat2Context context)
        {
            _context = context;
        }

        public IList<registro> registro { get;set; }

        public async Task OnGetAsync()
        {
            registro = await _context.registro.ToListAsync();
        }
    }
}
