namespace AstroMath;

public static class Calculations
{
    private const double speedOfLight = 299_792_458.0; // m/s

    public static double StarVelocity(double observed, double rest)
    {
        return speedOfLight * (observed - rest) / rest;
    }

    public static double StarDistance(double parallaxAngle)
    {
        return 1.0 / parallaxAngle;
    }
    
    public static double DegreesCelsiusToKelvin(double degreesC)
    {
        const double celsiusOffset = 273.15;
        return degreesC + celsiusOffset;
    }

    public static double BlackholeEventHorizon(double massKg)
    {
        const double gravitationalConstant = 6.67430e-11; // m^3 kg^-1 s^-2
        return 2 * gravitationalConstant * massKg / (speedOfLight * speedOfLight);
    }
}
