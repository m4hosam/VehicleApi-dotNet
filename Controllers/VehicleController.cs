// VehicleManagementApi/Controllers/VehiclesController.cs

using Microsoft.AspNetCore.Mvc;
using VehicleManagementApi.Models;
using VehicleManagementApi.Services;

namespace VehicleManagementApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    private readonly VehicleService _vehicleService;

    public VehiclesController(VehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }

    [HttpGet("cars")]
    public IActionResult GetCarsByColor([FromQuery] Color color)
    {
        var cars = _vehicleService.GetCarsByColor(color);
        return Ok(cars);
    }

    [HttpGet("buses")]
    public IActionResult GetBusesByColor([FromQuery] Color color)
    {
        var buses = _vehicleService.GetBusesByColor(color);
        return Ok(buses);
    }

    [HttpGet("boats")]
    public IActionResult GetBoatsByColor([FromQuery] Color color)
    {
        var boats = _vehicleService.GetBoatsByColor(color);
        return Ok(boats);
    }

    [HttpPost("cars/{id}/headlights")]
    public IActionResult ToggleCarHeadlights(int id)
    {
        _vehicleService.ToggleCarHeadlights(id);
        var updatedCar = _vehicleService.GetCarById(id);
        if (updatedCar == null)
        {
            return NotFound();
        }
        return Ok(updatedCar);
    }

    [HttpDelete("cars/{id}")]
    public IActionResult DeleteCar(int id)
    {
        _vehicleService.DeleteCar(id);
        return Ok();
    }
}