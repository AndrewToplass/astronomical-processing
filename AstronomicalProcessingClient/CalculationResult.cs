using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;

namespace AstronomicalProcessingClient;

[TypeConverter(typeof(CalculationOperationConverter))]
public enum CalculationOperation
{
    None,
    StarVelocity,
    StarDistance,
    TemperatureConversion,
    EventHorizon
}

public class CalculationOperationConverter : EnumConverter
{
    private static readonly ComponentResourceManager _resourceManager =
        new(typeof(MainWindow));

    public CalculationOperationConverter() : base(typeof(CalculationOperation)) { }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType) => destinationType != typeof(string) || value is not CalculationOperation operation
            ? base.ConvertTo(context, culture, value, destinationType)
            : _resourceManager.GetString(
                $"{nameof(CalculationOperation)}.{operation}",
                culture ?? CultureInfo.CurrentUICulture
            ) ?? operation.ToString();
}

public class CalculationResult
{
    public DateTimeOffset Time { get; init; } = DateTimeOffset.Now;
    public CalculationOperation Operation { get; init; }
    public double Result { get; init; }
}
