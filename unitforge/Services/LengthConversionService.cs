using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class LengthConversionService : ILengthConversionService
{
    private static readonly Dictionary<string, double> LengthFactors = new()
    {
        {"Meter", 1},
        {"Kilometer", 1000},
        {"Centimeter", 0.01},
        {"Millimeter", 0.001},
        {"Mile", 1609.34},
        {"Yard", 0.9144},
        {"Foot", 0.3048},
        {"Inch", 0.0254},
        {"Light Year", 9.4607e12},
        {"Nanometer", 1e-9},
        {"Micrometer", 1e-6}
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (LengthFactors[fromUnit] / LengthFactors[toUnit]);
    }
}