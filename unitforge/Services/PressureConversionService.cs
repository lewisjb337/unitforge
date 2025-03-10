using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class PressureConversionService : IPressureConversionService
{
    private static readonly Dictionary<string, double> PressureFactors = new()
    {
        { "Pascal (Pa)", 1 },
        { "Kilopascal (kPa)", 1e3 },
        { "Bar", 1e5 },
        { "Pounds per square inch (psi)", 6894.757 },
        { "Standard atmosphere (atm)", 101325 },
        { "Megapascal (MPa)", 1e6 },
        { "Torr", 133.322 },
        { "Inch of mercury (inHg)", 3386.389 },
        { "Millimeter of mercury (mmHg)", 133.322 },
        { "Hectopascal (hPa)", 1e2 },
        { "Newton per square meter (N/m²)", 1 },
        { "Newton per square millimeter (N/mm²)", 1e6 },
        { "Dyne per square centimeter", 0.1 },
        { "Kilonewton per square meter (kN/m²)", 1e3 },
        { "Millibar (mbar)", 100 },
        { "Gram-force per square centimeter", 0.980665 },
        { "Kilogram-force per square meter", 9.80665 },
        { "Kilogram-force per square centimeter", 98066.5 },
        { "Pound-force per square foot", 47.8803 },
        { "Pound-force per square inch", 6894.757 },
        { "Ton-force (short) per square foot", 95760.518 },
        { "Ton-force (short) per square inch", 13789514.6 },
        { "Ton-force (long) per square foot", 101600.16 },
        { "Ton-force (long) per square inch", 15694700.4 },
        { "Technical atmosphere (at)", 98066.5 },
        { "Inch of water (inAq)", 249.082 },
        { "Foot of water (ftAq)", 2988.98 },
        { "Millimeter of water", 9.80665 },
        { "Centimeter of water", 98.0665 },
        { "Exapascal (EPa)", 1e18 },
        { "Petapascal (PPa)", 1e15 },
        { "Terapascal (TPa)", 1e12 },
        { "Gigapascal (GPa)", 1e9 },
        { "Decipascal (dPa)", 0.1 },
        { "Centipascal (cPa)", 0.01 },
        { "Millipascal (mPa)", 0.001 },
        { "Micropascal (µPa)", 1e-6 },
        { "Nanopascal (nPa)", 1e-9 },
        { "Picopascal (pPa)", 1e-12 },
        { "Femtopascal (fPa)", 1e-15 },
        { "Attopascal (aPa)", 1e-18 }
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (PressureFactors[fromUnit] / PressureFactors[toUnit]);
    }
}