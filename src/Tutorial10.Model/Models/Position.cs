namespace Tutorial10.Model.Models;

public class Position
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int MinExpYears { get; set; } 
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}