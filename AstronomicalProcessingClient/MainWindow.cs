using System.ComponentModel;
using System.Data;
using System.Globalization;

namespace AstronomicalProcessingClient;

public partial class MainWindow : Form
{
    private readonly BindingList<CalculationResult> _calculations = [];

    public MainWindow()
    {
        InitializeComponent();
        datagridCalculations.DataSource = _calculations;
        _calculations.Add(new()
        {
            Operation = CalculationOperation.StarVelocity,
            Result = 123.45
        });

        comboLanguage.Items.AddRange(["en-US", "fr-FR", "de-DE"]);
    }

    private void btnCalculateStarVelocity_Click(object sender, EventArgs e)
    {

    }

    private void btnCalculateStarDistance_Click(object sender, EventArgs e)
    {

    }

    private void btnCalculateTemperatureConversion_Click(object sender, EventArgs e)
    {

    }

    private void btnCalculateEventHorizon_Click(object sender, EventArgs e)
    {

    }

    private void ChangeLanguage(CultureInfo cultureInfo)
    {
        var resources = new ComponentResourceManager(typeof(MainWindow));
        foreach (Control control in Controls)
        {
            resources.ApplyResources(control, control.Name, cultureInfo);
        }
    }

    private void comboLanguage_SelectedChanged(object sender, EventArgs e)
    {
        var code = comboLanguage.SelectedItem as string;
        var cultureInfo = new CultureInfo(code ?? "en-US");
        ChangeLanguage(cultureInfo);
    }
}
