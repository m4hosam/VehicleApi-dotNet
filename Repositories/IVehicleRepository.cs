// VehicleManagementApi/Repositories/IVehicleRepository.cs

using VehicleManagementApi.Models;

namespace VehicleManagementApi.Repositories;

public interface IVehicleRepository
{
    IEnumerable<Car> GetCarsByColor(Color color);
    IEnumerable<Bus> GetBusesByColor(Color color);
    IEnumerable<Boat> GetBoatsByColor(Color color);
    Car? GetCarById(int id);
    void ToggleCarHeadlights(int id);
    void DeleteCar(int id);
}