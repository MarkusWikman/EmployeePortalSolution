using Microsoft.EntityFrameworkCore;
namespace EmployeePortal.Web.Data
{
    public class StudentPortalDbContext : DbContext
    {
        public StudentPortalDbContext(DbContextOptions<StudentPortalDbContext> options): base(options) 
        { 
        }
    }
}
