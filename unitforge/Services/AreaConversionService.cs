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
        {"Acre", 4046.86},
        {"Square Mile", 2_589_988},
        {"Square Yard", 0.836127},
        {"Square Foot", 0.092903},
        {"Square Inch", 0.00064516},
        {"Square Hectometer", 10_000},
        {"Square Dekameter", 100},
        {"Square Decimeter", 0.01},
        {"Square Nanometer", 1e-18},
        {"Are", 100},
        {"Barn", 1e-28},
        {"Square Mile (US Survey)", 2_589_998.47},
        {"Square Foot (US Survey)", 0.09290341161},
        {"Circular Inch", 0.0005067075},
        {"Township", 93_239_940_000},
        {"Section", 2_589_988},
        {"Acre (US Survey)", 4046.87261},
        {"Rood", 1011.714},
        {"Square Chain", 404.686},
        {"Square Rod", 25.2929},
        {"Square Rod (US Survey)", 25.29285264},
        {"Square Perch", 25.2929},
        {"Square Pole", 25.2929},
        {"Square Mil", 6.4516e-10},
        {"Circular Mil", 5.067075e-10},
        {"Homestead", 6474970},
        {"Sabin", 0.092903},
        {"Arpent", 3418.89},
        {"Cuerda", 3930.395},
        {"Plaza", 6400},
        {"Varas Castellanas Cuad", 0.698737},
        {"Varas Conuqueras Cuad", 6.289714},
        {"Electron Cross Section", 1e-28}
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (AreaFactors[fromUnit] / AreaFactors[toUnit]);
    }
}