using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using unitforge.Models;
using unitforge.Services.Abstractions;

namespace unitforge.Components.Pages;

public partial class Home : ComponentBase
{
    [Inject]
    public IAreaConversionService? AreaConversionService { get; set; }
    
    [Inject]
    public IEnergyConversionService? EnergyConversionService { get; set; }
    
    [Inject]
    public ILengthConversionService? LengthConversionService { get; set; }
    
    [Inject]
    public IPressureConversionService? PressureConversionService { get; set; }
    
    [Inject]
    public ITemperatureConversionService? TemperatureConversionService { get; set; }
    
    [Inject]
    public ITimeConversionService? TimeConversionService { get; set; }
    
    [Inject]
    public IVolumeConversionService? VolumeConversionService { get; set; }
    
    [Inject]
    public IWeightConversionService? WeightConversionService { get; set; }
    
    [Inject] 
    private IJSRuntime? Js { get; set; }

    private string _selectedCategory =  "Length";
    
    private List<string> _fromUnits = [..UnitCategories.Categories["Length"]];
    private List<string> _toUnits = [..UnitCategories.Categories["Length"]];
    
    private string _fromUnit = string.Empty;
    private string _toUnit = string.Empty;
    private string _inputValue = string.Empty;
    
    private string? _outputValue;

    private void SelectCategory(string category)
    {
        ResetState();

        if (_selectedCategory == category)
        {
            _selectedCategory = string.Empty; 
        }
        else if (UnitCategories.Categories.TryGetValue(category, out var units))
        {
            _selectedCategory = category; 
            _fromUnits = new List<string>(units);
            _toUnits = new List<string>(units);
        }

        #pragma warning disable CA2012
        Js!.InvokeVoidAsync("clearInputFields");
        #pragma warning restore CA2012

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
                "Area" => AreaConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Energy" => EnergyConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Length" => LengthConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Pressure" => PressureConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Temperature" => TemperatureConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Time" => TimeConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Volume" => VolumeConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
                "Weight" => WeightConversionService!.Convert(inputValue, _fromUnit, _toUnit).ToString(CultureInfo.InvariantCulture),
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