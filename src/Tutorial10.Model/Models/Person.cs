namespace Tutorial10.Model.Models;

public class Person
{
    public int Id { get; set; }
    public string PassportNumber { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
