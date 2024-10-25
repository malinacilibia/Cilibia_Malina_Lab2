using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cilibia_Malina_Lab2.Models;

namespace Cilibia_Malina_Lab2.Data
{
    public class Cilibia_Malina_Lab2Context : DbContext
    {
        public Cilibia_Malina_Lab2Context (DbContextOptions<Cilibia_Malina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cilibia_Malina_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Cilibia_Malina_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Cilibia_Malina_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Cilibia_Malina_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
