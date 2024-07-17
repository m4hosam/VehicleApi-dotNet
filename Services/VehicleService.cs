// VehicleManagementApi/Services/VehicleService.cs

using VehicleManagementApi.Models;
using VehicleManagementApi.Repositories;

namespace VehicleManagementApi.Services;

public class VehicleService
{
    private readonly IVehicleRepository _repository;

    public VehicleService(IVehicleRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Car> GetCarsByColor(Color color) => _repository.GetCarsByColor(color);
    public IEnumerable<Bus> GetBusesByColor(Color color) => _repository.GetBusesByColor(color);
    public IEnumerable<Boat> GetBoatsByColor(Color color) => _repository.GetBoatsByColor(color);
    public Car? GetCarById(int id) => _repository.GetCarById(id);
    public void ToggleCarHeadlights(int id) => _repository.ToggleCarHeadlights(id);
    public void DeleteCar(int id) => _repository.DeleteCar(id);
}