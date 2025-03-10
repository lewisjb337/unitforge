using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class EnergyConversionService : IEnergyConversionService
{
    private static readonly Dictionary<string, double> EnergyFactors = new()
    {
        {"Joule", 1},
        {"Kilojoule", 1e3},
        {"Kilowatt-hour", 3.6e6},
        {"Watt-hour", 3.6e3},
        {"Calorie (nutritional)", 4.184e3},
        {"Horsepower (metric) hour", 2.647795e6},
        {"Btu (IT)", 1.055056e3},
        {"Btu (th)", 1.05435e3},
        {"Gigajoule", 1e9},
        {"Megajoule", 1e6},
        {"Millijoule", 1e-3},
        {"Microjoule", 1e-6},
        {"Nanojoule", 1e-9},
        {"Attojoule", 1e-18},
        {"Megaelectron-volt", 1.602176634e-13},
        {"Kiloelectron-volt", 1.602176634e-16},
        {"Electron-volt", 1.602176634e-19},
        {"Erg", 1e-7},
        {"Gigawatt-hour", 3.6e12},
        {"Megawatt-hour", 3.6e9},
        {"Kilowatt-second", 1e3},
        {"Watt-second", 1},
        {"Newton meter", 1},
        {"Horsepower hour", 2.684519e6},
        {"Kilocalorie (IT)", 4.1868e3},
        {"Kilocalorie (th)", 4.184e3},
        {"Calorie (IT)", 4.1868},
        {"Calorie (th)", 4.184},
        {"Mega Btu (IT)", 1.055056e9},
        {"Ton-hour (refrigeration)", 1.055056e9},
        {"Fuel oil equivalent @kiloliter", 4.1868e10},
        {"Fuel oil equivalent @barrel (US)", 6.12e9},
        {"Gigaton", 4.184e18},
        {"Megaton", 4.184e15},
        {"Kiloton", 4.184e12},
        {"Ton (explosives)", 4.184e9},
        {"Dyne centimeter", 1e-7},
        {"Gram-force meter", 9.80665e-3},
        {"Gram-force centimeter", 9.80665e-5},
        {"Kilogram-force centimeter", 9.80665e-2},
        {"Kilogram-force meter", 9.80665},
        {"Kilopond meter", 9.80665},
        {"Pound-force foot", 1.35582},
        {"Pound-force inch", 0.113},
        {"Ounce-force inch", 0.00706},
        {"Foot-pound", 1.35582},
        {"Inch-pound", 0.113},
        {"Inch-ounce", 0.00706},
        {"Poundal foot", 0.04214},
        {"Therm", 1.05506e8},
        {"Therm (EC)", 1.05506e8},
        {"Therm (US)", 1.05506e8},
        {"Hartree energy", 4.359744e-18},
        {"Rydberg constant", 2.179872e-18}
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (EnergyFactors[fromUnit] / EnergyFactors[toUnit]);
    }
}