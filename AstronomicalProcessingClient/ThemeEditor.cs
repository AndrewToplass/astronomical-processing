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

public partial class ThemeEditor : Form
{
    private Theme _theme = Theme.Current;

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

    public ThemeEditor()
    {
        InitializeComponent();
        this.SetLanguage();
        this.ApplyTheme();
        UpdateColorPreviews();
    }

    private void UpdateColorPreviews()
    {
        boxBackgroundColor.BackColor =  Theme.Background;
        boxForegroundColor.BackColor =  Theme.Foreground;
        boxButtonColor.BackColor =  Theme.ButtonFace;
    }

    private void buttonForegroundColor_Click(object sender, EventArgs e)
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            Theme = Theme with { Foreground = colorDialog.Color };
        }
    }

    private void buttonBackgroundColor_Click(object sender, EventArgs e)
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            Theme = Theme with { Background = colorDialog.Color };
        }
    }

    private void buttonButtonColor_Click(object sender, EventArgs e)
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            Theme = Theme with { ButtonFace = colorDialog.Color };
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}
