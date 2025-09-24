using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronomicalProcessingClient;

/// <summary>
/// Represents a UI theme with customizable colors for background, foreground, buttons, and borders.
/// </summary>
/// <param name="Background">The background color of the UI.</param>
/// <param name="Foreground">The foreground (text) color of the UI.</param>
/// <param name="ButtonFace">The color of button faces.</param>
/// <param name="ButtonBorder">The color of button borders.</param>
public record struct Theme(
    Color Background,
    Color Foreground,
    Color ButtonFace,
    Color ButtonBorder
)
{
    /// <summary>
    /// Gets the predefined light theme.
    /// </summary>
    public static readonly Theme Light = new(
        Background: SystemColors.Control,
        Foreground: SystemColors.ControlText,
        ButtonFace: SystemColors.ControlLightLight,
        ButtonBorder: SystemColors.ActiveBorder
    );

    /// <summary>
    /// Gets the predefined dark theme.
    /// </summary>
    public static readonly Theme Dark = new(
        Background: Color.FromArgb(45, 45, 45),
        Foreground: Color.FromArgb(241, 241, 241),
        ButtonFace: Color.FromArgb(64, 64, 64),
        ButtonBorder: Color.FromArgb(64, 64, 64)
    );

    /// <summary>
    /// Gets or sets the currently active theme.
    /// </summary>
    public static Theme Current { get; set; } = Light;
}
