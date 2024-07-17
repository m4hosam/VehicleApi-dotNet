// VehicleManagementApi/Repositories/IVehicleRepository.cs

using VehicleManagementApi.Models;

namespace VehicleManagementApi.Repositories;

public interface IVehicleRepository
{
    IEnumerable<VehicleTotal> GetAllVehicles();
    IEnumerable<VehicleTotal> GetCarsByColor(Color color);
    IEnumerable<VehicleTotal> GetBusesByColor(Color color);
    IEnumerable<VehicleTotal> GetBoatsByColor(Color color);
    Car? GetCarById(int id);
    void ToggleCarHeadlights(int id);
    void DeleteCar(int id);
}