using EmployeePortal.Web.Data;
using EmployeePortal.Web.Models;
using EmployeePortal.Web.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeePortalDbContext dbContext;

        public EmployeesController(EmployeePortalDbContext dbContext)
        {
           this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel viewModel)
        {
            var employee = new Employee{ 
                Email = viewModel.Email, 
                Name = viewModel.Name, 
                Phone = viewModel.Phone, 
                Position = viewModel.Position, 
                Salary = viewModel.Salary, 
                Subscribed = viewModel.Subscribed 
            };
            
            await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();

            return View();
        }
    }
}
