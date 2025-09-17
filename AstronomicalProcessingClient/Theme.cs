using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronomicalProcessingClient;

public record struct Theme(
    Color Background,
    Color Foreground,
    Color ButtonFace,
    Color ButtonBorder
)
{
    public static readonly Theme Light = new(
        Background: SystemColors.Control,
        Foreground: SystemColors.ControlText,
        ButtonFace: SystemColors.ControlLightLight,
        ButtonBorder: SystemColors.ActiveBorder
    );

    public static readonly Theme Dark = new(
        Background: Color.FromArgb(45, 45, 45),
        Foreground: Color.FromArgb(241, 241, 241),
        ButtonFace: Color.FromArgb(64, 64, 64),
        ButtonBorder: Color.FromArgb(64, 64, 64)
    );

    public static Theme Current { get; set; } = Light;
}
