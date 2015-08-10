using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7App.Models
{
    public class DadosContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Visual Studio 2015 | Use the LocalDb 12 instance created by Visual Studio
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=TesteEstudo;user id=usuario;password=123456;");

            // Visual Studio 2013 | Use the LocalDb 11 instance created by Visual Studio
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=EFGetStarted.ConsoleApp;Trusted_Connection=True;");

            // Visual Studio 2012 | Use the SQL Express instance created by Visual Studio
            // optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EFGetStarted.ConsoleApp;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .Property(b => b.nome)
                .Required();

        }
    }
}
