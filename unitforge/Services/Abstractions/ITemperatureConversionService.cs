namespace unitforge.Services.Abstractions;

public interface ITemperatureConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}