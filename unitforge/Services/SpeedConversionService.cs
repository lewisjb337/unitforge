using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class SpeedConversionService : ISpeedConversionService
{
    private static readonly Dictionary<string, double> ConversionRates = new()
    {
        { "meter/second [m/s]", 1 },
        { "kilometer/hour [km/h]", 3.6 },
        { "mile/hour [mi/h]", 2.236936 },
        { "meter/hour [m/h]", 3600 },
        { "meter/minute [m/min]", 60 },
        { "kilometer/minute [km/min]", 0.06 },
        { "kilometer/second [km/s]", 0.001 },
        { "centimeter/hour [cm/h]", 360000 },
        { "centimeter/minute [cm/min]", 6000 },
        { "centimeter/second [cm/s]", 100 },
        { "millimeter/hour [mm/h]", 3600000 },
        { "millimeter/minute [mm/min]", 60000 },
        { "millimeter/second [mm/s]", 1000 },
        { "foot/hour [ft/h]", 11811 },
        { "foot/minute [ft/min]", 196.85 },
        { "foot/second [ft/s]", 3.28084 },
        { "yard/hour [yd/h]", 3937 },
        { "yard/minute [yd/min]", 65.617 },
        { "yard/second [yd/s]", 1.09361 },
        { "mile/minute [mi/min]", 0.037282 },
        { "mile/second [mi/s]", 0.000621371 },
        { "knot [kt, kn]", 1.94384 },
        { "knot (UK) [kt (UK)]", 1.94256 },
        { "Velocity of light in vacuum", 299792458 },
        { "Cosmic velocity - first", 7900 },
        { "Cosmic velocity - second", 11200 },
        { "Cosmic velocity - third", 16670 },
        { "Earth's velocity", 29780 },
        { "Velocity of sound in pure water", 1482 },
        { "Velocity of sound in sea water (20°C, 10 meter deep)", 1522 },
        { "Mach (20°C, 1 atm)", 343 },
        { "Mach (SI standard)", 331.3 }
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        var valueInBase = value * ConversionRates[fromUnit];
        
        return valueInBase / ConversionRates[toUnit];
    }
}