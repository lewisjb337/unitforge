using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using unitforge.Services.Abstractions;

namespace unitforge.Components.Pages;

public partial class LengthConversion : ComponentBase
{
    [Inject]
    public ILengthConversionService? LengthConversionService { get; set; }
    
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
        }
    };

    private readonly List<string> _fromUnits;
    private readonly List<string> _toUnits;
    
    private string _fromUnit = string.Empty;
    private string _toUnit = string.Empty;
    private string _inputValue = string.Empty;
    
    private string? _outputValue;

    public LengthConversion()
    {
        _fromUnits = new List<string>(_unitCategories["Length"]);
        _toUnits = new List<string>(_unitCategories["Length"]);
    }

    private void Recalculate()
    {
        if (string.IsNullOrEmpty(_inputValue) || string.IsNullOrEmpty(_fromUnit) || string.IsNullOrEmpty(_toUnit))
        {
            _outputValue = string.Empty;
            return;
        }

        _outputValue = double.TryParse(_inputValue, out var inputValue) ? 
            LengthConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture) : 
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