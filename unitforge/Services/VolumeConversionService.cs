using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class VolumeConversionService : IVolumeConversionService
{
    private static readonly Dictionary<string, double> VolumeFactors = new()
    {
        {"Cubic Meter", 1},
        {"Cubic Kilometer", 1e9},
        {"Cubic Centimeter", 1e-6},
        {"Cubic Millimeter", 1e-9},
        {"Liter", 0.001},
        {"Milliliter", 0.000001},
        {"Cubic Inch", 0.0000163871},
        {"Cubic Foot", 0.0283168},
        {"US Gallon", 0.00378541},
        {"US Quart", 0.000946353},
        {"US Pint", 0.000473176},
        {"US Cup", 0.000236588},
        {"US Fluid Ounce", 0.0000295735},
        {"US Table Spoon", 0.0000147868},
        {"US Tea Spoon", 0.00000492892},
        {"Imperial Gallon", 0.00454609},
        {"Imperial Quart", 0.00113652},
        {"Imperial Pint", 0.000568261},
        {"Imperial Fluid Ounce", 0.0000284131},
        {"Imperial Table Spoon", 0.0000177582},
        {"Imperial Tea Spoon", 0.0000059194},
        {"Cubic Mile", 4.168e12}
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (VolumeFactors[fromUnit] / VolumeFactors[toUnit]);
    }
}