using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AstronomicalProcessingClient;

public enum CalculationOperation
{
    None,
    StarVelocity,
    StarDistance,
    TemperatureConversion,
    EventHorizon
}

public class CalculationResult
{
    public DateTimeOffset Time { get; init; } = DateTimeOffset.Now;
    public CalculationOperation Operation { get; init; }
    public double Result { get; init; }
}
