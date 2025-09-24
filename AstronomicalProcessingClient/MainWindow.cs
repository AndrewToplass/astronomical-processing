using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.ServiceModel;

using ServiceContracts;

namespace AstronomicalProcessingClient;

public partial class MainWindow : Form
{
    private readonly BindingList<CalculationResult> _calculations = [];

    private readonly ConnectionManager<IAstroContract> _connectionManager =
        new("net.pipe://localhost/AstroService");

    private readonly ComponentResourceManager _resources = new(typeof(MainWindow));

    /// <summary>
    /// Initializes a new instance of the <see cref="MainWindow"/> class.
    /// Sets up data bindings, default calculation, language, and theme.
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();
        datagridCalculations.DataSource = _calculations;

        ChangeLanguage(CultureInfo.CurrentCulture);
        this.ApplyTheme();
        menuitemThemeLight.Checked = true;
        menuitemThemeDark.Checked = false;
        menuitemThemeCustom.Checked = false;
    }

    /// <summary>
    /// Handles the click event for the Star Velocity calculation button.
    /// Performs the calculation and adds the result to the list.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void btnCalculateStarVelocity_Click(object sender, EventArgs e)
    {
        var observedWavelength = (double)numericObservedWavelength.Value;
        var restWavelength = (double)numericRestWavelength.Value;
        if (!_connectionManager.TryRun(
            c => c.StarVelocity(observedWavelength, restWavelength),
            out var result, out var exception)
        )
        {
            DisplayError(exception);
            return;
        }

        _calculations.Add(new()
        {
            Operation = CalculationOperation.StarVelocity,
            Result = result,
            Inputs = [observedWavelength, restWavelength]
        });
    }

    /// <summary>
    /// Handles the click event for the Star Distance calculation button.
    /// Performs the calculation and adds the result to the list.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void btnCalculateStarDistance_Click(object sender, EventArgs e)
    {
        var angle = (double)numericStarAngle.Value;
        if (!_connectionManager.TryRun(c => c.StarDistance(angle), out var result, out var exception))
        {
            DisplayError(exception);
            return;
        }

        _calculations.Add(new()
        {
            Operation = CalculationOperation.StarDistance,
            Result = result,
            Inputs = [angle]
        });
    }

    /// <summary>
    /// Handles the click event for the Temperature Conversion calculation button.
    /// Converts Celsius to Kelvin and adds the result to the list.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void btnCalculateTemperatureConversion_Click(object sender, EventArgs e)
    {
        var celsius = (double)numericTemperatureC.Value;
        if (!_connectionManager.TryRun(c => c.DegreesCelsiusToKelvin(celsius),
            out var result, out var exception)
        )
        {
            DisplayError(exception);
            return;
        }

        _calculations.Add(new()
        {
            Operation = CalculationOperation.TemperatureConversion,
            Result = result,
            Inputs = [celsius]
        });
    }

    /// <summary>
    /// Handles the click event for the Event Horizon calculation button.
    /// Calculates the event horizon for a black hole and adds the result to the list.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void btnCalculateEventHorizon_Click(object sender, EventArgs e)
    {
        var mass = (double)numericBlackholeMass.Value;
        if (!_connectionManager.TryRun(c => c.BlackholeEventHorizon(mass),
            out var result, out var exception)
        )
        {
            DisplayError(exception);
            return;
        }

        _calculations.Add(new()
        {
            Operation = CalculationOperation.EventHorizon,
            Result = result,
            Inputs = [mass]
        });
    }

    /// <summary>
    /// Changes the UI language and updates controls and menu items accordingly.
    /// </summary>
    /// <param name="cultureInfo">The culture to apply.</param>
    private void ChangeLanguage(CultureInfo cultureInfo)
    {
        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        foreach (Form form in Application.OpenForms)
        {
            form.SetLanguage(form.GetType());
        }

        // Apply checkbox states in language menu.
        switch (cultureInfo.TwoLetterISOLanguageName)
        {
            case "fr":
                menuitemEnglish.Checked = false;
                menuitemFrench.Checked = true;
                menuitemGerman.Checked = false;
                break;

            case "de":
                menuitemEnglish.Checked = false;
                menuitemFrench.Checked = false;
                menuitemGerman.Checked = true;
                break;

            case "en":
            default:
                menuitemEnglish.Checked = true;
                menuitemFrench.Checked = false;
                menuitemGerman.Checked = false;
                break;
        }

        // Refresh datagrid to update headers and value formatting.
        foreach (var column in datagridCalculations.Columns.Cast<DataGridViewColumn>())
        {
            _resources.ApplyResources(column, $"DataGrid.Headers.{column.Name}");
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }

    /// <summary>
    /// Handles the click event for the English language menu item.
    /// Sets the UI language to English.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void menuitemEnglish_Click(object sender, EventArgs e)
    {
        ChangeLanguage(new CultureInfo("en"));
    }

    /// <summary>
    /// Handles the click event for the German language menu item.
    /// Sets the UI language to German.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void menuitemGerman_Click(object sender, EventArgs e)
    {
        ChangeLanguage(new CultureInfo("de"));

    }

    /// <summary>
    /// Handles the click event for the French language menu item.
    /// Sets the UI language to French.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void menuitemFrench_Click(object sender, EventArgs e)
    {
        ChangeLanguage(new CultureInfo("fr"));
    }

    /// <summary>
    /// Displays an error message box based on the exception type.
    /// </summary>
    /// <param name="exception">The exception to display.</param>
    private void DisplayError(Exception? exception)
    {
        var errorTitle = _resources.GetString("Messagebox.ErrorTitle");
        var errorMessage = _resources.GetString(exception switch
        {
            EndpointNotFoundException => "Error.EndpointNotFound",
            CommunicationException => "Error.Communication",
            _ => "Error.Generic"
        });

        MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /// <summary>
    /// Handles the click event for the custom theme menu item.
    /// Opens the theme editor and applies the selected theme.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void menuitemThemeCustom_Click(object sender, EventArgs e)
    {
        var editor = new ThemeEditor
        {
            Theme = Theme.Current,
            Font = fontDialog.Font
        };

        if (editor.ShowDialog() != DialogResult.OK) return;

        menuitemThemeLight.Checked = false;
        menuitemThemeDark.Checked = false;
        menuitemThemeCustom.Checked = true;

        Theme.Current = editor.Theme;
        foreach (Form form in Application.OpenForms)
        {
            form.ApplyTheme();
        }
    }

    /// <summary>
    /// Handles the click event for the light theme menu item.
    /// Applies the light theme to all open forms.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void menuitemThemeLight_Click(object sender, EventArgs e)
    {
        menuitemThemeLight.Checked = true;
        menuitemThemeDark.Checked = false;
        menuitemThemeCustom.Checked = false;

        Theme.Current = Theme.Light;
        foreach (Form form in Application.OpenForms)
        {
            form.ApplyTheme();
        }
    }

    /// <summary>
    /// Handles the click event for the dark theme menu item.
    /// Applies the dark theme to all open forms.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void menuitemThemeDark_Click(object sender, EventArgs e)
    {
        menuitemThemeLight.Checked = false;
        menuitemThemeDark.Checked = true;
        menuitemThemeCustom.Checked = false;

        Theme.Current = Theme.Dark;
        foreach (Form form in Application.OpenForms)
        {
            form.ApplyTheme();
        }
    }

    /// <summary>
    /// Handles the click event for the font selection menu item.
    /// Opens the font dialog and applies the selected font to all open forms.
    /// </summary>
    /// <param name="sender">The event source.</param>
    /// <param name="e">Event arguments.</param>
    private void menuitemFont_Click(object sender, EventArgs e)
    {
        if (fontDialog.ShowDialog() != DialogResult.OK) return;

        foreach (Form form in Application.OpenForms)
        {
            form.ApplyFont(fontDialog.Font);
        }
    }
}
