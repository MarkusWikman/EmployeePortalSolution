using EmployeePortal.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace EmployeePortal.Web.Data
{
    public class EmployeePortalDbContext : DbContext
    {
        public EmployeePortalDbContext(DbContextOptions<EmployeePortalDbContext> options): base(options) 
        { 
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
