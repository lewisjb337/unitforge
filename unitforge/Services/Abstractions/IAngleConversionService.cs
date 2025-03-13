namespace unitforge.Services.Abstractions;

public interface IAngleConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}