using Microsoft.EntityFrameworkCore;
namespace EmployeePortal.Web.Data
{
    public class EmployeePortalDbContext : DbContext
    {
        public EmployeePortalDbContext(DbContextOptions<EmployeePortalDbContext> options): base(options) 
        { 
        }
    }
}
