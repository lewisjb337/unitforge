using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class AngleConversionService : IAngleConversionService
{
    private static readonly Dictionary<string, double> ConversionRates = new()
    {
        { "degree [°]", 1 },
        { "radian [rad]", 57.2957795131 },
        { "grad [^g]", 0.9 },
        { "minute [']", 60 },
        { "second [\" ]", 3600 },
        { "gon", 0.9 },
        { "sign", 30 },
        { "mil", 0.05625 },
        { "revolution [r]", 360 },
        { "circle", 360 },
        { "turn", 360 },
        { "quadrant", 90 },
        { "right angle", 90 },
        { "sextant", 60 }
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        var valueInBase = value * ConversionRates[fromUnit];
        
        return valueInBase / ConversionRates[toUnit];
    }
}