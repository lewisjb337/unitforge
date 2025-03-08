namespace unitforge.Services.Abstractions;

public interface ILengthConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}