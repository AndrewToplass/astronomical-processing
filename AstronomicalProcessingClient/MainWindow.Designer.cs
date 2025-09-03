namespace AstronomicalProcessingClient
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            colorDialog = new ColorDialog();
            fontDialog = new FontDialog();
            statusStrip = new StatusStrip();
            labelStatus = new ToolStripStatusLabel();
            toolStrip = new ToolStrip();
            labelLanguage = new ToolStripLabel();
            comboLanguage = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            menuTheme = new ToolStripDropDownButton();
            menuitemThemeLight = new ToolStripMenuItem();
            menuitemThemeDark = new ToolStripMenuItem();
            menuitemThemeCustom = new ToolStripMenuItem();
            menuitemFont = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBoxEventHorizon = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            flowLayoutPanel10 = new FlowLayoutPanel();
            flowLayoutPanel11 = new FlowLayoutPanel();
            labelBlackholeMass = new Label();
            numericBlackholeMass = new NumericUpDown();
            btnCalculateEventHorizon = new Button();
            groupBoxTemperatureConversion = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            labelTemperatureC = new Label();
            numericTemperatureC = new NumericUpDown();
            btnCalculateTemperatureConversion = new Button();
            groupBoxStarVelocity = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            labelObservedWavelength = new Label();
            numericObservedWavelength = new NumericUpDown();
            flowLayoutPanel3 = new FlowLayoutPanel();
            labelRestWavelength = new Label();
            numericRestWavelength = new NumericUpDown();
            btnCalculateStarVelocity = new Button();
            datagridCalculations = new DataGridView();
            groupBoxStarDistance = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            labelStarAngle = new Label();
            numericStarAngle = new NumericUpDown();
            btnCalculateStarDistance = new Button();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxEventHorizon.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            flowLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericBlackholeMass).BeginInit();
            groupBoxTemperatureConversion.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTemperatureC).BeginInit();
            groupBoxStarVelocity.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericObservedWavelength).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericRestWavelength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridCalculations).BeginInit();
            groupBoxStarDistance.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericStarAngle).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { labelStatus });
            statusStrip.Location = new Point(0, 639);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(584, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip";
            // 
            // labelStatus
            // 
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(118, 17);
            labelStatus.Text = "toolStripStatusLabel1";
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { labelLanguage, comboLanguage, toolStripSeparator1, menuTheme, menuitemFont });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(584, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // labelLanguage
            // 
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(62, 22);
            labelLanguage.Text = "Language:";
            // 
            // comboLanguage
            // 
            comboLanguage.Name = "comboLanguage";
            comboLanguage.Size = new Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // menuTheme
            // 
            menuTheme.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menuTheme.DropDownItems.AddRange(new ToolStripItem[] { menuitemThemeLight, menuitemThemeDark, menuitemThemeCustom });
            menuTheme.Image = (Image)resources.GetObject("menuTheme.Image");
            menuTheme.ImageTransparentColor = Color.Magenta;
            menuTheme.Name = "menuTheme";
            menuTheme.Size = new Size(57, 22);
            menuTheme.Text = "Theme";
            // 
            // menuitemThemeLight
            // 
            menuitemThemeLight.CheckOnClick = true;
            menuitemThemeLight.Name = "menuitemThemeLight";
            menuitemThemeLight.Size = new Size(116, 22);
            menuitemThemeLight.Text = "Light";
            // 
            // menuitemThemeDark
            // 
            menuitemThemeDark.CheckOnClick = true;
            menuitemThemeDark.Name = "menuitemThemeDark";
            menuitemThemeDark.Size = new Size(116, 22);
            menuitemThemeDark.Text = "Dark";
            // 
            // menuitemThemeCustom
            // 
            menuitemThemeCustom.CheckOnClick = true;
            menuitemThemeCustom.Name = "menuitemThemeCustom";
            menuitemThemeCustom.Size = new Size(116, 22);
            menuitemThemeCustom.Text = "Custom";
            // 
            // menuitemFont
            // 
            menuitemFont.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menuitemFont.Image = (Image)resources.GetObject("menuitemFont.Image");
            menuitemFont.ImageTransparentColor = Color.Magenta;
            menuitemFont.Name = "menuitemFont";
            menuitemFont.Size = new Size(44, 22);
            menuitemFont.Text = "Font...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBoxEventHorizon, 0, 3);
            tableLayoutPanel1.Controls.Add(groupBoxTemperatureConversion, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBoxStarVelocity, 0, 0);
            tableLayoutPanel1.Controls.Add(datagridCalculations, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBoxStarDistance, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(560, 608);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBoxEventHorizon
            // 
            groupBoxEventHorizon.Controls.Add(tableLayoutPanel5);
            groupBoxEventHorizon.Dock = DockStyle.Fill;
            groupBoxEventHorizon.Location = new Point(3, 459);
            groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            groupBoxEventHorizon.Size = new Size(274, 146);
            groupBoxEventHorizon.TabIndex = 5;
            groupBoxEventHorizon.TabStop = false;
            groupBoxEventHorizon.Text = "Blackhole Event Horizon";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(flowLayoutPanel10, 0, 0);
            tableLayoutPanel5.Controls.Add(btnCalculateEventHorizon, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(268, 124);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel10.AutoSize = true;
            flowLayoutPanel10.Controls.Add(flowLayoutPanel11);
            flowLayoutPanel10.Location = new Point(3, 37);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(181, 50);
            flowLayoutPanel10.TabIndex = 3;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.AutoSize = true;
            flowLayoutPanel11.Controls.Add(labelBlackholeMass);
            flowLayoutPanel11.Controls.Add(numericBlackholeMass);
            flowLayoutPanel11.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel11.Location = new Point(3, 3);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(126, 44);
            flowLayoutPanel11.TabIndex = 0;
            flowLayoutPanel11.WrapContents = false;
            // 
            // labelBlackholeMass
            // 
            labelBlackholeMass.AutoSize = true;
            labelBlackholeMass.Location = new Point(3, 0);
            labelBlackholeMass.Name = "labelBlackholeMass";
            labelBlackholeMass.Size = new Size(58, 15);
            labelBlackholeMass.TabIndex = 0;
            labelBlackholeMass.Text = "Mass (kg)";
            // 
            // numericBlackholeMass
            // 
            numericBlackholeMass.Location = new Point(3, 18);
            numericBlackholeMass.Name = "numericBlackholeMass";
            numericBlackholeMass.Size = new Size(120, 23);
            numericBlackholeMass.TabIndex = 1;
            // 
            // btnCalculateEventHorizon
            // 
            btnCalculateEventHorizon.Anchor = AnchorStyles.Right;
            btnCalculateEventHorizon.Location = new Point(190, 50);
            btnCalculateEventHorizon.Name = "btnCalculateEventHorizon";
            btnCalculateEventHorizon.Size = new Size(75, 23);
            btnCalculateEventHorizon.TabIndex = 0;
            btnCalculateEventHorizon.Text = "Calculate";
            btnCalculateEventHorizon.UseVisualStyleBackColor = true;
            // 
            // groupBoxTemperatureConversion
            // 
            groupBoxTemperatureConversion.Controls.Add(tableLayoutPanel4);
            groupBoxTemperatureConversion.Dock = DockStyle.Fill;
            groupBoxTemperatureConversion.Location = new Point(3, 307);
            groupBoxTemperatureConversion.Name = "groupBoxTemperatureConversion";
            groupBoxTemperatureConversion.Size = new Size(274, 146);
            groupBoxTemperatureConversion.TabIndex = 4;
            groupBoxTemperatureConversion.TabStop = false;
            groupBoxTemperatureConversion.Text = "Temperature Conversion";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(flowLayoutPanel7, 0, 0);
            tableLayoutPanel4.Controls.Add(btnCalculateTemperatureConversion, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(268, 124);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel7.Location = new Point(3, 37);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(181, 50);
            flowLayoutPanel7.TabIndex = 3;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.Controls.Add(labelTemperatureC);
            flowLayoutPanel8.Controls.Add(numericTemperatureC);
            flowLayoutPanel8.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel8.Location = new Point(3, 3);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(126, 44);
            flowLayoutPanel8.TabIndex = 0;
            flowLayoutPanel8.WrapContents = false;
            // 
            // labelTemperatureC
            // 
            labelTemperatureC.AutoSize = true;
            labelTemperatureC.Location = new Point(3, 0);
            labelTemperatureC.Name = "labelTemperatureC";
            labelTemperatureC.Size = new Size(98, 15);
            labelTemperatureC.TabIndex = 0;
            labelTemperatureC.Text = "Temperature (°C)";
            // 
            // numericTemperatureC
            // 
            numericTemperatureC.Location = new Point(3, 18);
            numericTemperatureC.Name = "numericTemperatureC";
            numericTemperatureC.Size = new Size(120, 23);
            numericTemperatureC.TabIndex = 1;
            // 
            // btnCalculateTemperatureConversion
            // 
            btnCalculateTemperatureConversion.Anchor = AnchorStyles.Right;
            btnCalculateTemperatureConversion.Location = new Point(190, 50);
            btnCalculateTemperatureConversion.Name = "btnCalculateTemperatureConversion";
            btnCalculateTemperatureConversion.Size = new Size(75, 23);
            btnCalculateTemperatureConversion.TabIndex = 0;
            btnCalculateTemperatureConversion.Text = "Calculate";
            btnCalculateTemperatureConversion.UseVisualStyleBackColor = true;
            // 
            // groupBoxStarVelocity
            // 
            groupBoxStarVelocity.Controls.Add(tableLayoutPanel2);
            groupBoxStarVelocity.Dock = DockStyle.Fill;
            groupBoxStarVelocity.Location = new Point(3, 3);
            groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            groupBoxStarVelocity.Size = new Size(274, 146);
            groupBoxStarVelocity.TabIndex = 3;
            groupBoxStarVelocity.TabStop = false;
            groupBoxStarVelocity.Text = "Star Velocity";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCalculateStarVelocity, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(268, 124);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Location = new Point(3, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(181, 100);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(labelObservedWavelength);
            flowLayoutPanel2.Controls.Add(numericObservedWavelength);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(126, 44);
            flowLayoutPanel2.TabIndex = 0;
            flowLayoutPanel2.WrapContents = false;
            // 
            // labelObservedWavelength
            // 
            labelObservedWavelength.AutoSize = true;
            labelObservedWavelength.Location = new Point(3, 0);
            labelObservedWavelength.Name = "labelObservedWavelength";
            labelObservedWavelength.Size = new Size(79, 15);
            labelObservedWavelength.TabIndex = 0;
            labelObservedWavelength.Text = "Observed (m)";
            // 
            // numericObservedWavelength
            // 
            numericObservedWavelength.Location = new Point(3, 18);
            numericObservedWavelength.Name = "numericObservedWavelength";
            numericObservedWavelength.Size = new Size(120, 23);
            numericObservedWavelength.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(labelRestWavelength);
            flowLayoutPanel3.Controls.Add(numericRestWavelength);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 53);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(126, 44);
            flowLayoutPanel3.TabIndex = 1;
            flowLayoutPanel3.WrapContents = false;
            // 
            // labelRestWavelength
            // 
            labelRestWavelength.AutoSize = true;
            labelRestWavelength.Location = new Point(3, 0);
            labelRestWavelength.Name = "labelRestWavelength";
            labelRestWavelength.Size = new Size(51, 15);
            labelRestWavelength.TabIndex = 0;
            labelRestWavelength.Text = "Rest (m)";
            // 
            // numericRestWavelength
            // 
            numericRestWavelength.Location = new Point(3, 18);
            numericRestWavelength.Name = "numericRestWavelength";
            numericRestWavelength.Size = new Size(120, 23);
            numericRestWavelength.TabIndex = 1;
            // 
            // btnCalculateStarVelocity
            // 
            btnCalculateStarVelocity.Anchor = AnchorStyles.Right;
            btnCalculateStarVelocity.Location = new Point(190, 50);
            btnCalculateStarVelocity.Name = "btnCalculateStarVelocity";
            btnCalculateStarVelocity.Size = new Size(75, 23);
            btnCalculateStarVelocity.TabIndex = 0;
            btnCalculateStarVelocity.Text = "Calculate";
            btnCalculateStarVelocity.UseVisualStyleBackColor = true;
            // 
            // datagridCalculations
            // 
            datagridCalculations.AllowUserToDeleteRows = false;
            datagridCalculations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridCalculations.Dock = DockStyle.Fill;
            datagridCalculations.Location = new Point(283, 3);
            datagridCalculations.Name = "datagridCalculations";
            datagridCalculations.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(datagridCalculations, 4);
            datagridCalculations.Size = new Size(274, 602);
            datagridCalculations.TabIndex = 0;
            // 
            // groupBoxStarDistance
            // 
            groupBoxStarDistance.Controls.Add(tableLayoutPanel3);
            groupBoxStarDistance.Dock = DockStyle.Fill;
            groupBoxStarDistance.Location = new Point(3, 155);
            groupBoxStarDistance.Name = "groupBoxStarDistance";
            groupBoxStarDistance.Size = new Size(274, 146);
            groupBoxStarDistance.TabIndex = 2;
            groupBoxStarDistance.TabStop = false;
            groupBoxStarDistance.Text = "Star Distance";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCalculateStarDistance, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(268, 124);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel4.Location = new Point(3, 37);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(181, 50);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(labelStarAngle);
            flowLayoutPanel5.Controls.Add(numericStarAngle);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(126, 44);
            flowLayoutPanel5.TabIndex = 0;
            flowLayoutPanel5.WrapContents = false;
            // 
            // labelStarAngle
            // 
            labelStarAngle.AutoSize = true;
            labelStarAngle.Location = new Point(3, 0);
            labelStarAngle.Name = "labelStarAngle";
            labelStarAngle.Size = new Size(108, 15);
            labelStarAngle.TabIndex = 0;
            labelStarAngle.Text = "Angle (arcseconds)";
            // 
            // numericStarAngle
            // 
            numericStarAngle.Location = new Point(3, 18);
            numericStarAngle.Name = "numericStarAngle";
            numericStarAngle.Size = new Size(120, 23);
            numericStarAngle.TabIndex = 1;
            // 
            // btnCalculateStarDistance
            // 
            btnCalculateStarDistance.Anchor = AnchorStyles.Right;
            btnCalculateStarDistance.Location = new Point(190, 50);
            btnCalculateStarDistance.Name = "btnCalculateStarDistance";
            btnCalculateStarDistance.Size = new Size(75, 23);
            btnCalculateStarDistance.TabIndex = 0;
            btnCalculateStarDistance.Text = "Calculate";
            btnCalculateStarDistance.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 661);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Name = "MainWindow";
            Text = "Astronomical Processing";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxEventHorizon.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            flowLayoutPanel11.ResumeLayout(false);
            flowLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericBlackholeMass).EndInit();
            groupBoxTemperatureConversion.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTemperatureC).EndInit();
            groupBoxStarVelocity.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericObservedWavelength).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericRestWavelength).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridCalculations).EndInit();
            groupBoxStarDistance.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericStarAngle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog;
        private FontDialog fontDialog;
        private StatusStrip statusStrip;
        private ToolStrip toolStrip;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripStatusLabel labelStatus;
        private ToolStripComboBox comboLanguage;
        private ToolStripLabel labelLanguage;
        private ToolStripDropDownButton menuTheme;
        private ToolStripMenuItem menuitemThemeLight;
        private ToolStripMenuItem menuitemThemeDark;
        private ToolStripMenuItem menuitemThemeCustom;
        private ToolStripButton menuitemFont;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridView datagridCalculations;
        private GroupBox groupBoxStarDistance;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label labelStarAngle;
        private NumericUpDown numericStarAngle;
        private Button btnCalculateStarDistance;
        private GroupBox groupBoxEventHorizon;
        private TableLayoutPanel tableLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel11;
        private Label labelBlackholeMass;
        private NumericUpDown numericBlackholeMass;
        private Button btnCalculateEventHorizon;
        private GroupBox groupBoxTemperatureConversion;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label labelTemperatureC;
        private NumericUpDown numericTemperatureC;
        private Button btnCalculateTemperatureConversion;
        private GroupBox groupBoxStarVelocity;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label labelObservedWavelength;
        private NumericUpDown numericObservedWavelength;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label labelRestWavelength;
        private NumericUpDown numericRestWavelength;
        private Button btnCalculateStarVelocity;
    }
}
