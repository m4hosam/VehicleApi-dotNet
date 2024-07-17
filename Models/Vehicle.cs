// VehicleManagementApi/Models/Vehicle.cs

namespace VehicleManagementApi.Models;

public enum Color
{
    Red,
    Blue,
    Black,
    White
}

public class Vehicle
{
    public int Id { get; set; }
    public Color Color { get; set; }
}

public class Car : Vehicle
{
    public int Wheels { get; set; }
    public bool HeadlightsOn { get; set; }
}

public class Bus : Vehicle
{
}

public class Boat : Vehicle
{
}