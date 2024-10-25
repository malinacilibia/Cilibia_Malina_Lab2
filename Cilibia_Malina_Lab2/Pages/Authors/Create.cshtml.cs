﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cilibia_Malina_Lab2.Data;
using Cilibia_Malina_Lab2.Models;

namespace Cilibia_Malina_Lab2.Pages.Author
{
    public class CreateModel : PageModel
    {
        private readonly Cilibia_Malina_Lab2.Data.Cilibia_Malina_Lab2Context _context;

        public CreateModel(Cilibia_Malina_Lab2.Data.Cilibia_Malina_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Author Authors { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Authors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
