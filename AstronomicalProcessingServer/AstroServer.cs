using AstroMath;

using ServiceContracts;

namespace AstronomicalProcessingServer;

/// <summary>
/// Provides astronomical calculation services by implementing <see cref="IAstroContract"/>.
/// Delegates calculations to <see cref="AstroMath.Calculations"/>.
/// </summary>
internal class AstroServer : IAstroContract
{
    /// <summary>
    /// Calculates the Schwarzschild radius (event horizon) of a black hole for a given mass.
    /// </summary>
    /// <param name="massKg">Mass of the black hole in kilograms.</param>
    /// <returns>Schwarzschild radius in meters.</returns>
    public double BlackholeEventHorizon(double massKg) => Calculations.BlackholeEventHorizon(massKg);

    /// <summary>
    /// Converts a temperature from degrees Celsius to Kelvin.
    /// </summary>
    /// <param name="degreesC">Temperature in degrees Celsius.</param>
    /// <returns>Temperature in Kelvin.</returns>
    public double DegreesCelsiusToKelvin(double degreesC) => Calculations.DegreesCelsiusToKelvin(degreesC);

    /// <summary>
    /// Calculates the distance to a star using its parallax angle.
    /// </summary>
    /// <param name="parallaxAngle">The parallax angle (in arcseconds).</param>
    /// <returns>The distance to the star in parsecs.</returns>
    public double StarDistance(double parallaxAngle) => Calculations.StarDistance(parallaxAngle);

    /// <summary>
    /// Calculates the velocity of a star using the observed and rest wavelengths.
    /// </summary>
    /// <param name="observed">The observed wavelength (in meters).</param>
    /// <param name="rest">The rest wavelength (in meters).</param>
    /// <returns>The velocity of the star in meters per second.</returns>
    public double StarVelocity(double observed, double rest) => Calculations.StarVelocity(observed, rest);
}
