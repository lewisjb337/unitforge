namespace unitforge.Services.Abstractions;

public interface ISpeedConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}