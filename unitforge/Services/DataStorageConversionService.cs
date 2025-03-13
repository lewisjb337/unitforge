using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class DataStorageConversionService : IDataStorageConversionService
{
    private static readonly Dictionary<string, double> ConversionRates = new()
    {
        { "bit", 1 },
        { "nibble", 4 },
        { "byte", 8 },
        { "kilobit", 1000 },
        { "kilobyte", 8000 },
        { "megabit", 1_000_000 },
        { "megabyte", 8_000_000 },
        { "gigabit", 1_000_000_000 },
        { "gigabyte", 8_000_000_000 },
        { "terabit", 1_000_000_000_000 },
        { "terabyte", 8_000_000_000_000 },
        { "petabit", 1_000_000_000_000_000 },
        { "petabyte", 8_000_000_000_000_000 },
        { "exabit", 1_000_000_000_000_000_000 },
        { "exabyte", 8_000_000_000_000_000_000 },
        { "floppy disk (3.5 DD)", 250_000 },
        { "floppy disk (3.5 HD)", 1_440_000 },
        { "floppy disk (3.5 ED)", 2_880_000 },
        { "floppy disk (5.25 DD)", 360_000 },
        { "floppy disk (5.25 HD)", 1_200_000 },
        { "Zip 100", 100_000_000 },
        { "Zip 250", 250_000_000 },
        { "Jaz 1GB", 1_000_000_000 },
        { "Jaz 2GB", 2_000_000_000 },
        { "CD (74 minute)", 650_000_000 },
        { "CD (80 minute)", 700_000_000 },
        { "DVD (1 layer, 1 side)", 4_700_000_000 },
        { "DVD (2 layer, 1 side)", 8_500_000_000 },
        { "DVD (1 layer, 2 side)", 9_400_000_000 },
        { "DVD (2 layer, 2 side)", 17_000_000_000 }
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        var valueInBits = value * ConversionRates[fromUnit];
        
        return valueInBits / ConversionRates[toUnit];
    }
}