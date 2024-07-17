namespace VehicleManagementApi.Models;

public enum Color
{
    Red,
    Blue,
    Black,
    White
}

public enum VehicleType
{
    Car,
    Bus,
    Boat
}

public class Vehicle
{
    public int Id { get; set; }
    public Color Color { get; set; }
    public VehicleType Type { get; set; }
}

public class Car : Vehicle
{
    public Car()
    {
        Type = VehicleType.Car;
    }

    public int Wheels { get; set; }
    public bool HeadlightsOn { get; set; }
}

public class Bus : Vehicle
{
    public Bus()
    {
        Type = VehicleType.Bus;
    }
}

public class Boat : Vehicle
{
    public Boat()
    {
        Type = VehicleType.Boat;
    }
}