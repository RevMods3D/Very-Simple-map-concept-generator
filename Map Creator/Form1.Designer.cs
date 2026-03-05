namespace Map_Creator
{
    partial class Form1
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
            Draw = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            mapNameTextBox = new Label();
            Minimize = new Label();
            ChangeSize = new Label();
            Close = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            TableLayoutPanel1 = new TableLayoutPanel();
            AmountSearch = new TextBox();
            Clear = new Button();
            Generate = new Button();
            Density = new TextBox();
            Multiplier = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Draw
            // 
            Draw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Draw.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Draw.BackColor = Color.FromArgb(64, 64, 64);
            Draw.BorderStyle = BorderStyle.FixedSingle;
            Draw.Location = new Point(184, 59);
            Draw.Margin = new Padding(5);
            Draw.Name = "Draw";
            Draw.Size = new Size(586, 388);
            Draw.TabIndex = 0;
            Draw.Paint += Generate_Paint;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(mapNameTextBox);
            panel2.Controls.Add(Minimize);
            panel2.Controls.Add(ChangeSize);
            panel2.Controls.Add(Close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 30);
            panel2.TabIndex = 2;
            panel2.DoubleClick += ChangeSize_Click;
            panel2.MouseDown += Panel2_MouseDown;
            panel2.MouseMove += Panel2_MouseMove;
            panel2.MouseUp += Panel2_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Map_Creator;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.TitleBar;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BackColor = Color.FromArgb(32, 32, 32);
            label1.Location = new Point(30, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 0;
            label1.Text = "Map Creator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mapNameTextBox
            // 
            mapNameTextBox.AccessibleRole = AccessibleRole.TitleBar;
            mapNameTextBox.AutoEllipsis = true;
            mapNameTextBox.Font = new Font("Segoe UI", 20F);
            mapNameTextBox.Location = new Point(103, 0);
            mapNameTextBox.Margin = new Padding(0);
            mapNameTextBox.Name = "mapNameTextBox";
            mapNameTextBox.Size = new Size(591, 30);
            mapNameTextBox.TabIndex = 4;
            mapNameTextBox.TextAlign = ContentAlignment.MiddleCenter;
            mapNameTextBox.MouseDown += Panel2_MouseDown;
            mapNameTextBox.MouseMove += Panel2_MouseMove;
            mapNameTextBox.MouseUp += Panel2_MouseUp;
            // 
            // Minimize
            // 
            Minimize.BackColor = Color.FromArgb(32, 32, 32);
            Minimize.Dock = DockStyle.Right;
            Minimize.Location = new Point(694, 0);
            Minimize.Margin = new Padding(0);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(30, 30);
            Minimize.TabIndex = 2;
            Minimize.Text = "━";
            Minimize.TextAlign = ContentAlignment.MiddleCenter;
            Minimize.Click += Minimize_Click;
            // 
            // ChangeSize
            // 
            ChangeSize.BackColor = Color.FromArgb(32, 32, 32);
            ChangeSize.Dock = DockStyle.Right;
            ChangeSize.Location = new Point(724, 0);
            ChangeSize.Margin = new Padding(0);
            ChangeSize.Name = "ChangeSize";
            ChangeSize.Size = new Size(30, 30);
            ChangeSize.TabIndex = 3;
            ChangeSize.Text = "▭";
            ChangeSize.TextAlign = ContentAlignment.MiddleCenter;
            ChangeSize.Click += ChangeSize_Click;
            // 
            // Close
            // 
            Close.BackColor = Color.FromArgb(32, 32, 32);
            Close.Dock = DockStyle.Right;
            Close.Location = new Point(754, 0);
            Close.Margin = new Padding(0);
            Close.Name = "Close";
            Close.Size = new Size(30, 30);
            Close.TabIndex = 1;
            Close.Text = "✕";
            Close.TextAlign = ContentAlignment.MiddleCenter;
            Close.Click += ExitToolStripMenuItem1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(50, 50, 50);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 30);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem1 });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.BackColor = Color.FromArgb(50, 50, 50);
            newToolStripMenuItem.ForeColor = Color.White;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.FromArgb(50, 50, 50);
            openToolStripMenuItem.ForeColor = Color.White;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.FromArgb(50, 50, 50);
            saveToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.BackColor = Color.FromArgb(50, 50, 50);
            exitToolStripMenuItem1.ForeColor = Color.White;
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(180, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += ExitToolStripMenuItem1_Click;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.Controls.Add(AmountSearch, 1, 1);
            TableLayoutPanel1.Controls.Add(Clear, 1, 0);
            TableLayoutPanel1.Controls.Add(Generate, 0, 0);
            TableLayoutPanel1.Controls.Add(Density, 1, 2);
            TableLayoutPanel1.Controls.Add(Multiplier, 0, 2);
            TableLayoutPanel1.Location = new Point(12, 59);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 4;
            TableLayoutPanel1.RowStyles.Add(new RowStyle());
            TableLayoutPanel1.RowStyles.Add(new RowStyle());
            TableLayoutPanel1.RowStyles.Add(new RowStyle());
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 288F));
            TableLayoutPanel1.Size = new Size(164, 388);
            TableLayoutPanel1.TabIndex = 4;
            // 
            // AmountSearch
            // 
            AmountSearch.BackColor = Color.FromArgb(64, 64, 64);
            AmountSearch.BorderStyle = BorderStyle.FixedSingle;
            AmountSearch.ForeColor = Color.FromArgb(25, 25, 25);
            AmountSearch.Location = new Point(85, 33);
            AmountSearch.Name = "AmountSearch";
            AmountSearch.PlaceholderText = "Amount";
            AmountSearch.Size = new Size(76, 23);
            AmountSearch.TabIndex = 3;
            AmountSearch.TextAlign = HorizontalAlignment.Center;
            AmountSearch.KeyPress += NumberOnly_KeyPress;
            // 
            // Clear
            // 
            Clear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Clear.BackColor = Color.FromArgb(50, 50, 50);
            Clear.FlatAppearance.BorderSize = 0;
            Clear.FlatStyle = FlatStyle.Popup;
            Clear.ForeColor = Color.White;
            Clear.Location = new Point(85, 3);
            Clear.Name = "Clear";
            Clear.Size = new Size(76, 24);
            Clear.TabIndex = 1;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            Clear.Paint += Clear_Paint;
            // 
            // Generate
            // 
            Generate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Generate.BackColor = Color.FromArgb(50, 50, 50);
            Generate.FlatAppearance.BorderSize = 0;
            Generate.FlatStyle = FlatStyle.Popup;
            Generate.ForeColor = Color.White;
            Generate.Location = new Point(3, 3);
            Generate.Name = "Generate";
            Generate.Size = new Size(76, 24);
            Generate.TabIndex = 0;
            Generate.Text = "Generate";
            Generate.UseVisualStyleBackColor = false;
            Generate.Click += Generate_Click;
            // 
            // Density
            // 
            Density.BackColor = Color.FromArgb(64, 64, 64);
            Density.BorderStyle = BorderStyle.FixedSingle;
            Density.ForeColor = Color.FromArgb(25, 25, 25);
            Density.Location = new Point(85, 62);
            Density.Name = "Density";
            Density.PlaceholderText = "Density";
            Density.Size = new Size(76, 23);
            Density.TabIndex = 4;
            Density.TextAlign = HorizontalAlignment.Center;
            Density.KeyPress += NumberOnly_KeyPress;
            // 
            // Multiplier
            // 
            Multiplier.BackColor = Color.FromArgb(64, 64, 64);
            Multiplier.BorderStyle = BorderStyle.FixedSingle;
            Multiplier.ForeColor = Color.FromArgb(25, 25, 25);
            Multiplier.Location = new Point(3, 62);
            Multiplier.Name = "Multiplier";
            Multiplier.PlaceholderText = "Multiplier";
            Multiplier.Size = new Size(76, 23);
            Multiplier.TabIndex = 5;
            Multiplier.TextAlign = HorizontalAlignment.Center;
            Multiplier.KeyPress += NumberOnly_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(784, 461);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(Draw);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Map Creator";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Draw;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private new Label Close;
        private Label ChangeSize;
        private Label Minimize;
        private TableLayoutPanel TableLayoutPanel1;
        private Button Generate;
        private Button Clear;
        private TextBox Multiplier;
        private TextBox AmountSearch;
        private TextBox Density;
        private Label label1;
        private PictureBox pictureBox1;
        private Label mapNameTextBox;
    }
}
