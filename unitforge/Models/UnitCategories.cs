namespace unitforge.Models;

public abstract class UnitCategories
{
    public static Dictionary<string, List<string>> Categories => new()
    {
        {
          "Angle",
          [
              "degree [°]", "radian [rad]", "grad [^g]", "minute [']", "second [\" ]",
              "gon", "sign", "mil", "revolution [r]", "circle", "turn", "quadrant",
              "right angle", "sextant"
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
            "Data",
            [
                "bit", "nibble", "byte", "kilobit", "kilobyte", "megabit", "megabyte", "gigabit", "gigabyte", "terabit", "terabyte", "petabit", "petabyte",
                "exabit", "exabyte", "floppy disk (3.5 DD)", "floppy disk (3.5 HD)", "floppy disk (3.5 ED)", "floppy disk (5.25 DD)", "floppy disk (5.25 HD)",
                "Zip 100", "Zip 250", "Jaz 1GB", "Jaz 2GB", "CD (74 minute)", "CD (80 minute)", "DVD (1 layer, 1 side)", "DVD (2 layer, 1 side)", 
                "DVD (1 layer, 2 side)", "DVD (2 layer, 2 side)"
            ]
        },
        {
            "Energy",
            [
                "Joule", "Kilojoule", "Kilowatt-hour", "Watt-hour", "Calorie (nutritional)", "Horsepower (metric) hour", "Btu (IT)", "Btu (th)", 
                "Gigajoule", "Megajoule", "Millijoule", "Microjoule", "Nanojoule", "Attojoule", "Megaelectron-volt", "Kiloelectron-volt", 
                "Electron-volt", "Erg", "Gigawatt-hour", "Megawatt-hour", "Kilowatt-second", "Watt-second", "Newton meter", "Horsepower hour", 
                "Kilocalorie (IT)", "Kilocalorie (th)", "Calorie (IT)", "Calorie (th)", "Mega Btu (IT)", "Ton-hour (refrigeration)", "Fuel oil equivalent @kiloliter", 
                "Fuel oil equivalent @barrel (US)", "Gigaton", "Megaton", "Kiloton", "Ton (explosives)", "Dyne centimeter", "Gram-force meter", 
                "Gram-force centimeter", "Kilogram-force centimeter", "Kilogram-force meter", "Kilopond meter", "Pound-force foot", "Pound-force inch",
                "Ounce-force inch", "Foot-pound", "Inch-pound", "Inch-ounce", "Poundal foot", "Therm", "Therm (EC)", "Therm (US)", "Hartree energy", 
                "Rydberg constant"
            ]
        },
        {
            "Force",
            [
                "newton [N]", "kilonewton [kN]", "gram-force [gf]", "kilogram-force [kgf]",
                "ton-force (metric) [tf]", "exanewton [EN]", "petanewton [PT]", "teranewton [TN]",
                "giganewton [GN]", "meganewton [MN]", "hectonewton [hN]", "dekanewton [daN]",
                "decinewton [dN]", "centinewton [cN]", "millinewton [mN]", "micronewton [µN]",
                "nanonewton [nN]", "piconewton [pN]", "femtonewton [fN]", "attonewton [aN]",
                "dyne [dyn]", "joule/meter [J/m]", "joule/centimeter [J/cm]", "ton-force (short)",
                "ton-force (long) [tonf (UK)]", "kip-force [kipf]", "kilopound-force [kipf]",
                "pound-force [lbf]", "ounce-force [ozf]", "poundal [pdl]", "pound foot/square second",
                "pond [p]", "kilopond [kp]"
            ]
        },
        {
            "Fuel",
              [
                "meter/liter [m/L]", "exameter/liter [Em/L]", "petameter/liter [Pm/L]", "terameter/liter [Tm/L]",
                "gigameter/liter [Gm/L]", "megameter/liter [Mm/L]", "kilometer/liter [km/L]", "hectometer/liter [hm/L]",
                "dekameter/liter [dam/L]", "centimeter/liter [cm/L]", "mile (US)/liter [mi/L]", "nautical mile/liter [n.mile/L]",
                "nautical mile/gallon (US)", "kilometer/gallon (US)", "meter/gallon (US)", "meter/gallon (UK)",
                "mile/gallon (US)", "mile/gallon (UK)", "meter/cubic meter [m/m^3]", "meter/cubic centimeter",
                "meter/cubic yard [m/yd^3]", "meter/cubic foot [m/ft^3]", "meter/cubic inch [m/in^3]", "meter/quart (US)",
                "meter/quart (UK)", "meter/pint (US) [m/pt (US)]", "meter/pint (UK) [m/pt (UK)]", "meter/cup (US)",
                "meter/cup (UK)", "meter/fluid ounce (US)", "meter/fluid ounce (UK)", "liter/meter [L/m]",
                "liter/100 km [L/100 km]", "gallon (US)/mile", "gallon (US)/100 mi", "gallon (UK)/mile", "gallon (UK)/100 mi"
            ]
        },
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
            "Power", [
                "watt", "exawatt", "petawatt", "terawatt", "gigawatt", "megawatt", "kilowatt", "hectowatt", "dekawatt", "deciwatt", "centiwatt", 
                "milliwatt", "microwatt", "nanowatt", "picowatt", "femtowatt", "attowatt", "horsepower", "horsepower_metric", "BTU_hour", 
                "kilocalorie_hour", "foot_pound_force_hour", "volt_ampere", "joule_second"
            ]
        },
        {
            "Pressure",
            [
                "Pascal (Pa)", "Kilopascal (kPa)", "Bar", "Pounds per square inch (psi)", "Standard atmosphere (atm)", "Megapascal (MPa)", "Torr", 
                "Inch of mercury (inHg)", "Millimeter of mercury (mmHg)", "Hectopascal (hPa)", "Newton per square meter (N/m²)", "Newton per square millimeter (N/mm²)",
                "Dyne per square centimeter", "Kilonewton per square meter (kN/m²)", "Millibar (mbar)", "Gram-force per square centimeter", 
                "Kilogram-force per square meter", "Kilogram-force per square centimeter", "Pound-force per square foot", "Pound-force per square inch", 
                "Ton-force (short) per square foot", "Ton-force (short) per square inch", "Ton-force (long) per square foot", "Ton-force (long) per square inch",
                "Technical atmosphere (at)", "Inch of water (inAq)", "Foot of water (ftAq)", "Millimeter of water", "Centimeter of water", "Exapascal (EPa)",
                "Petapascal (PPa)", "Terapascal (TPa)", "Gigapascal (GPa)", "Decipascal (dPa)", "Centipascal (cPa)", "Millipascal (mPa)", "Micropascal (µPa)", 
                "Nanopascal (nPa)", "Picopascal (pPa)", "Femtopascal (fPa)", "Attopascal (aPa)"
            ]
        },
        {
            "Speed",
            [
                "meter/second [m/s]", "kilometer/hour [km/h]", "mile/hour [mi/h]", "meter/hour [m/h]",
                "meter/minute [m/min]", "kilometer/minute [km/min]", "kilometer/second [km/s]", "centimeter/hour [cm/h]",
                "centimeter/minute [cm/min]", "centimeter/second [cm/s]", "millimeter/hour [mm/h]", "millimeter/minute [mm/min]",
                "millimeter/second [mm/s]", "foot/hour [ft/h]", "foot/minute [ft/min]", "foot/second [ft/s]", "yard/hour [yd/h]",
                "yard/minute [yd/min]", "yard/second [yd/s]", "mile/minute [mi/min]", "mile/second [mi/s]", "knot [kt, kn]",
                "knot (UK) [kt (UK)]", "Velocity of light in vacuum", "Cosmic velocity - first", "Cosmic velocity - second",
                "Cosmic velocity - third", "Earth's velocity", "Velocity of sound in pure water", "Velocity of sound in sea water (20°C, 10 meter deep)",
                "Mach (20°C, 1 atm)", "Mach (SI standard)"
            ]
        },
        {
            "Temperature",
            [
                "Celsius", "Fahrenheit", "Kelvin", "Rankine", "Reaumur", "Triple point of water"
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
        }
    };
}