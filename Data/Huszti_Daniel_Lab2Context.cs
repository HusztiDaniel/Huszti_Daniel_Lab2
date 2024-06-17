using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Huszti_Daniel_Lab2.Models;

namespace Huszti_Daniel_Lab2.Data
{
    public class Huszti_Daniel_Lab2Context : DbContext
    {
        public Huszti_Daniel_Lab2Context (DbContextOptions<Huszti_Daniel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Huszti_Daniel_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
