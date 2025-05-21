namespace Tutorial10.Model.Models;

public class Device
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsEnabled { get; set; } = true;
    public string AdditionalString { get; set; } = string.Empty;
    public int DeviceTypeId { get; set; }
    public virtual ICollection<DeviceEmployee> DeviceEmployees { get; set; } = new List<DeviceEmployee>();
    public DeviceType DeviceType { get; set; } = new DeviceType();
}