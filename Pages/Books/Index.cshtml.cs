﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Huszti_Daniel_Lab2.Data;
using Huszti_Daniel_Lab2.Models;

namespace Huszti_Daniel_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Huszti_Daniel_Lab2.Data.Huszti_Daniel_Lab2Context _context;

        public IndexModel(Huszti_Daniel_Lab2.Data.Huszti_Daniel_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
            .Include(b => b.Publisher)
            .ToListAsync();
        }
    }
}
