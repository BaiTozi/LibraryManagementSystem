using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace LibraryManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryManagementSystem.Models.Book> Books { get; set; }

    }
}
