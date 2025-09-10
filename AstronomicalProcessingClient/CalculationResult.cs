using System.ComponentModel;
using System.Globalization;

namespace AstronomicalProcessingClient;

[TypeConverter(typeof(CalculationOperationConverter))]
public enum CalculationOperation
{
    StarVelocity,
    StarDistance,
    TemperatureConversion,
    EventHorizon
}

public class CalculationOperationConverter : EnumConverter
{
    private static readonly ComponentResourceManager ResourceManager =
        new(typeof(MainWindow));

    public CalculationOperationConverter() : base(typeof(CalculationOperation)) { }

    public override object? ConvertTo(
        ITypeDescriptorContext? context,
        CultureInfo? culture,
        object? value,
        Type destinationType
    ) =>
        destinationType != typeof(string) || value is not CalculationOperation operation
            ? base.ConvertTo(context, culture, value, destinationType)
            : ResourceManager.GetString(
                $"{nameof(CalculationOperation)}.{operation}",
                culture ?? CultureInfo.CurrentUICulture
            ) ?? operation.ToString();
}

public class CalculationResult
{
    public DateTimeOffset Time { get; init; } = DateTimeOffset.Now;

    public CalculationOperation Operation { get; init; }

    [TypeConverter(typeof(InputsArrayTypeConverter))]
    public IEnumerable<object> Inputs { get; init; } = [];

    public double Result { get; init; }
}

internal class InputsArrayTypeConverter : TypeConverter
{
    public override bool CanConvertTo(
        ITypeDescriptorContext? context,
        Type? destinationType
    ) =>
        destinationType == typeof(string) || base.CanConvertTo(context, destinationType);

    public override object? ConvertTo(
        ITypeDescriptorContext? context,
        CultureInfo? culture,
        object? value,
        Type destinationType
    ) =>
        destinationType != typeof(string) || value is not IEnumerable<object> inputs
            ? base.ConvertTo(context, culture, value, destinationType)
            : string.Join("; ", inputs);
}
