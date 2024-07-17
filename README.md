# Vehicle Management API

This project is a .NET Core Web API for managing vehicles (cars, buses, and boats) with different colors.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (optional, for Windows users)
- [Visual Studio Code](https://code.visualstudio.com/) (optional, for cross-platform development)

## Installation

1. Clone the repository:
   git clone https://github.com/m4hosam/vehicle-management-api.git
2. Navigate to the project directory:
3. Restore the .NET packages:

```bash
dotnet restore
```

## Running the Application

1. To run the application, use the following command:

```
dotnet run
```

2. The API will start running, typically on `https://localhost:7132` and `http://localhost:5132` (ports may vary).

3. You can access the Swagger UI to test the API endpoints by navigating to `https://localhost:7132/swagger` in your web browser.

## API Endpoints

- GET /api/vehicles - Get all vehicles
- GET /api/vehicles/cars?color={color} - Get cars by color
- GET /api/vehicles/buses?color={color} - Get buses by color
- GET /api/vehicles/boats?color={color} - Get boats by color
- POST /api/vehicles/cars/{id}/headlights - Toggle car headlights
- DELETE /api/vehicles/cars/{id} - Delete a car

Note: Valid colors are Red, Blue, Black, and White.

## Testing

You can use tools like [Postman](https://www.postman.com/) or [curl](https://curl.se/) to test the API endpoints.
