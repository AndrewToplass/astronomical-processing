using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalProcessingClient;

/// <summary>
/// A form that allows users to edit and preview UI theme colors.
/// </summary>
public partial class ThemeEditor : Form
{
    private Theme _theme = Theme.Current;

    /// <summary>
    /// Gets or sets the theme being edited in the dialog.
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Theme Theme
    {
        get => _theme;
        set
        {
            _theme = value;
            UpdateColorPreviews();
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ThemeEditor"/> class.
    /// Sets up language, theme, and color previews.
    /// </summary>
    public ThemeEditor()
    {
        InitializeComponent();
        this.SetLanguage();
        this.ApplyTheme();
        UpdateColorPreviews();
    }

    /// <summary>
    /// Updates the color preview boxes to reflect the current theme.
    /// </summary>
    private void UpdateColorPreviews()
    {
        boxBackgroundColor.BackColor =  Theme.Background;
        boxForegroundColor.BackColor =  Theme.Foreground;
        boxButtonColor.BackColor =  Theme.ButtonFace;
    }

    /// <summary>
    /// Handles the click event for the foreground color button.
    /// Opens a color dialog and updates the theme's foreground color.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void buttonForegroundColor_Click(object sender, EventArgs e)
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            Theme = Theme with { Foreground = colorDialog.Color };
        }
    }

    /// <summary>
    /// Handles the click event for the background color button.
    /// Opens a color dialog and updates the theme's background color.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void buttonBackgroundColor_Click(object sender, EventArgs e)
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            Theme = Theme with { Background = colorDialog.Color };
        }
    }

    /// <summary>
    /// Handles the click event for the button face color button.
    /// Opens a color dialog and updates the theme's button face color.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void buttonButtonColor_Click(object sender, EventArgs e)
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            Theme = Theme with { ButtonFace = colorDialog.Color };
        }
    }

    /// <summary>
    /// Handles the click event for the Cancel button.
    /// Closes the dialog without saving changes.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    /// <summary>
    /// Handles the click event for the OK button.
    /// Closes the dialog and saves changes.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void buttonOk_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}
