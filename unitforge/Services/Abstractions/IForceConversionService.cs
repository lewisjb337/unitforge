namespace unitforge.Services.Abstractions;

public interface IForceConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}