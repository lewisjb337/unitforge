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
            ("rankine", "celsius") => (value - 491.67) * 5 / 9,
            ("celsius", "rankine") => value * 9 / 5 + 491.67,
            ("rankine", "fahrenheit") => value - 459.67,
            ("fahrenheit", "rankine") => value + 459.67,
            ("rankine", "kelvin") => value * 5 / 9,
            ("kelvin", "rankine") => value * 9 / 5,
            ("reaumur", "celsius") => value * 5 / 4,
            ("celsius", "reaumur") => value * 4 / 5,
            ("reaumur", "fahrenheit") => value * 9 / 4 + 32,
            ("fahrenheit", "reaumur") => (value - 32) * 4 / 9,
            ("reaumur", "kelvin") => value * 5 / 4 + 273.15,
            ("kelvin", "reaumur") => (value - 273.15) * 4 / 5,
            ("triple point of water", "celsius") => value - 0.0036608581051398,
            ("celsius", "triple point of water") => value + 0.0036608581051398,
            ("triple point of water", "fahrenheit") => (value - 0.0036608581051398) * 9 / 5 + 32,
            ("fahrenheit", "triple point of water") => (value - 32) * 5 / 9 + 0.0036608581051398,
            ("triple point of water", "kelvin") => value + 273.15 - 0.0036608581051398,
            ("kelvin", "triple point of water") => value - 273.15 + 0.0036608581051398,
            _ => throw new ArgumentException($"Invalid temperature unit: {fromUnit} -> {toUnit}")
        };
    }
}