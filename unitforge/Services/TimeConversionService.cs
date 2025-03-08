using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class TimeConversionService : ITimeConversionService
{
    private static readonly Dictionary<string, double> TimeFactors = new()
    {
        {"Second", 1},
        {"Millisecond", 0.001},
        {"Microsecond", 0.000001},
        {"Nanosecond", 0.000000001},
        {"Picosecond", 1e-12},
        {"Minute", 60},
        {"Hour", 3600},
        {"Day", 86400},
        {"Week", 604800},
        {"Month", 2_628_000},
        {"Year", 31_536_000}
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (TimeFactors[fromUnit] / TimeFactors[toUnit]);
    }
}