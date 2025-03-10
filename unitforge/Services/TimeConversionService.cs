using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class TimeConversionService : ITimeConversionService
{
    private static readonly Dictionary<string, double> TimeFactors = new()
    {
        {"Second", 1},
        {"Millisecond", 1e3},
        {"Microsecond", 1e6},
        {"Nanosecond", 1e9},
        {"Picosecond", 1e12},
        {"Minute", 60},
        {"Hour", 3600},
        {"Day", 86400},
        {"Week", 604800},
        {"Month", 2628000},
        {"Year", 31536000},
        {"Decade", 315360000},
        {"Century", 3153600000},
        {"Millennium", 31536000000},
        {"Attosecond", 1e18},
        {"Shake", 1e26}, 
        {"Month (Synodic)", 2629746},
        {"Year (Julian)", 31557600},
        {"Year (Leap)", 31622400},
        {"Year (Tropical)", 31556952},
        {"Year (Sidereal)", 31558149},
        {"Day (Sidereal)", 86401.25},
        {"Hour (Sidereal)", 3600.25},
        {"Minute (Sidereal)", 60.004},
        {"Second (Sidereal)", 1.00273790935},
        {"Fortnight", 1209600},
        {"Septennial", 221926800},
        {"Octennial", 241920000},
        {"Novennial", 251852400},
        {"Quindecennial", 473385000},
        {"Quinquennial", 157680000},
        {"Planck Time", 5.8502270636075e-44}
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (TimeFactors[fromUnit] / TimeFactors[toUnit]);
    }
}