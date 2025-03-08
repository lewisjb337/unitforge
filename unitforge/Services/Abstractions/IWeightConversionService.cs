namespace unitforge.Services.Abstractions;

public interface IWeightConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}