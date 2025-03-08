namespace unitforge.Services.Abstractions;

public interface IAreaConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}