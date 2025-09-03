namespace AstroMath;

/// <summary>
/// Provides astronomical and physical calculation methods.
/// </summary>
public static class Calculations
{
    private const double SpeedOfLight = 299_792_458.0; // m/s
    const double CelsiusToKelvinOffset = 273.15;
    const double GravitationalConstant = 6.67430e-11; // m^3 kg^-1 s^-2

    /// <summary>
    /// Calculates the velocity of a star using the observed and rest wavelengths.
    /// </summary>
    /// <param name="observed">The observed wavelength (in meters).</param>
    /// <param name="rest">The rest wavelength (in meters).</param>
    /// <returns>The velocity of the star in meters per second.</returns>
    public static double StarVelocity(double observed, double rest) =>
        SpeedOfLight * (observed - rest) / rest;

    /// <summary>
    /// Calculates the distance to a star using its parallax angle.
    /// </summary>
    /// <param name="parallaxAngle">The parallax angle (in arcseconds).</param>
    /// <returns>The distance to the star in parsecs.</returns>
    public static double StarDistance(double parallaxAngle) =>
        1.0 / parallaxAngle;

    /// <summary>
    /// Converts a temperature from degrees Celsius to Kelvin.
    /// </summary>
    /// <param name="degreesC">Temperature in degrees Celsius.</param>
    /// <returns>Temperature in Kelvin.</returns>
    public static double DegreesCelsiusToKelvin(double degreesC) =>
        degreesC + CelsiusToKelvinOffset;

    /// <summary>
    /// Calculates the Schwarzschild radius (event horizon) of a black hole for a given mass.
    /// </summary>
    /// <param name="massKg">Mass of the black hole in kilograms.</param>
    /// <returns>Schwarzschild radius in meters.</returns>
    public static double BlackholeEventHorizon(double massKg) =>
        2 * GravitationalConstant * massKg / (SpeedOfLight * SpeedOfLight);
}
