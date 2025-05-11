using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VisitorManagement2025.Models;

namespace VisitorManagement2025.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VisitorManagement2025.Models.StaffNames> StaffNames { get; set; } = default!;
        public DbSet<VisitorManagement2025.Models.Visitors> Visitors { get; set; } = default!;
    }
}
