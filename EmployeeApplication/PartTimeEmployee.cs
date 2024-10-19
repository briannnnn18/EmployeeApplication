
using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public double RatePerHour { get; set; }
        public double HoursWorked { get; set; }

        public double CalculateSalary()
        {
            return RatePerHour * HoursWorked;
        }
    }
}