using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        ChangeLanguage(CultureInfo.CurrentCulture);

        //comboLanguage.Items.AddRange(["en-US", "fr-FR", "de-DE"]);
        //comboLanguage.SelectedIndex = 0;
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

        var resources = new ComponentResourceManager(typeof(MainWindow));
        SuspendLayout();
        foreach (Control control in GetAllControls(this))
        {
            resources.ApplyResources(control, control.Name);
        }

        foreach (ToolStripItem item in GetAllToolStripItems(toolStrip))
        {
            if (item.Name is null) continue;
            resources.ApplyResources(item, item.Name);
        }

        ResumeLayout();
    }

    private IEnumerable<ToolStripItem> GetAllToolStripItems(ToolStrip item)
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

    private IEnumerable<Control> GetAllControls(Control control)
    {
        var controls = control.Controls.Cast<Control>();
        return controls
            .SelectMany(GetAllControls)
            .Concat(controls);
    }

    private void menuitemEnglish_Click(object sender, EventArgs e)
    {
        ChangeLanguage(new CultureInfo("en-US"));
    }

    private void menuitemGerman_Click(object sender, EventArgs e)
    {
        ChangeLanguage(new CultureInfo("de-DE"));

    }

    private void menuitemFrench_Click(object sender, EventArgs e)
    {
        ChangeLanguage(new CultureInfo("fr-FR"));
    }
}
