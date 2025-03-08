using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class TemperatureConversionService : ITemperatureConversionService
{
    public double Convert(double value, string fromUnit, string toUnit)
    {
        if (string.IsNullOrWhiteSpace(fromUnit) || string.IsNullOrWhiteSpace(toUnit))
            throw new ArgumentException("Temperature units cannot be null or empty.");

        if (fromUnit.Equals(toUnit, StringComparison.OrdinalIgnoreCase))
            return value;

        return (fromUnit.ToLower(), toUnit.ToLower()) switch
        {
            ("celsius", "fahrenheit") => value * 9 / 5 + 32,
            ("fahrenheit", "celsius") => (value - 32) * 5 / 9,
            ("celsius", "kelvin") => value + 273.15,
            ("kelvin", "celsius") => value - 273.15,
            ("fahrenheit", "kelvin") => (value - 32) * 5 / 9 + 273.15,
            ("kelvin", "fahrenheit") => (value - 273.15) * 9 / 5 + 32,
            _ => throw new ArgumentException($"Invalid temperature unit: {fromUnit} -> {toUnit}")
        };
    }
}