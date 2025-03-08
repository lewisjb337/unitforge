using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using unitforge.Services.Abstractions;

namespace unitforge.Components.Pages;

public partial class Home : ComponentBase
{
    [Inject]
    public IAreaConversionService? AreaConversionService { get; set; }
    
    [Inject]
    public ILengthConversionService? LengthConversionService { get; set; }
    
    [Inject]
    public ITemperatureConversionService? TemperatureConversionService { get; set; }
    
    [Inject]
    public ITimeConversionService? TimeConversionService { get; set; }
    
    [Inject]
    public IVolumeConversionService? VolumeConversionService { get; set; }
    
    [Inject]
    public IWeightConversionService? WeightConversionService { get; set; }
    
    [Inject]
    IJSRuntime? JS { get; set; }
    
    private readonly Dictionary<string, List<string>> _unitCategories = new()
    {
        { "Length",
            [
                "Meter", "Kilometer", "Centimeter", "Millimeter", "Micrometer", "Nanometer", "Mile", "Yard", "Foot",
                "Inch",
                "Light Year"
            ]
        },
        { "Area",
            [
                "Square Meter", "Square Kilometer", "Square Centimeter", "Square Millimeter", "Square Micrometer",
                "Hectare", "Square Mile", "Square Yard", "Square Foot", "Square Inch", "Acre"
            ]
        },
        { "Volume",
            [
                "Cubic Meter", "Cubic Kilometer", "Cubic Centimeter", "Cubic Millimeter", "Liter", "Milliliter",
                "US Gallon", "US Quart", "US Pint", "US Cup", "US Fluid Ounce", "US Table Spoon", "US Tea Spoon",
                "Imperial Gallon", "Imperial Quart", "Imperial Pint", "Imperial Fluid Ounce", "Imperial Table Spoon",
                "Imperial Tea Spoon", "Cubic Mile", "Cubic Yard", "Cubic Foot", "Cubic Inch"
            ]
        },
        { "Weight",
            [
                "Kilogram", "Gram", "Milligram", "Metric Ton", "Long Ton", "Short Ton", "Pound", "Ounce", "Carrat",
                "Atomic Mass Unit"
            ]
        },
        { "Time",
            [
                "Second", "Millisecond", "Microsecond", "Nanosecond", "Picosecond", "Minute", "Hour", "Day", "Week",
                "Month", "Year"
            ]
        },
        { "Temperature", ["Celsius", "Fahrenheit", "Kelvin"] }
    };

    private string _selectedCategory =  "Length";
    
    private List<string> _fromUnits;
    private List<string> _toUnits;
    
    private string _fromUnit = string.Empty;
    private string _toUnit = string.Empty;
    private string _inputValue = string.Empty;
    
    private string? _outputValue;

    public Home()
    {
        _fromUnits = new List<string>(_unitCategories["Length"]);
        _toUnits = new List<string>(_unitCategories["Length"]);
    }

    private void SelectCategory(string category)
    {
        ResetState();

        if (_selectedCategory == category)
        {
            _selectedCategory = string.Empty; 
        }
        else if (_unitCategories.TryGetValue(category, out var units))
        {
            _selectedCategory = category; 
            _fromUnits = new List<string>(units);
            _toUnits = new List<string>(units);
        }

        JS.InvokeVoidAsync("clearInputFields");
        
        StateHasChanged();
    }

    private void ResetState()
    {
        _fromUnits.Clear();
        _toUnits.Clear();
        _inputValue = string.Empty;
        _outputValue = string.Empty;
        _fromUnit = string.Empty;
        _toUnit = string.Empty;
    }

    private void Recalculate()
    {
        if (string.IsNullOrEmpty(_inputValue) || string.IsNullOrEmpty(_fromUnit) || string.IsNullOrEmpty(_toUnit))
        {
            _outputValue = string.Empty;
            return;
        }

        if (double.TryParse(_inputValue, out var inputValue))
        {
            _outputValue = _selectedCategory switch
            {
                "Length" => LengthConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Weight" => WeightConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Area" => AreaConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Volume" => VolumeConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Time" => TimeConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Temperature" => TemperatureConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                _ => "Unsupported"
            };
        }
        else
        {
            _outputValue = "Invalid input";
        }
    }

    private void OnInputChange(ChangeEventArgs e)
    {
        _inputValue = e.Value?.ToString() ?? string.Empty;
        Recalculate();
    }

    private void OnUnitChangeFrom(ChangeEventArgs e)
    {
        _fromUnit = e.Value?.ToString() ?? string.Empty;
        Recalculate();
    }

    private void OnUnitChangeTo(ChangeEventArgs e)
    {
        _toUnit = e.Value?.ToString() ?? string.Empty;
        Recalculate();
    }
}