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

        //comboLanguage.Items.AddRange(["en-US", "fr-FR", "de-DE"]);
        //comboLanguage.SelectedIndex = 0;
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
        Thread.CurrentThread.CurrentCulture = cultureInfo;
        Thread.CurrentThread.CurrentUICulture = cultureInfo;

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

        SuspendLayout();
        foreach (Control control in GetAllControls(this))
        {
            _resources.ApplyResources(control, control.Name);
        }

        foreach (ToolStripItem item in GetAllToolStripItems(toolStrip))
        {
            if (item.Name is null) continue;
            _resources.ApplyResources(item, item.Name);
        }

        foreach (var column in datagridCalculations.Columns.Cast<DataGridViewColumn>())
        {
            _resources.ApplyResources(column, $"DataGrid.Headers.{column.Name}");
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        datagridCalculations.Refresh();

        ResumeLayout();
    }

    private static IEnumerable<ToolStripItem> GetAllToolStripItems(ToolStrip item)
    {
        return item.Items.Cast<ToolStripItem>().SelectMany(GetItems);

        static IEnumerable<ToolStripItem> GetItems(ToolStripItem item)
        {
            List<ToolStripItem> items = [item];

            switch (item)
            {
                case ToolStripMenuItem menuItem:
                    foreach (ToolStripItem i in menuItem.DropDownItems)
                        items.AddRange(GetItems(i));
                    break;
                case ToolStripSplitButton splitButton:
                    foreach (ToolStripItem i in splitButton.DropDownItems)
                        items.AddRange(GetItems(i));
                    break;
                case ToolStripDropDownButton dropDown:
                    foreach (ToolStripItem i in dropDown.DropDownItems)
                        items.AddRange(GetItems(i));
                    break;
            }

            return items;
        }
    }

    private static IEnumerable<Control> GetAllControls(Control control)
    {
        var controls = control.Controls.Cast<Control>();
        return controls
            .SelectMany(GetAllControls)
            .Concat(controls);
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
}
