namespace unitforge.Models;

public abstract class UnitCategories
{
    public static Dictionary<string, List<string>> Categories => new()
    {
        {
            "Length", [
                "Meter", "Kilometer", "Centimeter", "Millimeter", "Mile", "Yard", "Foot", "Inch", "Micrometer", "Nanometer", "Furlong", "Chain",
                "Nautical Mile (International)", "Nautical Mile (UK)", "Statute Mile", "Statute Yard", "Mile (US Survey)", "Kiloparsec", "Parsec",
                "Astronomical Unit", "Light Year", "League", "Roman Mile", "US Survey Mile", "Fathom", "Hand", "Rod", "Pole", "Perch", "Fathom",
                "Centiinch", "Angstrom", "X-Unit", "Fermi", "Planck Length", "Barleycorn", "Microinch", "Bohr Radius", "Fermi", "Sun's Radius",
                "Earth's Equatorial Radius", "Earth's Polar Radius", "Sun's Radius"
            ]
        },
        {
            "Area", 
            [
                "Square Meter", "Square Kilometer", "Square Centimeter", "Square Millimeter", "Square Inch", "Square Foot", "Square Yard", "Acre", 
                "Hectare", "Square Mile", "Are", "Barn", "Square Foot (US Survey)", "Square Mile (US Survey)", "Square Rod", "Square Chain", 
                "Circular Inch", "Section", "Rood", "Square Perch", "Square Pole", "Square Mil", "Square Dekameter", "Square Nanometer", 
                "Square Decimeter", "Square Hectometer", "Township", "Homestead", "Cuerda", "Arpent", "Sabin", "Varas Castellanas Cuad", 
                "Electron Cross Section"
            ]
        },
        {
            "Volume",
            [
                "Cubic Meter", "Liter", "Milliliter", "Cubic Centimeter", "US Gallon", "Imperial Gallon", "US Quart", "US Pint", "Imperial Pint", 
                "Cubic Yard", "Cubic Foot", "Cubic Inch", "US Fluid Ounce", "Imperial Fluid Ounce", "US Tablespoon", "US Teaspoon", "Imperial Tablespoon", 
                "Imperial Teaspoon", "Exaliter", "Petaliter", "Teraliter", "Kiloliter", "Hectoliter", "Dekaliter", "Cubic Mile", "Cubic Decimeter", 
                "Metric Cup", "Metric Tablespoon", "Acre-Foot", "Barrel (Oil)", "Barrel (US)", "Metric Teaspoon", "Acre-Inch", "Ton Register", 
                "Acre-Foot (US Survey)", "Barrel (UK)", "Stere", "Dram", "Drop", "UK Gill", "UK Teaspoon", "Hogshead", "Taza (Spanish)", "Earth's Volume"
            ]
        },
        {
            "Weight", 
            [
                "Kilogram", "Gram", "Pound", "Ounce", "Metric Ton", "Long Ton", "Short Ton", "Carat", "Stone (UK)", "Stone (US)", "Tonne", 
                "Kiloton (Metric)", "Ton (Assay) (US)", "Ton (Assay) (UK)", "Hectogram", "Dekagram", "Megagram", "Gigagram", "Kilogram-Force Square Second/Meter",
                "Kilopound", "Slug", "Pennyweight", "Hundredweight (US)", "Hundredweight (UK)", "Mina (Biblical Hebrew)", "Quintal (Metric)", "Grain", 
                "Decigram", "Centigram", "Microgram", "Nanogram", "Picogram", "Femtogram", "Attogram", "Dalton", "Electron Mass (Rest)", "Neutron Mass", 
                "Muon Mass", "Proton Mass", "Planck Mass", "Earth's Mass", "Sun's Mass"
            ]
        },
        {
            "Time", 
            [
                "Second", "Minute", "Hour", "Day", "Week", "Month", "Year", "Millisecond", "Microsecond", "Nanosecond", "Picosecond", "Decade", "Century", 
                "Millennium", "Attosecond", "Shake", "Fortnight", "Month (Synodic)", "Year (Julian)", "Year (Leap)", "Year (Tropical)", "Year (Sidereal)", 
                "Day (Sidereal)", "Hour (Sidereal)", "Minute (Sidereal)", "Second (Sidereal)", "Septennial", "Octennial", "Novennial", "Quindecennial", 
                "Quinquennial", "Planck Time"
            ]
        },
        {
            "Temperature",
            [
                "Celsius", "Fahrenheit", "Kelvin", "Rankine", "Reaumur", "Triple point of water"
            ]
        }
    };
}