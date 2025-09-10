using System.ServiceModel;

namespace ServiceContracts;

[ServiceContract]
public interface IAstroContract
{
    /// <summary>
    /// Calculates the velocity of a star using the observed and rest wavelengths.
    /// </summary>
    /// <param name="observed">The observed wavelength (in meters).</param>
    /// <param name="rest">The rest wavelength (in meters).</param>
    /// <returns>The velocity of the star in meters per second.</returns>
    [OperationContract] double StarVelocity(double observed, double rest);

    /// <summary>
    /// Calculates the distance to a star using its parallax angle.
    /// </summary>
    /// <param name="parallaxAngle">The parallax angle (in arcseconds).</param>
    /// <returns>The distance to the star in parsecs.</returns>
    [OperationContract] double StarDistance(double parallaxAngle);

    /// <summary>
    /// Converts a temperature from degrees Celsius to Kelvin.
    /// </summary>
    /// <param name="degreesC">Temperature in degrees Celsius.</param>
    /// <returns>Temperature in Kelvin.</returns>
    [OperationContract] double DegreesCelsiusToKelvin(double degreesC);

    /// <summary>
    /// Calculates the Schwarzschild radius (event horizon) of a black hole for a given mass.
    /// </summary>
    /// <param name="massKg">Mass of the black hole in kilograms.</param>
    /// <returns>Schwarzschild radius in meters.</returns>
    [OperationContract] double BlackholeEventHorizon(double massKg);
}
