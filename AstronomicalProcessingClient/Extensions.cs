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
    public static IEnumerable<Control> FindAllDescendants(this Control control)
    {
        var controls = control.Controls.Cast<Control>();
        return controls
            .SelectMany(FindAllDescendants)
            .Concat(controls);
    }

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

    public static void SetLanguage<T>(
        this T control,
        CultureInfo? cultureInfo = null
    ) where T : Form
    {
        control.SetLanguage(typeof(T), cultureInfo);
    }

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
