using Microsoft.EntityFrameworkCore;
using WrapFusionContact.Models;

namespace WrapFusionContact.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}