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

    public MainWindow()
    {
        InitializeComponent();
        datagridCalculations.DataSource = _calculations;

        _calculations.Add(new()
        {
            Operation = CalculationOperation.StarVelocity,
            Result = 123.45,
            Inputs = [1.0, 2.0]
        });

        ChangeLanguage(CultureInfo.CurrentCulture);
        this.ApplyTheme();
        menuitemThemeLight.Checked = true;
        menuitemThemeDark.Checked = false;
        menuitemThemeCustom.Checked = false;
    }

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

        datagridCalculations.Refresh();
    }

    private void menuitemEnglish_Click(object sender, EventArgs e)
    {
        ChangeLanguage(new CultureInfo("en"));
    }

    private void menuitemGerman_Click(object sender, EventArgs e)
    {
        ChangeLanguage(new CultureInfo("de"));

    }

    private void menuitemFrench_Click(object sender, EventArgs e)
    {
        ChangeLanguage(new CultureInfo("fr"));
    }

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

    private void menuitemFont_Click(object sender, EventArgs e)
    {
        if (fontDialog.ShowDialog() != DialogResult.OK) return;

        foreach (Form form in Application.OpenForms)
        {
            form.ApplyFont(fontDialog.Font);
        }
    }
}
