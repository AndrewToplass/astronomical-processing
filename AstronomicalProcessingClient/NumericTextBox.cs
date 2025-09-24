using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;

namespace AstronomicalProcessingClient;
/// <summary>
/// A TextBox control that only accepts numeric input and enforces minimum and maximum value constraints.
/// </summary>
internal class NumericTextBox : TextBox
{
    private double _min = double.MinValue;
    private double _max = double.MaxValue;

    /// <summary>
    /// Gets or sets the minimum allowed value for the control.
    /// </summary>
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

    /// <summary>
    /// Gets or sets the maximum allowed value for the control.
    /// </summary>
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

    /// <summary>
    /// Gets or sets the current numeric value of the control.
    /// The value is clamped between <see cref="Min"/> and <see cref="Max"/>.
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double Value
    {
        get => _value;
        set
        {
            _value = Math.Clamp(value, Min, Max);
            Text = Value.ToString();
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NumericTextBox"/> class with a default value of 0.
    /// </summary>
    public NumericTextBox()
    {
        Value = 0;
    }

    /// <summary>
    /// Handles the event when the control loses focus.
    /// Parses the text and updates the value, or reverts to the last valid value if parsing fails.
    /// </summary>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    protected override void OnLostFocus(EventArgs e)
    {
        base.OnLostFocus(e);

        if (double.TryParse(Text, out double newValue))
        {
            Value = newValue;
        }
        else
        {
            // Revert to the last valid value if parsing fails
            Text = _value.ToString();
            SelectionStart = Text.Length; // Move cursor to the end
        }
    }

    /// <summary>
    /// Handles the key press event to restrict input to valid numeric characters.
    /// </summary>
    /// <param name="e">A <see cref="KeyPressEventArgs"/> that contains the event data.</param>
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

    /// <summary>
    /// Updates the displayed text to match the current value.
    /// </summary>
    public override void Refresh()
    {
        Text = Value.ToString();
        base.Refresh();
    }
}
