namespace AstronomicalProcessingClient;

partial class ThemeEditor
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        colorDialog = new ColorDialog();
        boxForegroundColor = new PictureBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        boxButtonColor = new PictureBox();
        boxBackgroundColor = new PictureBox();
        buttonBackgroundColor = new Button();
        buttonButtonColor = new Button();
        buttonForegroundColor = new Button();
        tableLayoutPanel2 = new TableLayoutPanel();
        buttonCancel = new Button();
        buttonOk = new Button();
        ((System.ComponentModel.ISupportInitialize)boxForegroundColor).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)boxButtonColor).BeginInit();
        ((System.ComponentModel.ISupportInitialize)boxBackgroundColor).BeginInit();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // boxForegroundColor
        // 
        boxForegroundColor.InitialImage = null;
        boxForegroundColor.Location = new Point(92, 3);
        boxForegroundColor.Name = "boxForegroundColor";
        boxForegroundColor.Size = new Size(48, 48);
        boxForegroundColor.TabIndex = 0;
        boxForegroundColor.TabStop = false;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(boxButtonColor, 1, 2);
        tableLayoutPanel1.Controls.Add(boxBackgroundColor, 1, 1);
        tableLayoutPanel1.Controls.Add(buttonBackgroundColor, 0, 1);
        tableLayoutPanel1.Controls.Add(boxForegroundColor, 1, 0);
        tableLayoutPanel1.Controls.Add(buttonButtonColor, 0, 2);
        tableLayoutPanel1.Controls.Add(buttonForegroundColor, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(285, 276);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // boxButtonColor
        // 
        boxButtonColor.InitialImage = null;
        boxButtonColor.Location = new Point(92, 111);
        boxButtonColor.Name = "boxButtonColor";
        boxButtonColor.Size = new Size(48, 48);
        boxButtonColor.TabIndex = 5;
        boxButtonColor.TabStop = false;
        // 
        // boxBackgroundColor
        // 
        boxBackgroundColor.InitialImage = null;
        boxBackgroundColor.Location = new Point(92, 57);
        boxBackgroundColor.Name = "boxBackgroundColor";
        boxBackgroundColor.Size = new Size(48, 48);
        boxBackgroundColor.TabIndex = 4;
        boxBackgroundColor.TabStop = false;
        // 
        // buttonBackgroundColor
        // 
        buttonBackgroundColor.Anchor = AnchorStyles.Left;
        buttonBackgroundColor.AutoSize = true;
        buttonBackgroundColor.Location = new Point(3, 68);
        buttonBackgroundColor.Name = "buttonBackgroundColor";
        buttonBackgroundColor.Size = new Size(81, 25);
        buttonBackgroundColor.TabIndex = 2;
        buttonBackgroundColor.Text = "Background";
        buttonBackgroundColor.UseVisualStyleBackColor = true;
        buttonBackgroundColor.Click += buttonBackgroundColor_Click;
        // 
        // buttonButtonColor
        // 
        buttonButtonColor.Anchor = AnchorStyles.Left;
        buttonButtonColor.AutoSize = true;
        buttonButtonColor.Location = new Point(3, 122);
        buttonButtonColor.Name = "buttonButtonColor";
        buttonButtonColor.Size = new Size(57, 25);
        buttonButtonColor.TabIndex = 3;
        buttonButtonColor.Text = "Button";
        buttonButtonColor.UseVisualStyleBackColor = true;
        buttonButtonColor.Click += buttonButtonColor_Click;
        // 
        // buttonForegroundColor
        // 
        buttonForegroundColor.Anchor = AnchorStyles.Left;
        buttonForegroundColor.AutoSize = true;
        buttonForegroundColor.FlatStyle = FlatStyle.System;
        buttonForegroundColor.Location = new Point(3, 14);
        buttonForegroundColor.Name = "buttonForegroundColor";
        buttonForegroundColor.Size = new Size(83, 25);
        buttonForegroundColor.TabIndex = 1;
        buttonForegroundColor.Text = "Foreground";
        buttonForegroundColor.UseVisualStyleBackColor = true;
        buttonForegroundColor.Click += buttonForegroundColor_Click;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
        tableLayoutPanel2.Controls.Add(buttonOk, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 165);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(279, 108);
        tableLayoutPanel2.TabIndex = 6;
        // 
        // buttonCancel
        // 
        buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonCancel.AutoSize = true;
        buttonCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        buttonCancel.Location = new Point(201, 80);
        buttonCancel.MinimumSize = new Size(75, 25);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(75, 25);
        buttonCancel.TabIndex = 0;
        buttonCancel.Text = "Cancel";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += buttonCancel_Click;
        // 
        // buttonOk
        // 
        buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonOk.AutoSize = true;
        buttonOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        buttonOk.Location = new Point(120, 80);
        buttonOk.MinimumSize = new Size(75, 25);
        buttonOk.Name = "buttonOk";
        buttonOk.Size = new Size(75, 25);
        buttonOk.TabIndex = 1;
        buttonOk.Text = "OK";
        buttonOk.Click += buttonOk_Click;
        // 
        // ThemeEditor
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(285, 276);
        Controls.Add(tableLayoutPanel1);
        FormBorderStyle = FormBorderStyle.SizableToolWindow;
        Name = "ThemeEditor";
        Text = "Theme Editor";
        ((System.ComponentModel.ISupportInitialize)boxForegroundColor).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)boxButtonColor).EndInit();
        ((System.ComponentModel.ISupportInitialize)boxBackgroundColor).EndInit();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.ColorDialog colorDialog;
    private PictureBox boxForegroundColor;
    private TableLayoutPanel tableLayoutPanel1;
    private PictureBox boxButtonColor;
    private PictureBox boxBackgroundColor;
    private Button buttonBackgroundColor;
    private Button buttonButtonColor;
    private Button buttonForegroundColor;
    private TableLayoutPanel tableLayoutPanel2;
    private Button buttonCancel;
    private Button buttonOk;
}