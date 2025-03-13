using System.Globalization;
using Microsoft.AspNetCore.Components;
using unitforge.Models;
using unitforge.Services.Abstractions;

namespace unitforge.Components.Pages;

public partial class PowerConversion : ComponentBase
{
    [Inject]
    public IPowerConversionService? PowerConversionService { get; set; }

    private readonly List<string> _fromUnits = [..UnitCategories.Categories["Power"]];
    private readonly List<string> _toUnits = [..UnitCategories.Categories["Power"]];
    
    private string _fromUnit = string.Empty;
    private string _toUnit = string.Empty;
    private string _inputValue = string.Empty;
    
    private string? _outputValue;

    private void Recalculate()
    {
        if (string.IsNullOrEmpty(_inputValue) || string.IsNullOrEmpty(_fromUnit) || string.IsNullOrEmpty(_toUnit))
        {
            _outputValue = string.Empty;
            return;
        }

        _outputValue = double.TryParse(_inputValue, out var inputValue) ? 
            PowerConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture) : 
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