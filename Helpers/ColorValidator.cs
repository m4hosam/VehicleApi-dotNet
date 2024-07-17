// VehicleManagementApi/Helpers/ColorValidator.cs

using VehicleManagementApi.Models;

namespace VehicleManagementApi.Helpers;

public static class ColorValidator
{
    public static bool IsValidColor(string color)
    {
        return Enum.TryParse<Color>(color, true, out _);
    }
}