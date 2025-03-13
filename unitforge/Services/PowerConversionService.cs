using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class PowerConversionService : IPowerConversionService
{
    private static readonly Dictionary<string, double> PowerUnits = new()
    {
        { "watt", 1.0E+18 },
        { "exawatt", 1 },
        { "petawatt", 1000 },
        { "terawatt", 1_000_000 },
        { "gigawatt", 1_000_000_000 },
        { "megawatt", 1.0E+12 },
        { "kilowatt", 1.0E+15 },
        { "hectowatt", 1.0E+16 },
        { "dekawatt", 1.0E+17 },
        { "deciwatt", 1.0E+19 },
        { "centiwatt", 1.0E+20 },
        { "milliwatt", 1.0E+21 },
        { "microwatt", 1.0E+24 },
        { "nanowatt", 1.0E+27 },
        { "picowatt", 1.0E+30 },
        { "femtowatt", 1.0E+33 },
        { "attowatt", 1.0E+36 },
        { "horsepower", 1.341022089595E+15 },
        { "horsepower_metric", 1.3596216173039E+15 },
        { "BTU_hour", 3.4121416331279E+18 },
        { "kilocalorie_hour", 8.5984522785898E+17 },
        { "foot_pound_force_hour", 2.655223737402E+21 },
        { "volt_ampere", 1.0E+18 },
        { "joule_second", 1.0E+18 }
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        var baseValue = value * PowerUnits[fromUnit];
        
        return PowerUnits[toUnit] / baseValue;
    }
}