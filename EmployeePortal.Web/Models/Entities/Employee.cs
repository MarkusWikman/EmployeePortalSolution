namespace EmployeePortal.Web.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Decimal { get; set; }
        public bool Subscribed { get; set; }
        public Position Position { get; set; }
    }

    public enum Position
    {
        Receptionist, Accountant, Developer, Cleaner, Manager
    }
}
