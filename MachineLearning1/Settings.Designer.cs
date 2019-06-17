namespace MachineLearning1
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private bool Bold_Clicked;
        private bool Italics_Clicked;
        private bool Underlined_Clicked;
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
            this.TabSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Checkbox_Progressbars = new System.Windows.Forms.CheckBox();
            this.CheckBox_Antialiasing = new System.Windows.Forms.CheckBox();
            this.label_progressbars = new System.Windows.Forms.Label();
            this.label_antialiasing = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ComboBox_PreferedColumns = new System.Windows.Forms.ComboBox();
            this.Label_PreferedColumns = new System.Windows.Forms.Label();
            this.NumericUpDown_Weight_Max = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_Weight_Min = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_Bias_Max = new System.Windows.Forms.NumericUpDown();
            this.Label_Weight = new System.Windows.Forms.Label();
            this.NumericUpDown_Bias_Min = new System.Windows.Forms.NumericUpDown();
            this.Label_Bias = new System.Windows.Forms.Label();
            this.ComboBox_Neurons_Max = new System.Windows.Forms.ComboBox();
            this.ComboBox_Neurons_Min = new System.Windows.Forms.ComboBox();
            this.Label_AmountofNeuronsPerColumn = new System.Windows.Forms.Label();
            this.Label_Maximum = new System.Windows.Forms.Label();
            this.Label_Minimum = new System.Windows.Forms.Label();
            this.ComboBox_Columns_Max = new System.Windows.Forms.ComboBox();
            this.ComboBox_Columns_Min = new System.Windows.Forms.ComboBox();
            this.Label_AmountOfColumns = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CheckBox_Console = new System.Windows.Forms.CheckBox();
            this.ColorBox_Text = new System.Windows.Forms.PictureBox();
            this.ColorBox_Back = new System.Windows.Forms.PictureBox();
            this.Label_TextColor = new System.Windows.Forms.Label();
            this.Label_BackColor = new System.Windows.Forms.Label();
            this.ComboBox_Size = new System.Windows.Forms.ComboBox();
            this.ComboBox_Font = new System.Windows.Forms.ComboBox();
            this.Button_Underline = new System.Windows.Forms.Button();
            this.Button_Italics = new System.Windows.Forms.Button();
            this.Button_Bold = new System.Windows.Forms.Button();
            this.Label_FontSize = new System.Windows.Forms.Label();
            this.Label_CurrentFont = new System.Windows.Forms.Label();
            this.Button_ChangeFont = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Button_OpenLocation = new System.Windows.Forms.Button();
            this.Button_SaveLocation = new System.Windows.Forms.Button();
            this.Label_OpenLocation = new System.Windows.Forms.Label();
            this.TextBox_OpenLocation = new System.Windows.Forms.TextBox();
            this.Label_SaveLocation = new System.Windows.Forms.Label();
            this.TextBox_SaveLocation = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ColorDialog_Back = new System.Windows.Forms.ColorDialog();
            this.ColorDialog_Text = new System.Windows.Forms.ColorDialog();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Apply = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Default = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_theme = new System.Windows.Forms.Label();
            this.TabSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Weight_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Weight_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Bias_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Bias_Min)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox_Back)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSettings
            // 
            this.TabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSettings.Controls.Add(this.tabPage1);
            this.TabSettings.Controls.Add(this.tabPage2);
            this.TabSettings.Controls.Add(this.tabPage3);
            this.TabSettings.Controls.Add(this.tabPage4);
            this.TabSettings.Location = new System.Drawing.Point(1, 2);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.SelectedIndex = 0;
            this.TabSettings.Size = new System.Drawing.Size(488, 312);
            this.TabSettings.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label_theme);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.Checkbox_Progressbars);
            this.tabPage1.Controls.Add(this.CheckBox_Antialiasing);
            this.tabPage1.Controls.Add(this.label_progressbars);
            this.tabPage1.Controls.Add(this.label_antialiasing);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Progressbars
            // 
            this.Checkbox_Progressbars.AutoSize = true;
            this.Checkbox_Progressbars.Location = new System.Drawing.Point(96, 51);
            this.Checkbox_Progressbars.Name = "Checkbox_Progressbars";
            this.Checkbox_Progressbars.Size = new System.Drawing.Size(15, 14);
            this.Checkbox_Progressbars.TabIndex = 3;
            this.Checkbox_Progressbars.UseVisualStyleBackColor = true;
            this.Checkbox_Progressbars.CheckedChanged += new System.EventHandler(this.Checkbox_Progressbars_CheckedChanged);
            // 
            // CheckBox_Antialiasing
            // 
            this.CheckBox_Antialiasing.AutoSize = true;
            this.CheckBox_Antialiasing.Location = new System.Drawing.Point(96, 23);
            this.CheckBox_Antialiasing.Name = "CheckBox_Antialiasing";
            this.CheckBox_Antialiasing.Size = new System.Drawing.Size(15, 14);
            this.CheckBox_Antialiasing.TabIndex = 2;
            this.CheckBox_Antialiasing.UseVisualStyleBackColor = true;
            this.CheckBox_Antialiasing.CheckedChanged += new System.EventHandler(this.CheckBox_Antialiasing_CheckedChanged);
            // 
            // label_progressbars
            // 
            this.label_progressbars.AutoSize = true;
            this.label_progressbars.Location = new System.Drawing.Point(8, 52);
            this.label_progressbars.Name = "label_progressbars";
            this.label_progressbars.Size = new System.Drawing.Size(80, 13);
            this.label_progressbars.TabIndex = 1;
            this.label_progressbars.Text = "Progress bars : ";
            // 
            // label_antialiasing
            // 
            this.label_antialiasing.AutoSize = true;
            this.label_antialiasing.Location = new System.Drawing.Point(8, 23);
            this.label_antialiasing.Name = "label_antialiasing";
            this.label_antialiasing.Size = new System.Drawing.Size(66, 13);
            this.label_antialiasing.TabIndex = 0;
            this.label_antialiasing.Text = "Antialiasing :";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.ComboBox_PreferedColumns);
            this.tabPage2.Controls.Add(this.Label_PreferedColumns);
            this.tabPage2.Controls.Add(this.NumericUpDown_Weight_Max);
            this.tabPage2.Controls.Add(this.NumericUpDown_Weight_Min);
            this.tabPage2.Controls.Add(this.NumericUpDown_Bias_Max);
            this.tabPage2.Controls.Add(this.Label_Weight);
            this.tabPage2.Controls.Add(this.NumericUpDown_Bias_Min);
            this.tabPage2.Controls.Add(this.Label_Bias);
            this.tabPage2.Controls.Add(this.ComboBox_Neurons_Max);
            this.tabPage2.Controls.Add(this.ComboBox_Neurons_Min);
            this.tabPage2.Controls.Add(this.Label_AmountofNeuronsPerColumn);
            this.tabPage2.Controls.Add(this.Label_Maximum);
            this.tabPage2.Controls.Add(this.Label_Minimum);
            this.tabPage2.Controls.Add(this.ComboBox_Columns_Max);
            this.tabPage2.Controls.Add(this.ComboBox_Columns_Min);
            this.tabPage2.Controls.Add(this.Label_AmountOfColumns);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Network Generation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ComboBox_PreferedColumns
            // 
            this.ComboBox_PreferedColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_PreferedColumns.FormattingEnabled = true;
            this.ComboBox_PreferedColumns.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.ComboBox_PreferedColumns.Location = new System.Drawing.Point(214, 192);
            this.ComboBox_PreferedColumns.Name = "ComboBox_PreferedColumns";
            this.ComboBox_PreferedColumns.Size = new System.Drawing.Size(85, 21);
            this.ComboBox_PreferedColumns.TabIndex = 17;
            this.ComboBox_PreferedColumns.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PreferedColumns_SelectedIndexChanged);
            // 
            // Label_PreferedColumns
            // 
            this.Label_PreferedColumns.AutoSize = true;
            this.Label_PreferedColumns.Location = new System.Drawing.Point(14, 195);
            this.Label_PreferedColumns.Name = "Label_PreferedColumns";
            this.Label_PreferedColumns.Size = new System.Drawing.Size(142, 13);
            this.Label_PreferedColumns.TabIndex = 16;
            this.Label_PreferedColumns.Text = "Prefered amount of columns:";
            // 
            // NumericUpDown_Weight_Max
            // 
            this.NumericUpDown_Weight_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDown_Weight_Max.DecimalPlaces = 2;
            this.NumericUpDown_Weight_Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDown_Weight_Max.Location = new System.Drawing.Point(305, 139);
            this.NumericUpDown_Weight_Max.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Weight_Max.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.NumericUpDown_Weight_Max.Name = "NumericUpDown_Weight_Max";
            this.NumericUpDown_Weight_Max.Size = new System.Drawing.Size(85, 20);
            this.NumericUpDown_Weight_Max.TabIndex = 15;
            this.NumericUpDown_Weight_Max.ValueChanged += new System.EventHandler(this.NumericUpDown_Weight_Max_ValueChanged);
            // 
            // NumericUpDown_Weight_Min
            // 
            this.NumericUpDown_Weight_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDown_Weight_Min.DecimalPlaces = 2;
            this.NumericUpDown_Weight_Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDown_Weight_Min.Location = new System.Drawing.Point(214, 139);
            this.NumericUpDown_Weight_Min.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Weight_Min.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.NumericUpDown_Weight_Min.Name = "NumericUpDown_Weight_Min";
            this.NumericUpDown_Weight_Min.Size = new System.Drawing.Size(85, 20);
            this.NumericUpDown_Weight_Min.TabIndex = 14;
            this.NumericUpDown_Weight_Min.ValueChanged += new System.EventHandler(this.NumericUpDown_Weight_Min_ValueChanged);
            // 
            // NumericUpDown_Bias_Max
            // 
            this.NumericUpDown_Bias_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDown_Bias_Max.DecimalPlaces = 2;
            this.NumericUpDown_Bias_Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDown_Bias_Max.Location = new System.Drawing.Point(305, 111);
            this.NumericUpDown_Bias_Max.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Bias_Max.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.NumericUpDown_Bias_Max.Name = "NumericUpDown_Bias_Max";
            this.NumericUpDown_Bias_Max.Size = new System.Drawing.Size(85, 20);
            this.NumericUpDown_Bias_Max.TabIndex = 13;
            this.NumericUpDown_Bias_Max.ValueChanged += new System.EventHandler(this.NumericUpDown_Bias_Max_ValueChanged);
            // 
            // Label_Weight
            // 
            this.Label_Weight.AutoSize = true;
            this.Label_Weight.Location = new System.Drawing.Point(14, 141);
            this.Label_Weight.Name = "Label_Weight";
            this.Label_Weight.Size = new System.Drawing.Size(50, 13);
            this.Label_Weight.TabIndex = 12;
            this.Label_Weight.Text = "Weight : ";
            // 
            // NumericUpDown_Bias_Min
            // 
            this.NumericUpDown_Bias_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDown_Bias_Min.DecimalPlaces = 2;
            this.NumericUpDown_Bias_Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDown_Bias_Min.Location = new System.Drawing.Point(214, 111);
            this.NumericUpDown_Bias_Min.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Bias_Min.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.NumericUpDown_Bias_Min.Name = "NumericUpDown_Bias_Min";
            this.NumericUpDown_Bias_Min.Size = new System.Drawing.Size(85, 20);
            this.NumericUpDown_Bias_Min.TabIndex = 10;
            this.NumericUpDown_Bias_Min.ValueChanged += new System.EventHandler(this.NumericUpDown_Bias_Min_ValueChanged);
            // 
            // Label_Bias
            // 
            this.Label_Bias.AutoSize = true;
            this.Label_Bias.Location = new System.Drawing.Point(14, 113);
            this.Label_Bias.Name = "Label_Bias";
            this.Label_Bias.Size = new System.Drawing.Size(36, 13);
            this.Label_Bias.TabIndex = 9;
            this.Label_Bias.Text = "Bias : ";
            // 
            // ComboBox_Neurons_Max
            // 
            this.ComboBox_Neurons_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Neurons_Max.FormattingEnabled = true;
            this.ComboBox_Neurons_Max.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.ComboBox_Neurons_Max.Location = new System.Drawing.Point(305, 62);
            this.ComboBox_Neurons_Max.Name = "ComboBox_Neurons_Max";
            this.ComboBox_Neurons_Max.Size = new System.Drawing.Size(85, 21);
            this.ComboBox_Neurons_Max.TabIndex = 8;
            this.ComboBox_Neurons_Max.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Neurons_Max_SelectedIndexChanged);
            // 
            // ComboBox_Neurons_Min
            // 
            this.ComboBox_Neurons_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Neurons_Min.FormattingEnabled = true;
            this.ComboBox_Neurons_Min.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.ComboBox_Neurons_Min.Location = new System.Drawing.Point(214, 62);
            this.ComboBox_Neurons_Min.Name = "ComboBox_Neurons_Min";
            this.ComboBox_Neurons_Min.Size = new System.Drawing.Size(85, 21);
            this.ComboBox_Neurons_Min.TabIndex = 7;
            this.ComboBox_Neurons_Min.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Neurons_Min_SelectedIndexChanged);
            // 
            // Label_AmountofNeuronsPerColumn
            // 
            this.Label_AmountofNeuronsPerColumn.AutoSize = true;
            this.Label_AmountofNeuronsPerColumn.Location = new System.Drawing.Point(11, 65);
            this.Label_AmountofNeuronsPerColumn.Name = "Label_AmountofNeuronsPerColumn";
            this.Label_AmountofNeuronsPerColumn.Size = new System.Drawing.Size(163, 13);
            this.Label_AmountofNeuronsPerColumn.TabIndex = 6;
            this.Label_AmountofNeuronsPerColumn.Text = "Amount of Neurons per Column : ";
            // 
            // Label_Maximum
            // 
            this.Label_Maximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Maximum.AutoSize = true;
            this.Label_Maximum.Location = new System.Drawing.Point(306, 18);
            this.Label_Maximum.Name = "Label_Maximum";
            this.Label_Maximum.Size = new System.Drawing.Size(51, 13);
            this.Label_Maximum.TabIndex = 5;
            this.Label_Maximum.Text = "Maximum";
            // 
            // Label_Minimum
            // 
            this.Label_Minimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Minimum.AutoSize = true;
            this.Label_Minimum.Location = new System.Drawing.Point(215, 18);
            this.Label_Minimum.Name = "Label_Minimum";
            this.Label_Minimum.Size = new System.Drawing.Size(48, 13);
            this.Label_Minimum.TabIndex = 4;
            this.Label_Minimum.Text = "Minimum";
            // 
            // ComboBox_Columns_Max
            // 
            this.ComboBox_Columns_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Columns_Max.FormattingEnabled = true;
            this.ComboBox_Columns_Max.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.ComboBox_Columns_Max.Location = new System.Drawing.Point(305, 34);
            this.ComboBox_Columns_Max.Name = "ComboBox_Columns_Max";
            this.ComboBox_Columns_Max.Size = new System.Drawing.Size(85, 21);
            this.ComboBox_Columns_Max.TabIndex = 3;
            this.ComboBox_Columns_Max.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Columns_Max_SelectedIndexChanged);
            // 
            // ComboBox_Columns_Min
            // 
            this.ComboBox_Columns_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Columns_Min.FormattingEnabled = true;
            this.ComboBox_Columns_Min.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.ComboBox_Columns_Min.Location = new System.Drawing.Point(214, 34);
            this.ComboBox_Columns_Min.Name = "ComboBox_Columns_Min";
            this.ComboBox_Columns_Min.Size = new System.Drawing.Size(85, 21);
            this.ComboBox_Columns_Min.TabIndex = 2;
            this.ComboBox_Columns_Min.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Columns_Min_SelectedIndexChanged);
            // 
            // Label_AmountOfColumns
            // 
            this.Label_AmountOfColumns.AutoSize = true;
            this.Label_AmountOfColumns.Location = new System.Drawing.Point(11, 37);
            this.Label_AmountOfColumns.Name = "Label_AmountOfColumns";
            this.Label_AmountOfColumns.Size = new System.Drawing.Size(107, 13);
            this.Label_AmountOfColumns.TabIndex = 1;
            this.Label_AmountOfColumns.Text = "Amount of Columns : ";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(480, 286);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Console";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.CheckBox_Console);
            this.splitContainer1.Panel1.Controls.Add(this.ColorBox_Text);
            this.splitContainer1.Panel1.Controls.Add(this.ColorBox_Back);
            this.splitContainer1.Panel1.Controls.Add(this.Label_TextColor);
            this.splitContainer1.Panel1.Controls.Add(this.Label_BackColor);
            this.splitContainer1.Panel1.Controls.Add(this.ComboBox_Size);
            this.splitContainer1.Panel1.Controls.Add(this.ComboBox_Font);
            this.splitContainer1.Panel1.Controls.Add(this.Button_Underline);
            this.splitContainer1.Panel1.Controls.Add(this.Button_Italics);
            this.splitContainer1.Panel1.Controls.Add(this.Button_Bold);
            this.splitContainer1.Panel1.Controls.Add(this.Label_FontSize);
            this.splitContainer1.Panel1.Controls.Add(this.Label_CurrentFont);
            this.splitContainer1.Panel1.Controls.Add(this.Button_ChangeFont);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(474, 280);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 13;
            // 
            // CheckBox_Console
            // 
            this.CheckBox_Console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckBox_Console.AutoSize = true;
            this.CheckBox_Console.Checked = true;
            this.CheckBox_Console.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Console.Location = new System.Drawing.Point(11, 126);
            this.CheckBox_Console.Name = "CheckBox_Console";
            this.CheckBox_Console.Size = new System.Drawing.Size(99, 17);
            this.CheckBox_Console.TabIndex = 13;
            this.CheckBox_Console.Text = "Enable console";
            this.CheckBox_Console.UseVisualStyleBackColor = true;
            this.CheckBox_Console.CheckedChanged += new System.EventHandler(this.CheckBox_Console_CheckedChanged);
            // 
            // ColorBox_Text
            // 
            this.ColorBox_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBox_Text.Location = new System.Drawing.Point(425, 32);
            this.ColorBox_Text.Name = "ColorBox_Text";
            this.ColorBox_Text.Size = new System.Drawing.Size(22, 22);
            this.ColorBox_Text.TabIndex = 12;
            this.ColorBox_Text.TabStop = false;
            this.ColorBox_Text.Click += new System.EventHandler(this.ColorBox_Text_Click);
            // 
            // ColorBox_Back
            // 
            this.ColorBox_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox_Back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBox_Back.Location = new System.Drawing.Point(425, 8);
            this.ColorBox_Back.Name = "ColorBox_Back";
            this.ColorBox_Back.Size = new System.Drawing.Size(22, 22);
            this.ColorBox_Back.TabIndex = 11;
            this.ColorBox_Back.TabStop = false;
            this.ColorBox_Back.Click += new System.EventHandler(this.ColorBox_Back_Click);
            // 
            // Label_TextColor
            // 
            this.Label_TextColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_TextColor.AutoSize = true;
            this.Label_TextColor.Location = new System.Drawing.Point(324, 35);
            this.Label_TextColor.Name = "Label_TextColor";
            this.Label_TextColor.Size = new System.Drawing.Size(64, 13);
            this.Label_TextColor.TabIndex = 10;
            this.Label_TextColor.Text = "Text Color : ";
            // 
            // Label_BackColor
            // 
            this.Label_BackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_BackColor.AutoSize = true;
            this.Label_BackColor.Location = new System.Drawing.Point(324, 12);
            this.Label_BackColor.Name = "Label_BackColor";
            this.Label_BackColor.Size = new System.Drawing.Size(95, 13);
            this.Label_BackColor.TabIndex = 9;
            this.Label_BackColor.Text = "Background Color:";
            // 
            // ComboBox_Size
            // 
            this.ComboBox_Size.FormattingEnabled = true;
            this.ComboBox_Size.Location = new System.Drawing.Point(75, 32);
            this.ComboBox_Size.Name = "ComboBox_Size";
            this.ComboBox_Size.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Size.TabIndex = 8;
            this.ComboBox_Size.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Size_SelectedIndexChanged);
            // 
            // ComboBox_Font
            // 
            this.ComboBox_Font.FormattingEnabled = true;
            this.ComboBox_Font.Location = new System.Drawing.Point(75, 9);
            this.ComboBox_Font.Name = "ComboBox_Font";
            this.ComboBox_Font.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Font.TabIndex = 7;
            this.ComboBox_Font.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Font_SelectedIndexChanged);
            // 
            // Button_Underline
            // 
            this.Button_Underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Underline.Location = new System.Drawing.Point(75, 76);
            this.Button_Underline.Name = "Button_Underline";
            this.Button_Underline.Size = new System.Drawing.Size(26, 23);
            this.Button_Underline.TabIndex = 6;
            this.Button_Underline.Text = "U";
            this.Button_Underline.UseVisualStyleBackColor = true;
            this.Button_Underline.Click += new System.EventHandler(this.Button_Underline_Click);
            // 
            // Button_Italics
            // 
            this.Button_Italics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Italics.Location = new System.Drawing.Point(43, 76);
            this.Button_Italics.Name = "Button_Italics";
            this.Button_Italics.Size = new System.Drawing.Size(26, 23);
            this.Button_Italics.TabIndex = 5;
            this.Button_Italics.Text = "I";
            this.Button_Italics.UseVisualStyleBackColor = true;
            this.Button_Italics.Click += new System.EventHandler(this.Button_Italics_Click);
            // 
            // Button_Bold
            // 
            this.Button_Bold.BackColor = System.Drawing.Color.Transparent;
            this.Button_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Bold.Location = new System.Drawing.Point(11, 76);
            this.Button_Bold.Name = "Button_Bold";
            this.Button_Bold.Size = new System.Drawing.Size(26, 23);
            this.Button_Bold.TabIndex = 4;
            this.Button_Bold.Text = "B";
            this.Button_Bold.UseVisualStyleBackColor = false;
            this.Button_Bold.Click += new System.EventHandler(this.Button_Bold_Click);
            // 
            // Label_FontSize
            // 
            this.Label_FontSize.AutoSize = true;
            this.Label_FontSize.Location = new System.Drawing.Point(8, 35);
            this.Label_FontSize.Name = "Label_FontSize";
            this.Label_FontSize.Size = new System.Drawing.Size(54, 13);
            this.Label_FontSize.TabIndex = 3;
            this.Label_FontSize.Text = "Font Size:";
            // 
            // Label_CurrentFont
            // 
            this.Label_CurrentFont.AutoSize = true;
            this.Label_CurrentFont.Location = new System.Drawing.Point(8, 12);
            this.Label_CurrentFont.Name = "Label_CurrentFont";
            this.Label_CurrentFont.Size = new System.Drawing.Size(68, 13);
            this.Label_CurrentFont.TabIndex = 2;
            this.Label_CurrentFont.Text = "Current font: ";
            // 
            // Button_ChangeFont
            // 
            this.Button_ChangeFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ChangeFont.Location = new System.Drawing.Point(327, 76);
            this.Button_ChangeFont.Name = "Button_ChangeFont";
            this.Button_ChangeFont.Size = new System.Drawing.Size(147, 23);
            this.Button_ChangeFont.TabIndex = 1;
            this.Button_ChangeFont.Text = "Change font";
            this.Button_ChangeFont.UseVisualStyleBackColor = true;
            this.Button_ChangeFont.Click += new System.EventHandler(this.Button_ChangeFont_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(474, 146);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Example of text\nGenerating Neuron_1_0; bias 0.34\nGenerating Neuron_1_1; bias 1.03" +
    "\nGenerating Neuron_1_2; bias -0.43\nGenerating Neuron_1_3; bias 1,78";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.Button_OpenLocation);
            this.tabPage4.Controls.Add(this.Button_SaveLocation);
            this.tabPage4.Controls.Add(this.Label_OpenLocation);
            this.tabPage4.Controls.Add(this.TextBox_OpenLocation);
            this.tabPage4.Controls.Add(this.Label_SaveLocation);
            this.tabPage4.Controls.Add(this.TextBox_SaveLocation);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(480, 286);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Saving";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Button_OpenLocation
            // 
            this.Button_OpenLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OpenLocation.Location = new System.Drawing.Point(405, 49);
            this.Button_OpenLocation.Name = "Button_OpenLocation";
            this.Button_OpenLocation.Size = new System.Drawing.Size(26, 23);
            this.Button_OpenLocation.TabIndex = 5;
            this.Button_OpenLocation.Text = "...";
            this.Button_OpenLocation.UseVisualStyleBackColor = true;
            this.Button_OpenLocation.Click += new System.EventHandler(this.Button_OpenLocation_Click);
            // 
            // Button_SaveLocation
            // 
            this.Button_SaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SaveLocation.Location = new System.Drawing.Point(405, 13);
            this.Button_SaveLocation.Name = "Button_SaveLocation";
            this.Button_SaveLocation.Size = new System.Drawing.Size(26, 23);
            this.Button_SaveLocation.TabIndex = 4;
            this.Button_SaveLocation.Text = "...";
            this.Button_SaveLocation.UseVisualStyleBackColor = true;
            this.Button_SaveLocation.Click += new System.EventHandler(this.Button_SaveLocation_Click);
            // 
            // Label_OpenLocation
            // 
            this.Label_OpenLocation.AutoSize = true;
            this.Label_OpenLocation.Location = new System.Drawing.Point(20, 54);
            this.Label_OpenLocation.Name = "Label_OpenLocation";
            this.Label_OpenLocation.Size = new System.Drawing.Size(113, 13);
            this.Label_OpenLocation.TabIndex = 3;
            this.Label_OpenLocation.Text = "Defaut Load Location:";
            // 
            // TextBox_OpenLocation
            // 
            this.TextBox_OpenLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_OpenLocation.Location = new System.Drawing.Point(140, 51);
            this.TextBox_OpenLocation.Name = "TextBox_OpenLocation";
            this.TextBox_OpenLocation.Size = new System.Drawing.Size(259, 20);
            this.TextBox_OpenLocation.TabIndex = 2;
            // 
            // Label_SaveLocation
            // 
            this.Label_SaveLocation.AutoSize = true;
            this.Label_SaveLocation.Location = new System.Drawing.Point(20, 18);
            this.Label_SaveLocation.Name = "Label_SaveLocation";
            this.Label_SaveLocation.Size = new System.Drawing.Size(114, 13);
            this.Label_SaveLocation.TabIndex = 1;
            this.Label_SaveLocation.Text = "Defaut Save Location:";
            // 
            // TextBox_SaveLocation
            // 
            this.TextBox_SaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_SaveLocation.Location = new System.Drawing.Point(140, 15);
            this.TextBox_SaveLocation.Name = "TextBox_SaveLocation";
            this.TextBox_SaveLocation.Size = new System.Drawing.Size(259, 20);
            this.TextBox_SaveLocation.TabIndex = 0;
            // 
            // ColorDialog_Back
            // 
            this.ColorDialog_Back.AnyColor = true;
            // 
            // ColorDialog_Text
            // 
            this.ColorDialog_Text.AnyColor = true;
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(410, 312);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 2;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Apply
            // 
            this.Button_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Apply.Location = new System.Drawing.Point(329, 312);
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.Size = new System.Drawing.Size(75, 23);
            this.Button_Apply.TabIndex = 3;
            this.Button_Apply.Text = "Apply";
            this.Button_Apply.UseVisualStyleBackColor = true;
            this.Button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.Location = new System.Drawing.Point(248, 312);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 4;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Default
            // 
            this.Button_Default.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Default.Location = new System.Drawing.Point(5, 312);
            this.Button_Default.Name = "Button_Default";
            this.Button_Default.Size = new System.Drawing.Size(111, 23);
            this.Button_Default.TabIndex = 5;
            this.Button_Default.Text = "Default values";
            this.Button_Default.UseVisualStyleBackColor = true;
            this.Button_Default.Click += new System.EventHandler(this.Button_Default_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "Grey",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(351, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label_theme
            // 
            this.label_theme.AutoSize = true;
            this.label_theme.Location = new System.Drawing.Point(296, 26);
            this.label_theme.Name = "label_theme";
            this.label_theme.Size = new System.Drawing.Size(49, 13);
            this.label_theme.TabIndex = 5;
            this.label_theme.Text = "Theme : ";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(489, 339);
            this.Controls.Add(this.Button_Default);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Apply);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.TabSettings);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.TabSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Weight_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Weight_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Bias_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Bias_Min)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox_Back)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label Label_AmountOfColumns;
        private System.Windows.Forms.Label Label_Minimum;
        private System.Windows.Forms.ComboBox ComboBox_Columns_Max;
        private System.Windows.Forms.ComboBox ComboBox_Columns_Min;
        private System.Windows.Forms.Label Label_Maximum;
        private System.Windows.Forms.ComboBox ComboBox_Neurons_Max;
        private System.Windows.Forms.ComboBox ComboBox_Neurons_Min;
        private System.Windows.Forms.Label Label_AmountofNeuronsPerColumn;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Bias_Min;
        private System.Windows.Forms.Label Label_Bias;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Weight_Max;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Weight_Min;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Bias_Max;
        private System.Windows.Forms.Label Label_Weight;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Button_ChangeFont;
        private System.Windows.Forms.Label Label_FontSize;
        private System.Windows.Forms.Label Label_CurrentFont;
        private System.Windows.Forms.Button Button_Underline;
        private System.Windows.Forms.Button Button_Italics;
        private System.Windows.Forms.Button Button_Bold;
        private System.Windows.Forms.ComboBox ComboBox_Size;
        private System.Windows.Forms.ComboBox ComboBox_Font;
        private System.Windows.Forms.ColorDialog ColorDialog_Back;
        private System.Windows.Forms.ColorDialog ColorDialog_Text;
        private System.Windows.Forms.Label Label_TextColor;
        private System.Windows.Forms.Label Label_BackColor;
        private System.Windows.Forms.PictureBox ColorBox_Text;
        private System.Windows.Forms.PictureBox ColorBox_Back;
        private System.Windows.Forms.Label Label_PreferedColumns;
        private System.Windows.Forms.ComboBox ComboBox_PreferedColumns;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Apply;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Label Label_SaveLocation;
        private System.Windows.Forms.TextBox TextBox_SaveLocation;
        private System.Windows.Forms.Button Button_OpenLocation;
        private System.Windows.Forms.Button Button_SaveLocation;
        private System.Windows.Forms.Label Label_OpenLocation;
        private System.Windows.Forms.TextBox TextBox_OpenLocation;
        private System.Windows.Forms.Button Button_Default;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox CheckBox_Console;
        private System.Windows.Forms.CheckBox Checkbox_Progressbars;
        private System.Windows.Forms.CheckBox CheckBox_Antialiasing;
        private System.Windows.Forms.Label label_progressbars;
        private System.Windows.Forms.Label label_antialiasing;
        private System.Windows.Forms.Label label_theme;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}