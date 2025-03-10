namespace unitforge.Services.Abstractions;

public interface IPressureConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}