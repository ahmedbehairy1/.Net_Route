using EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    public class BookStoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BookStoreDB;Trusted_Connection=True;TrustServerCertificate = true");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author>Authors { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
