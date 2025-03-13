using unitforge.Services.Abstractions;

namespace unitforge.Services;

public class ForceConversionService : IForceConversionService
{
    private static readonly Dictionary<string, double> ConversionRates = new()
    {
        { "newton [N]", 1.0E+18 },
        { "kilonewton [kN]", 1.0E+15 },
        { "gram-force [gf]", 1.0197162129779E+20 },
        { "kilogram-force [kgf]", 1.0197162129779E+17 },
        { "ton-force (metric) [tf]", 1.0197162129779E+14 },
        { "exanewton [EN]", 1 },
        { "petanewton [PT]", 1000 },
        { "teranewton [TN]", 1000000 },
        { "giganewton [GN]", 1000000000 },
        { "meganewton [MN]", 1000000000000 },
        { "hectonewton [hN]", 1.0E+16 },
        { "dekanewton [daN]", 1.0E+17 },
        { "decinewton [dN]", 1.0E+19 },
        { "centinewton [cN]", 1.0E+20 },
        { "millinewton [mN]", 1.0E+21 },
        { "micronewton [µN]", 1.0E+24 },
        { "nanonewton [nN]", 1.0E+27 },
        { "piconewton [pN]", 1.0E+30 },
        { "femtonewton [fN]", 1.0E+33 },
        { "attonewton [aN]", 1.0E+36 },
        { "dyne [dyn]", 1.0E+23 },
        { "joule/meter [J/m]", 1.0E+18 },
        { "joule/centimeter [J/cm]", 1.0E+20 },
        { "ton-force (short)", 1.1240447154986E+14 },
        { "ton-force (long) [tonf (UK)]", 1.003611353125E+14 },
        { "kip-force [kipf]", 2.248089431E+14 },
        { "kilopound-force [kipf]", 2.248089431E+14 },
        { "pound-force [lbf]", 2.248089431E+17 },
        { "ounce-force [ozf]", 3.5969430896E+18 },
        { "poundal [pdl]", 7.2330138512099E+18 },
        { "pound foot/square second", 7.2330138512099E+18 },
        { "pond [p]", 1.0197162129779E+20 },
        { "kilopond [kp]", 1.0197162129779E+17 }
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        var valueInBase = value * ConversionRates[fromUnit];
        
        return ConversionRates[toUnit] / valueInBase;
    }
}