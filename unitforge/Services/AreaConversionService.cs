using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class AreaConversionService : IAreaConversionService
{
    private static readonly Dictionary<string, double> AreaFactors = new()
    {
        {"Square Meter", 1},
        {"Square Kilometer", 1_000_000},
        {"Square Centimeter", 0.0001},
        {"Square Millimeter", 0.000001},
        {"Square Micrometer", 1e-12},
        {"Hectare", 10_000},
        {"Square Mile", 2_589_988},
        {"Square Yard", 0.836127},
        {"Square Foot", 0.092903},
        {"Square Inch", 0.00064516},
        {"Acre", 4046.86}
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (AreaFactors[fromUnit] / AreaFactors[toUnit]);
    }
}