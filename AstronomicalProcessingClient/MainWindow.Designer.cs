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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            colorDialog = new ColorDialog();
            fontDialog = new FontDialog();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            comboBoxLanguage = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 439);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(584, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, comboBoxLanguage, toolStripSeparator1, toolStripDropDownButton1, toolStripButton1 });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(584, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(62, 22);
            toolStripLabel1.Text = "Language:";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, darkToolStripMenuItem, toolStripMenuItem2 });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(57, 22);
            toolStripDropDownButton1.Text = "Theme";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.CheckOnClick = true;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(116, 22);
            toolStripMenuItem1.Text = "Light";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.CheckOnClick = true;
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(116, 22);
            darkToolStripMenuItem.Text = "Dark";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.CheckOnClick = true;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(116, 22);
            toolStripMenuItem2.Text = "Custom";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(44, 22);
            toolStripButton1.Text = "Font...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(560, 408);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(283, 3);
            dataGridView1.Name = "dataGridView1";
            tableLayoutPanel1.SetRowSpan(dataGridView1, 4);
            dataGridView1.Size = new Size(274, 402);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button1, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(274, 96);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(140, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel2.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(268, 42);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog;
        private FontDialog fontDialog;
        private StatusStrip statusStrip;
        private ToolStrip toolStrip;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripComboBox comboBoxLanguage;
        private ToolStripLabel toolStripLabel1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
