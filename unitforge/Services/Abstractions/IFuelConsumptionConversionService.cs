namespace unitforge.Services.Abstractions;

public interface IFuelConsumptionConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}