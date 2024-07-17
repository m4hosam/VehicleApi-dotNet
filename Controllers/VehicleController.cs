// VehicleManagementApi/Controllers/VehiclesController.cs

using Microsoft.AspNetCore.Mvc;
using VehicleManagementApi.Models;
using VehicleManagementApi.Services;
using VehicleManagementApi.Helpers;

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

    [HttpGet]
    public IActionResult GetAllVehicles()
    {
        var vehicles = _vehicleService.GetAllVehicles();
        return Ok(vehicles);
    }

    [HttpGet("cars")]
    public IActionResult GetCarsByColor([FromQuery] string color)
    {
        if (!ColorValidator.IsValidColor(color))
        {
            return NotFound($"Color '{color}' is not valid. Valid colors are: Red, Blue, Black, White.");
        }

        var parsedColor = Enum.Parse<Color>(color, true);
        var cars = _vehicleService.GetCarsByColor(parsedColor);
        return Ok(cars);
    }

    [HttpGet("buses")]
    public IActionResult GetBusesByColor([FromQuery] string color)
    {
        if (!ColorValidator.IsValidColor(color))
        {
            return NotFound($"Color '{color}' is not valid. Valid colors are: Red, Blue, Black, White.");
        }

        var parsedColor = Enum.Parse<Color>(color, true);
        var buses = _vehicleService.GetBusesByColor(parsedColor);
        return Ok(buses);
    }

    [HttpGet("boats")]
    public IActionResult GetBoatsByColor([FromQuery] string color)
    {
        if (!ColorValidator.IsValidColor(color))
        {
            return NotFound($"Color '{color}' is not valid. Valid colors are: Red, Blue, Black, White.");
        }

        var parsedColor = Enum.Parse<Color>(color, true);
        var boats = _vehicleService.GetBoatsByColor(parsedColor);
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