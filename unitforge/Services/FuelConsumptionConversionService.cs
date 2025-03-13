using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class FuelConsumptionConversionService : IFuelConsumptionConversionService
{
    private static readonly Dictionary<string, double> ConversionRates = new()
    {
        { "meter/liter [m/L]", 1000000000 },
        { "exameter/liter [Em/L]", 1.0E-9 },
        { "petameter/liter [Pm/L]", 1.0E-6 },
        { "terameter/liter [Tm/L]", 0.001 },
        { "gigameter/liter [Gm/L]", 1 },
        { "megameter/liter [Mm/L]", 1000 },
        { "kilometer/liter [km/L]", 1000000 },
        { "hectometer/liter [hm/L]", 10000000 },
        { "dekameter/liter [dam/L]", 100000000 },
        { "centimeter/liter [cm/L]", 100000000000 },
        { "mile (US)/liter [mi/L]", 621371.19223733 },
        { "nautical mile/liter [n.mile/L]", 539594.07503258 },
        { "nautical mile/gallon (US)", 2042585.7698111 },
        { "kilometer/gallon (US)", 3785411.7834003 },
        { "meter/gallon (US)", 3785411783.4003 },
        { "meter/gallon (UK)", 4546099293.9205 },
        { "mile/gallon (US)", 2352145.8329476 },
        { "mile/gallon (UK)", 2824809.3627967 },
        { "meter/cubic meter [m/m^3]", 1000000000000 },
        { "meter/cubic centimeter", 1000000 },
        { "meter/cubic yard [m/yd^3]", 764554858167.78 },
        { "meter/cubic foot [m/ft^3]", 28316846593.194 },
        { "meter/cubic inch [m/in^3]", 16387064.001271 },
        { "meter/quart (US)", 946352946.38742 },
        { "meter/quart (UK)", 1136524822.9634 },
        { "meter/pint (US) [m/pt (US)]", 473176472.96982 },
        { "meter/pint (UK) [m/pt (UK)]", 568262411.67548 },
        { "meter/cup (US)", 236588236.48491 },
        { "meter/cup (UK)", 284131205.91847 },
        { "meter/fluid ounce (US)", 29573529.564112 },
        { "meter/fluid ounce (UK)", 28413120.591847 },
        { "liter/meter [L/m]", 1.0E-9 },
        { "liter/100 km [L/100 km]", 0.0001 },
        { "gallon (US)/mile", 4.2514370749763E-7 },
        { "gallon (US)/100 mi", 4.2514370749763E-5 },
        { "gallon (UK)/mile", 3.5400618995592E-7 },
        { "gallon (UK)/100 mi", 3.5400618995592E-5 }
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        var valueInBase = value * ConversionRates[fromUnit];
        
        return valueInBase / ConversionRates[toUnit];
    }
}