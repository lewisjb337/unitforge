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
        {"Carat", 0.0002},
        {"Atomic Mass Unit", 1.66054e-7},
        {"Exagram", 1e18},
        {"Petagram", 1e15},
        {"Teragram", 1e12},
        {"Gigagram", 1e9},
        {"Megagram", 1e6},
        {"Hectogram", 0.1},
        {"Dekagram", 0.01},
        {"Decigram", 0.0001},
        {"Centigram", 0.00001},
        {"Microgram", 1e-6},
        {"Nanogram", 1e-9},
        {"Picogram", 1e-12},
        {"Femtogram", 1e-15},
        {"Attogram", 1e-18},
        {"Dalton", 1.66054e-27},
        {"Kilogram-Force Square Second/Meter", 9.81},
        {"Kilopound", 0.453592 * 1000},
        {"Kip", 0.453592 * 1000},
        {"Slug", 14.5939},
        {"Pound-Force Square Second/Foot", 0.453592 / 0.3048},
        {"Pound (Troy or Apothecary)", 0.373241},
        {"Poundal", 0.138255},
        {"Ton (Assay) (US)", 0.907184},
        {"Ton (Assay) (UK)", 1.01605},
        {"Kiloton (Metric)", 1e6},
        {"Quintal (Metric)", 100},
        {"Hundredweight (US)", 45.3592},
        {"Hundredweight (UK)", 50.8023},
        {"Quarter (US)", 11.3398},
        {"Quarter (UK)", 12.7006},
        {"Stone (US)", 6.35029},
        {"Stone (UK)", 6.35029},
        {"Tonne", 1000},
        {"Pennyweight", 0.00155517},
        {"Scruple (Apothecary)", 0.002},
        {"Grain", 6.48e-5},
        {"Gamma", 1e-9},
        {"Talent (Biblical Hebrew)", 26.25},
        {"Mina (Biblical Hebrew)", 0.58},
        {"Shekel (Biblical Hebrew)", 0.01},
        {"Bekan (Biblical Hebrew)", 0.005},
        {"Gerah (Biblical Hebrew)", 0.0005},
        {"Talent (Biblical Greek)", 26.25},
        {"Mina (Biblical Greek)", 0.58},
        {"Tetradrachma (Biblical Greek)", 0.324},
        {"Didrachma (Biblical Greek)", 0.162},
        {"Drachma (Biblical Greek)", 0.054},
        {"Denarius (Biblical Roman)", 0.0039},
        {"Assarion (Biblical Roman)", 0.0015},
        {"Quadrans (Biblical Roman)", 0.0009},
        {"Lepton (Biblical Roman)", 0.0004},
        {"Planck Mass", 2.17644e-8},
        {"Electron Mass (Rest)", 9.10938356e-31},
        {"Muon Mass", 1.883531e-28},
        {"Proton Mass", 1.6726219e-27},
        {"Neutron Mass", 1.675e-27},
        {"Deuteron Mass", 3.344e-27},
        {"Earth's Mass", 5.972e24},
        {"Sun's Mass", 1.989e30}
    };

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return value * (WeightFactors[fromUnit] / WeightFactors[toUnit]);
    }
}