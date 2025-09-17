using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AstronomicalProcessingClient;
internal class NumericTextBox : TextBox
{
    private double _min = double.MinValue;
    private double _max = double.MaxValue;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double Min
    {
        get => _min;
        set
        {
            _min = value;
            if (_value < _min)
            {
                Value = _min; // This will also update the Text
            }
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double Max
    {
        get => _max;
        set
        {
            _max = value;
            if (_value > _max)
            {
                Value = _max; // This will also update the Text
            }
        }
    }

    private double _value;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double Value
    {
        get => _value;
        set
        {
            _value = value;
            Text = Value.ToString();
        }
    }

    public NumericTextBox()
    {
        Value = 0;
    }

    protected override void OnLostFocus(EventArgs e)
    {
        base.OnLostFocus(e);

        if (double.TryParse(Text, out double newValue))
        {
            Value = Math.Clamp(newValue, Min, Max);
        }
        else
        {
            // Revert to the last valid value if parsing fails
            Text = _value.ToString();
            SelectionStart = Text.Length; // Move cursor to the end
        }
    }

    //protected override void OnTextChanged(EventArgs e)
    //{
    //    base.OnTextChanged(e);

    //    if (double.TryParse(Text, out double newValue))
    //    {
    //        _value = newValue;
    //    }
    //    else
    //    {
    //        // Revert to the last valid value if parsing fails
    //        Text = _value.ToString();
    //        SelectionStart = Text.Length; // Move cursor to the end
    //    }
    //}

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);

        // Allow control characters (e.g., backspace)
        if (char.IsControl(e.KeyChar))
        {
            return;
        }

        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != 'e' && e.KeyChar != '-')
        {
            e.Handled = true; // Invalid character
            return;
        }
    }
}
