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
        // Initialize with 6 cars
        _cars = new List<Car>
        {
            new Car { Id = 1, Color = Color.Red, Wheels = 4, HeadlightsOn = false },
            new Car { Id = 2, Color = Color.Blue, Wheels = 4, HeadlightsOn = false },
            new Car { Id = 3, Color = Color.Black, Wheels = 4, HeadlightsOn = true },
            new Car { Id = 4, Color = Color.Red, Wheels = 4, HeadlightsOn = false },
            new Car { Id = 5, Color = Color.White, Wheels = 4, HeadlightsOn = true },
            new Car { Id = 6, Color = Color.Blue, Wheels = 4, HeadlightsOn = false }
        };

        // Initialize with 6 buses
        _buses = new List<Bus>
        {
            new Bus { Id = 7, Color =  Color.Red },
            new Bus { Id = 8, Color = Color.Blue },
            new Bus { Id = 9, Color = Color.Black },
            new Bus { Id = 10, Color = Color.Red},
            new Bus { Id = 11, Color = Color.White},
            new Bus { Id = 12, Color = Color.Blue  }
        };

        // Initialize with 4 boats
        _boats = new List<Boat>
        {
            new Boat { Id = 13, Color = Color.Blue  },
            new Boat { Id = 14, Color =Color.White },
            new Boat { Id = 15, Color = Color.Red},
            new Boat { Id = 16, Color = Color.Black}
        };
    }
    public IEnumerable<VehicleTotal> GetAllVehicles()
    {
        var vehicles = new List<VehicleTotal>();

        vehicles.AddRange(_cars.Select(c => new VehicleTotal
        {
            Id = c.Id,
            Color = c.Color.ToString(),
            Type = "Car",
            Wheels = c.Wheels,
            HeadlightsOn = c.HeadlightsOn
        }));

        vehicles.AddRange(_buses.Select(b => new VehicleTotal
        {
            Id = b.Id,
            Color = b.Color.ToString(),
            Type = "Bus"
        }));

        vehicles.AddRange(_boats.Select(b => new VehicleTotal
        {
            Id = b.Id,
            Color = b.Color.ToString(),
            Type = "Boat"
        }));

        return vehicles;
    }

    public IEnumerable<VehicleTotal> GetCarsByColor(Color color) =>
        _cars.Where(c => c.Color == color)
             .Select(c => new VehicleTotal
             {
                 Id = c.Id,
                 Color = c.Color.ToString(),
                 Type = "Car",
                 Wheels = c.Wheels,
                 HeadlightsOn = c.HeadlightsOn
             });

    public IEnumerable<VehicleTotal> GetBusesByColor(Color color) =>
        _buses.Where(b => b.Color == color)
              .Select(b => new VehicleTotal
              {
                  Id = b.Id,
                  Color = b.Color.ToString(),
                  Type = "Bus"
              });

    public IEnumerable<VehicleTotal> GetBoatsByColor(Color color) =>
        _boats.Where(b => b.Color == color)
              .Select(b => new VehicleTotal
              {
                  Id = b.Id,
                  Color = b.Color.ToString(),
                  Type = "Boat"
              });
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