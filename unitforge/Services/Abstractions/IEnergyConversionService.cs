namespace unitforge.Services.Abstractions;

public interface IEnergyConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}