using employeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace employeeAPI.Data
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options): base(options) 
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
