namespace unitforge.Services.Abstractions;

public interface IDataStorageConversionService
{
    double Convert(double value, string fromUnit, string toUnit);
}