using EmployeePortal.Web.Models.Entities;

namespace EmployeePortal.Web.Models
{
    public class AddEmployeeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public bool Subscribed { get; set; }
        public Position Position { get; set; }
    }
}
