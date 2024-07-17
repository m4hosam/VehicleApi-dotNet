// VehicleManagementApi/Repositories/VehicleRepository.cs

using VehicleManagementApi.Models;

namespace VehicleManagementApi.Repositories;

public class VehicleRepository : IVehicleRepository
{
    private static readonly List<Car> _cars;
    private static readonly List<Bus> _buses;
    private static readonly List<Boat> _boats;

    static VehicleRepository()
    {
        // Initialize with some sample data
        _cars = new List<Car>
        {
            new Car { Id = 1, Color = Color.Red, Wheels = 4, HeadlightsOn = false },
            new Car { Id = 2, Color = Color.Blue, Wheels = 4, HeadlightsOn = false },
        };

        _buses = new List<Bus>
        {
            new Bus { Id = 1, Color = Color.White },
            new Bus { Id = 2, Color = Color.Black },
        };

        _boats = new List<Boat>
        {
            new Boat { Id = 1, Color = Color.Blue },
            new Boat { Id = 2, Color = Color.Red },
        };
    }

    public IEnumerable<Car> GetCarsByColor(Color color) => _cars.Where(c => c.Color == color);
    public IEnumerable<Bus> GetBusesByColor(Color color) => _buses.Where(b => b.Color == color);
    public IEnumerable<Boat> GetBoatsByColor(Color color) => _boats.Where(b => b.Color == color);
    public Car? GetCarById(int id) => _cars.FirstOrDefault(c => c.Id == id);

    public void ToggleCarHeadlights(int id)
    {
        var car = GetCarById(id);
        if (car != null)
        {
            car.HeadlightsOn = !car.HeadlightsOn;
        }
    }

    public void DeleteCar(int id)
    {
        var car = GetCarById(id);
        if (car != null)
        {
            _cars.Remove(car);
        }
    }
}