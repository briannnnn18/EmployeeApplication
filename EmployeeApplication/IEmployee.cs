
namespace EmployeeInterface
{
    public interface IEmployee
    {
        string Name { get; set; }
        string LastName { get; set; }
        string JobTitle { get; set; }
        double RatePerHour { get; set; }
        double HoursWorked { get; set; }
        double CalculateSalary();
    }
}