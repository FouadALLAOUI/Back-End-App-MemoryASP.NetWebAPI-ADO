using back_end_app.Models;
using Microsoft.EntityFrameworkCore;

namespace back_end_app.Data
{
    public class ContactAPIDbContext : DbContext
    {
        public ContactAPIDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Contact> Contacts { get; set; } 

    }
}
