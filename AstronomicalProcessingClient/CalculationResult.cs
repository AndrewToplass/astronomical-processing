using System.ComponentModel;
using System.Globalization;

namespace AstronomicalProcessingClient;

/// <summary>
/// Represents the type of astronomical calculation performed.
/// </summary>
[TypeConverter(typeof(CalculationOperationConverter))]
public enum CalculationOperation
{
    /// <summary>
    /// Calculation of star velocity.
    /// </summary>
    StarVelocity,
    /// <summary>
    /// Calculation of star distance.
    /// </summary>
    StarDistance,
    /// <summary>
    /// Conversion of temperature from Celsius to Kelvin.
    /// </summary>
    TemperatureConversion,
    /// <summary>
    /// Calculation of a black hole's event horizon.
    /// </summary>
    EventHorizon
}

/// <summary>
/// Converts <see cref="CalculationOperation"/> enum values to localized strings for display.
/// </summary>
public class CalculationOperationConverter : EnumConverter
{
    private static readonly ComponentResourceManager ResourceManager =
        new(typeof(MainWindow));

    /// <summary>
    /// Initializes a new instance of the <see cref="CalculationOperationConverter"/> class.
    /// </summary>
    public CalculationOperationConverter() : base(typeof(CalculationOperation)) { }

    /// <summary>
    /// Converts a <see cref="CalculationOperation"/> value to a localized string.
    /// </summary>
    /// <param name="context">The format context.</param>
    /// <param name="culture">The culture to use.</param>
    /// <param name="value">The value to convert.</param>
    /// <param name="destinationType">The type to convert to.</param>
    /// <returns>A localized string representation of the operation, or the default conversion.</returns>
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

/// <summary>
/// Represents the result of an astronomical calculation.
/// </summary>
public class CalculationResult
{
    /// <summary>
    /// Gets the time when the calculation was performed.
    /// </summary>
    public DateTimeOffset Time { get; init; } = DateTimeOffset.Now;

    /// <summary>
    /// Gets the type of calculation performed.
    /// </summary>
    public CalculationOperation Operation { get; init; }

    /// <summary>
    /// Gets the input values used for the calculation.
    /// </summary>
    [TypeConverter(typeof(InputsArrayTypeConverter))]
    public IEnumerable<object> Inputs { get; init; } = [];

    /// <summary>
    /// Gets the result value of the calculation.
    /// </summary>
    public double Result { get; init; }
}

/// <summary>
/// Converts an array of input values to a string for display.
/// </summary>
internal class InputsArrayTypeConverter : TypeConverter
{
    /// <inheritdoc/>
    public override bool CanConvertTo(
        ITypeDescriptorContext? context,
        Type? destinationType
    ) =>
        destinationType == typeof(string) || base.CanConvertTo(context, destinationType);

    /// <inheritdoc/>
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
