namespace VehicleManagementApi.Models;

public class VehicleTotal
{
    public int Id { get; set; }
    public string? Color { get; set; }
    public string? Type { get; set; }
    public int? Wheels { get; set; }
    public bool? HeadlightsOn { get; set; }
}