namespace unitforge.Services.Abstractions;

public interface IVolumeConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}