using Microsoft.EntityFrameworkCore;

namespace EmployeeListApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
