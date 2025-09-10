using AstroMath;

using ServiceContracts;

namespace AstronomicalProcessingServer;

internal class AstroServer : IAstroContract
{
    public double BlackholeEventHorizon(double massKg) => Calculations.BlackholeEventHorizon(massKg);

    public double DegreesCelsiusToKelvin(double degreesC) => Calculations.DegreesCelsiusToKelvin(degreesC);

    public double StarDistance(double parallaxAngle) => Calculations.StarDistance(parallaxAngle);

    public double StarVelocity(double observed, double rest) => Calculations.StarVelocity(observed, rest);
}
