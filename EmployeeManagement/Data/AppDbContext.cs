using Microsoft.EntityFrameworkCore;
namespace EmployeeManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<EmployeeManagement.Models.Employee> Employees { get; set; }
    }
}
