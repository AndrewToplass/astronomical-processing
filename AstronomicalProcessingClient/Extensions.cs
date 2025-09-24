using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AstronomicalProcessingClient.Properties;

namespace AstronomicalProcessingClient;
internal static class Extensions
{
    /// <summary>
    /// Finds all descendant controls of the specified control, recursively.
    /// </summary>
    /// <param name="control">The root control to search from.</param>
    /// <returns>An enumerable of all descendant controls.</returns>
    public static IEnumerable<Control> FindAllDescendants(this Control control)
    {
        var controls = control.Controls.Cast<Control>();
        return controls
            .SelectMany(FindAllDescendants)
            .Concat(controls);
    }

    /// <summary>
    /// Finds all items within a ToolStrip, including nested items in drop-downs.
    /// </summary>
    /// <param name="toolStrip">The ToolStrip to search.</param>
    /// <returns>An enumerable of all ToolStripItems, including nested items.</returns>
    public static IEnumerable<ToolStripItem> FindAllItems(this ToolStrip toolStrip)
    {
        return toolStrip.Items.Cast<ToolStripItem>().SelectMany(GetItems);

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

    /// <summary>
    /// Sets the language for the specified form using resources for localization.
    /// </summary>
    /// <typeparam name="T">The type of the form.</typeparam>
    /// <param name="control">The form to localize.</param>
    /// <param name="cultureInfo">The culture to apply. If null, uses the current UI culture.</param>
    public static void SetLanguage<T>(
        this T control,
        CultureInfo? cultureInfo = null
    ) where T : Form
    {
        control.SetLanguage(typeof(T), cultureInfo);
    }

    /// <summary>
    /// Sets the language for the specified control and its descendants using resources for localization.
    /// </summary>
    /// <param name="control">The control to localize.</param>
    /// <param name="type">The type used to locate resources.</param>
    /// <param name="cultureInfo">The culture to apply. If null, uses the current UI culture.</param>
    public static void SetLanguage(
        this Control control,
        Type type,
        CultureInfo? cultureInfo = null
    )
    {
        var resources = new ComponentResourceManager(type);

        cultureInfo ??= CultureInfo.CurrentUICulture;

        control.SuspendLayout();
        foreach (var child in control.FindAllDescendants())
        {
            resources.ApplyResources(child, child.Name, cultureInfo);
            child.Refresh();

            if (child is ToolStrip toolStrip)
            {
                foreach (var item in toolStrip.FindAllItems())
                {
                    if (item.Name is null) continue;
                    resources.ApplyResources(item, item.Name, cultureInfo);
                }
            }
        }

        control.ResumeLayout();
    }

    /// <summary>
    /// Applies the current theme to the specified control and all its descendants.
    /// </summary>
    /// <param name="control">The control to apply the theme to.</param>
    public static void ApplyTheme(this Control control)
    {
        var theme = Theme.Current;

        control.BackColor = theme.Background;
        control.ForeColor = theme.Foreground;
        foreach (var child in control.FindAllDescendants())
        {
            switch (child)
            {
                case Button btn:
                    btn.BackColor = theme.ButtonFace;
                    btn.ForeColor = theme.Foreground;

                    btn.UseVisualStyleBackColor = false;
                    btn.FlatStyle = FlatStyle.Flat;

                    btn.FlatAppearance.BorderColor = theme.ButtonBorder;
                    break;

                case TextBox textBox:
                    textBox.BackColor = theme.ButtonFace;
                    textBox.ForeColor = theme.Foreground;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    break;

                case ComboBox or ListBox or NumericUpDown:
                    child.BackColor = theme.ButtonFace;
                    child.ForeColor = theme.Foreground;
                    break;

                case DataGridView dgv:
                    dgv.BackgroundColor = theme.Background;
                    dgv.DefaultCellStyle.BackColor = theme.Background;
                    dgv.DefaultCellStyle.ForeColor = theme.Foreground;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = theme.ButtonFace;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = theme.Foreground;
                    dgv.RowHeadersDefaultCellStyle.BackColor = theme.ButtonFace;
                    dgv.RowHeadersDefaultCellStyle.ForeColor = theme.Foreground;
                    dgv.Refresh();
                    break;

                case ToolStrip toolStrip:
                    toolStrip.BackColor = theme.ButtonFace;
                    toolStrip.ForeColor = theme.Foreground;
                    foreach (var item in toolStrip.FindAllItems())
                    {
                        item.BackColor = theme.ButtonFace;
                        item.ForeColor = theme.Foreground;
                    }
                    break;

                default:
                    child.BackColor = theme.Background;
                    child.ForeColor = theme.Foreground;
                    break;
            }
        }
    }

    /// <summary>
    /// Applies the specified font to the control and all its descendants.
    /// </summary>
    /// <param name="control">The control to apply the font to.</param>
    /// <param name="font">The font to apply.</param>
    public static void ApplyFont(this Control control, Font font)
    {
        control.Font = font;
        foreach (var child in control.FindAllDescendants())
        {
            switch (child)
            {
                case ToolStrip toolStrip:
                    toolStrip.Font = font;
                    break;
                default:
                    child.Font = font;
                    break;
            }
        }
    }
}
