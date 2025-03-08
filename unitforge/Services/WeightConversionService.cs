using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class WeightConversionService : IWeightConversionService
{
    private static readonly Dictionary<string, double> WeightFactors = new()
    {
        {"Kilogram", 1},
        {"Gram", 0.001},
        {"Milligram", 0.000001},
        {"Metric Ton", 1000},
        {"Long Ton", 1016.05},
        {"Short Ton", 907.184},
        {"Pound", 0.453592},
        {"Ounce", 0.0283495},
        {"Carrat", 0.0002},
        {"Atomic Mass Unit", 1.66054e-7}
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (WeightFactors[fromUnit] / WeightFactors[toUnit]);
    }
}