namespace unitforge.Services.Abstractions;

public interface IPowerConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}