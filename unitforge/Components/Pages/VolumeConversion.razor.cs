using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using unitforge.Services.Abstractions;

namespace unitforge.Components.Pages;

public partial class VolumeConversion : ComponentBase
{
    [Inject]
    public IVolumeConversionService? VolumeConversionService { get; set; }
    
    [Inject]
    IJSRuntime? JS { get; set; }
    
    private readonly Dictionary<string, List<string>> _unitCategories = new()
    {
        { "Volume",
            [
                "Cubic Meter", "Cubic Kilometer", "Cubic Centimeter", "Cubic Millimeter", "Liter", "Milliliter",
                "US Gallon", "US Quart", "US Pint", "US Cup", "US Fluid Ounce", "US Table Spoon", "US Tea Spoon",
                "Imperial Gallon", "Imperial Quart", "Imperial Pint", "Imperial Fluid Ounce", "Imperial Table Spoon",
                "Imperial Tea Spoon", "Cubic Mile", "Cubic Yard", "Cubic Foot", "Cubic Inch"
            ]
        }
    };

    private readonly List<string> _fromUnits;
    private readonly List<string> _toUnits;
    
    private string _fromUnit = string.Empty;
    private string _toUnit = string.Empty;
    private string _inputValue = string.Empty;
    
    private string? _outputValue;

    public VolumeConversion()
    {
        _fromUnits = new List<string>(_unitCategories["Volume"]);
        _toUnits = new List<string>(_unitCategories["Volume"]);
    }

    private void Recalculate()
    {
        if (string.IsNullOrEmpty(_inputValue) || string.IsNullOrEmpty(_fromUnit) || string.IsNullOrEmpty(_toUnit))
        {
            _outputValue = string.Empty;
            return;
        }

        _outputValue = double.TryParse(_inputValue, out var inputValue) ? 
            VolumeConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture) : 
            "Invalid input";
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