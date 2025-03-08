namespace unitforge.Services.Abstractions;

public interface ITimeConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}