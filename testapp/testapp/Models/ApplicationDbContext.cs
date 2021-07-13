using System;
using Microsoft.EntityFrameworkCore;

namespace testapp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Personne> Personne { get; set; }
    }
}
