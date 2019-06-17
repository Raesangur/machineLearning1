using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearning1
{
    public partial class Settings : Form
    {
        public string Version = "Version 0";
        public MachineLearning machineLearning;

        #region Settings Values
        #region Default setting values 
        // General Settings
        private const string default_Theme = "Light";
        private Color default_WindowBackColor = Color.FromName("Control");
        private Color default_WindowTextColor = Color.FromName("Black");
        private Color default_WindowHighlightColor = Color.FromName("Transparent");
        private const bool default_Antialiasing = true;
        private const bool default_Progressbars = true;
        // Neural Network Settings
        private const int default_AmountOfColumns_Min = 2;
        private const int default_AmountOfColumns_Max = 6;
        private const int default_AmountOfNeurons_Min = 1;
        private const int default_AmountOfNeurons_Max = 16;
        private const int default_PreferedAmountOfColumns = 0;
        private const double default_Bias_Min = -2.0f;
        private const double default_Bias_Max = 2.0f;
        private const double default_Weight_Min = -2.0f;
        private const double default_Weight_Max = 2.0f;
        // Console Settings
        private Color default_ConsoleBackColor = Color.FromName("MenuText");
        private Color default_ConsoleTextColor = Color.FromName("Menu");
        private const string default_ConsoleFont = "Microsoft Sans Serif";
        private const int default_ConsoleFontSize = 10;
        private const bool default_ConsoleBold = false;
        private const bool default_ConsoleItalics = false;
        private const bool default_ConsoleUnderlined = false;
        private const bool default_ConsoleStrikethrough = false;
        private const bool default_ConsoleEnabled = true;
        // Saving settings
        private const string default_SaveLocation = @"E:\Progrmmation\C#\MachineLearning1\MachineLearning1\bin\Debug";
        private const string default_OpenLocation = @"E:\Programmation\C#\MachineLearning1\MachineLearning1\bin\Debug";
        #endregion
        #region Basic variables
        // General Settings
        private string _Theme = default_Theme;
        private Color _WindowBackColor;
        private Color _WindowTextColor;
        private Color _WindowHighlightColor;
        private bool _Antialiasing = default_Antialiasing;
        private bool _Progressbars = default_Progressbars;
        // Neural Network Settings
        private int _AmountOfColumns_Min = default_AmountOfColumns_Min;
        private int _AmountOfColumns_Max = default_AmountOfColumns_Max;
        private int _AmountOfNeurons_Min = default_AmountOfNeurons_Min;
        private int _AmountOfNeurons_Max = default_AmountOfNeurons_Max;
        private int _PreferedAmountOfColumns = default_PreferedAmountOfColumns;
        private double _Bias_Min = default_Bias_Min;
        private double _Bias_Max = default_Bias_Max;
        private double _Weight_Min = default_Weight_Min;
        private double _Weight_Max = default_Weight_Max;
        // Console Settings
        private Color _ConsoleBackColor;
        private Color _ConsoleTextColor;
        private string _ConsoleFont = default_ConsoleFont;
        private int _ConsoleFontSize = default_ConsoleFontSize;
        private bool _ConsoleBold = default_ConsoleBold;
        private bool _ConsoleItalics = default_ConsoleItalics;
        private bool _ConsoleUnderlined = default_ConsoleUnderlined;
        private bool _ConsoleStrikethrough = default_ConsoleStrikethrough;
        private bool _ConsoleEnabled = default_ConsoleEnabled;
        // Saving settings
        private string _SaveLocation = default_SaveLocation;
        private string _OpenLocation = default_OpenLocation;
        #endregion

        #region Properties
        // General Settings
        public bool Antialiasing
        {
            get { return _Antialiasing; }
            set
            {
                _Antialiasing = value;
                Antialiasing_changed();
            }
        }
        public bool Progressbars
        {
            get { return _Progressbars; }
            set
            {
                _Progressbars = value;
                Progressbars_changed();
            }
        }
        public string Theme
        {
            get { return _Theme; }
            set
            {
                _Theme = value;
                Theme_changed();
            }
        }
        public Color WindowBackColor
        {
            get { return _WindowBackColor; }
            set
            {
                _WindowBackColor = value;
                WindowBackColor_changed();
            }
        }
        public Color WindowTextColor
        {
            get { return _WindowTextColor; }
            set
            {
                _WindowTextColor = value;
                WindowTextColor_changed();
            }
        }
        public Color WindowHighlightColor
        {
            get { return _WindowHighlightColor; }
            set
            {
                _WindowBackColor = value;
                WindowHighlightColor_changed();
            }
        }
        // Neural Network Settings
        public int AmountOfColumns_Min
        {
            get { return _AmountOfColumns_Min; }
            set
            {
                _AmountOfColumns_Min = value;
                AmountOfColumns_Min_changed();
            }
        }
        public int AmountOfColumns_Max
        {
            get { return _AmountOfColumns_Max; }
            set
            {
                _AmountOfColumns_Max = value;
                AmountOfColumns_Max_changed();
            }
        }
        public int AmountOfNeurons_Min
        {
            get { return _AmountOfNeurons_Min; }
            set
            {
                _AmountOfNeurons_Min = value;
                AmountOfNeurons_Min_changed();
            }
        }
        public int AmountOfNeurons_Max
        {
            get { return _AmountOfNeurons_Max; }
            set
            {
                _AmountOfNeurons_Max = value;
                AmountOfNeurons_Max_changed();
            }
        }
        public int PreferedAmountOfColumns
        {
            get { return _PreferedAmountOfColumns; }
            set
            {
                _PreferedAmountOfColumns = value;
                PreferedAmountOfColumns_changed();
            }
        }
        public double Bias_Min
        {
            get { return _Bias_Min; }
            set
            {
                _Bias_Min = value;
                Bias_Min_changed();
            }
        }
        public double Bias_Max
        {
            get { return _Bias_Max; }
            set
            {
                _Bias_Max = value;
                Bias_Max_changed();
            }
        }
        public double Weight_Min
        {
            get { return _Weight_Min; }
            set
            {
                _Weight_Min = value;
                Weight_Min_changed();
            }
        }
        public double Weight_Max
        {
            get { return _Weight_Max; }
            set
            {
                _Weight_Max = value;
                Weight_Max_changed();
            }
        }
        // Console Settings
        public Color ConsoleBackColor
        {
            get { return _ConsoleBackColor; }
            set
            {
                _ConsoleBackColor = value;
                ConsoleBackColor_changed();
            }
        }
        public Color ConsoleTextColor
        {
            get { return _ConsoleTextColor; }
            set
            {
                _ConsoleTextColor = value;
                ConsoleTextColor_changed();
            }
        }
        public string ConsoleFont
        {
            get { return _ConsoleFont; }
            set
            {
                _ConsoleFont = value;
                ConsoleFont_changed();
            }
        }
        public int ConsoleFontSize
        {
            get { return _ConsoleFontSize; }
            set
            {
                _ConsoleFontSize = value;
                ConsoleFontSize_changed();
            }
        }
        public bool ConsoleBold
        {
            get { return _ConsoleBold; }
            set
            {
                _ConsoleBold = value;
                ConsoleBold_changed();
            }
        }
        public bool ConsoleItalics
        {
            get { return _ConsoleItalics; }
            set
            {
                _ConsoleItalics = value;
                ConsoleItalics_changed();
            }
        }
        public bool ConsoleUnderlined
        {
            get { return _ConsoleUnderlined; }
            set
            {
                _ConsoleUnderlined = value;
                ConsoleUnderlined_changed();
            }
        }
        public bool ConsoleStrikethrough
        {
            get { return _ConsoleStrikethrough; }
            set
            {
                _ConsoleStrikethrough = value;
                ConsoleStrikethrough_changed();
            }
        }
        public bool ConsoleEnabled
        {
            get { return _ConsoleEnabled; }
            set
            {
                _ConsoleEnabled = value;
                ConsoleEnabled_changed();
            }
        }
        // Saving Settings
        private string SaveLocation
        {
            get { return _SaveLocation; }
            set
            {
                _SaveLocation = value;
                SaveLocation_changed();
            }
        }
        private string OpenLocation
        {
            get { return _OpenLocation; }
            set
            {
                _OpenLocation = value;
                OpenLocation_changed();
            }
        }

        #endregion
        #region private values
        // General Settings
        private bool temp_Antialiasing;
        private bool temp_Progressbars;
        // Neural Network Settings
        private int temp_AmountOfColumns_Min;
        private int temp_AmountOfColumns_Max;
        private int temp_AmountOfNeurons_Min;
        private int temp_AmountOfNeurons_Max;
        private int temp_PreferedAmountOfColumns = 0;
        private double temp_Bias_Min;
        private double temp_Bias_Max;
        private double temp_Weight_Min;
        private double temp_Weight_Max;
        // Console Settings
        private Color temp_ConsoleBackColor;
        private Color temp_ConsoleTextColor;
        private string temp_ConsoleFont;
        private int temp_ConsoleFontSize;
        private bool temp_ConsoleBold;
        private bool temp_ConsoleItalics;
        private bool temp_ConsoleUnderlined;
        private bool temp_ConsoleStrikethrough;
        private bool temp_ConsoleEnabled;
        // Saving Settings
        private string temp_SaveLocation;
        private string temp_OpenLocation;
        #region Other unrelated variables, used as defines because I can't use them in C#
        private Color ButtonPressed = Color.FromName("Silver");
        private Color ButtonUnPressed = Color.FromName("Transparent");
        #endregion
        #endregion
        #endregion

        public Settings(MachineLearning parent)
        {
            machineLearning = parent;
            InitializeComponent();
            FormInitialization();
            Display();
        }


        #region Form Functions
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void FormInitialization()
        {
            // Making sure save and open folder exists
            CheckSaveLocation();
            CheckOpenLocation();
            // Color defaulting
            _ConsoleBackColor = default_ConsoleBackColor;
            _ConsoleTextColor = default_ConsoleTextColor;
            _WindowBackColor = default_WindowBackColor;
            _WindowTextColor = default_WindowTextColor;
            _WindowHighlightColor = default_WindowHighlightColor;
            // Filling in font comboboxes
            foreach(FontFamily font in FontFamily.Families)
            {
                ComboBox_Font.Items.Add(font.Name);
            }
            for(int i = 7; i < 72; i++)
            {
                ComboBox_Size.Items.Add(i.ToString());
                if(i >= 16) i++;
            }
        }
        public void Display()
        {
            #region Temporary variables to cancel changes
            // General Settings
            temp_Antialiasing = Antialiasing;
            temp_Progressbars = Progressbars;
            // Neural Network Settings
            temp_AmountOfColumns_Min = AmountOfColumns_Min;
            temp_AmountOfColumns_Max = AmountOfColumns_Max;
            temp_AmountOfNeurons_Min = AmountOfNeurons_Min;
            temp_AmountOfNeurons_Max = AmountOfNeurons_Max;
            temp_PreferedAmountOfColumns = PreferedAmountOfColumns;
            temp_Bias_Min = Bias_Min;
            temp_Bias_Max = Bias_Max;
            temp_Weight_Min = Weight_Min;
            temp_Weight_Max = Weight_Max;
            // Console Settings
            temp_ConsoleBackColor = ConsoleBackColor;
            temp_ConsoleTextColor = ConsoleTextColor;
            temp_ConsoleFont = ConsoleFont;
            temp_ConsoleFontSize = ConsoleFontSize;
            temp_ConsoleBold = ConsoleBold;
            temp_ConsoleItalics = ConsoleItalics;
            temp_ConsoleUnderlined = ConsoleUnderlined;
            temp_ConsoleStrikethrough = ConsoleStrikethrough;
            temp_ConsoleEnabled = ConsoleEnabled;
            // Saving Settings
            temp_SaveLocation = SaveLocation;
            temp_OpenLocation = OpenLocation;
            #endregion

            #region Assigning variables to form elements
            // General Settings
            try { CheckBox_Antialiasing.Checked = Antialiasing; } catch { }
            try { Checkbox_Progressbars.Checked = Progressbars; } catch { }
            // Neural Network Settings
            try { ComboBox_Columns_Min.SelectedIndex = AmountOfColumns_Min - 1; } catch { }
            try { ComboBox_Columns_Max.SelectedIndex = AmountOfColumns_Max - 1; } catch { }
            try { ComboBox_Neurons_Min.SelectedIndex = AmountOfNeurons_Min - 1; } catch { }
            try { ComboBox_Neurons_Max.SelectedIndex = AmountOfNeurons_Max - 1; } catch { }
            try { ComboBox_PreferedColumns.SelectedIndex = PreferedAmountOfColumns - 1; } catch { }
            try { NumericUpDown_Bias_Min.Value = (decimal)Bias_Min; } catch { }
            try { NumericUpDown_Bias_Max.Value = (decimal)Bias_Max; } catch { }
            try { NumericUpDown_Weight_Min.Value = (decimal)Weight_Min; } catch { }
            try { NumericUpDown_Weight_Max.Value = (decimal)Weight_Max; } catch { }
            // Console Settings
            try { ColorBox_Back.BackColor = ConsoleBackColor; } catch { }
            try { ColorBox_Text.BackColor = ConsoleTextColor; } catch { }
            try { ComboBox_Font.SelectedIndex = ComboBox_Font.FindStringExact(ConsoleFont); } catch { }
            try { ComboBox_Size.SelectedIndex = ComboBox_Size.FindStringExact(ConsoleFontSize.ToString()); } catch { }
            try { Bold_Clicked = ConsoleBold; Button_Bold.BackColor = ConsoleBold ? ButtonPressed : ButtonUnPressed;} catch { }
            try { Italics_Clicked = ConsoleItalics; Button_Italics.BackColor = ConsoleItalics ? ButtonPressed : ButtonUnPressed; } catch { }
            try { Underlined_Clicked = ConsoleUnderlined; Button_Underline.BackColor = ConsoleUnderlined ? ButtonPressed : ButtonUnPressed; } catch { }
            try { CheckBox_Console.Checked = ConsoleEnabled; } catch { }
            // Saving Settings
            try { TextBox_SaveLocation.Text = SaveLocation; } catch { }
            try { TextBox_OpenLocation.Text = OpenLocation; } catch { }
            #endregion
        }

        #region Form Settings
        // General Settings
        private void CheckBox_Antialiasing_CheckedChanged(object sender, EventArgs e)
        {
            Antialiasing = CheckBox_Antialiasing.Checked;
        }
        private void Checkbox_Progressbars_CheckedChanged(object sender, EventArgs e)
        {
            Progressbars = Checkbox_Progressbars.Checked;
        }
        // Neural Network Settings
        private void ComboBox_Columns_Min_SelectedIndexChanged(object sender, EventArgs e)
        {
            AmountOfColumns_Min = ComboBox_Columns_Min.SelectedIndex + 1;
        }
        private void ComboBox_Columns_Max_SelectedIndexChanged(object sender, EventArgs e)
        {
            AmountOfColumns_Max = ComboBox_Columns_Max.SelectedIndex + 1;
        }
        private void ComboBox_Neurons_Min_SelectedIndexChanged(object sender, EventArgs e)
        {
            AmountOfNeurons_Min = ComboBox_Neurons_Min.SelectedIndex + 1;
        }
        private void ComboBox_Neurons_Max_SelectedIndexChanged(object sender, EventArgs e)
        {
            AmountOfNeurons_Max = ComboBox_Neurons_Max.SelectedIndex + 1;
        }
        private void NumericUpDown_Bias_Min_ValueChanged(object sender, EventArgs e)
        {
            Bias_Min = Convert.ToDouble(NumericUpDown_Bias_Min.Value);
        }
        private void NumericUpDown_Bias_Max_ValueChanged(object sender, EventArgs e)
        {
            Bias_Max = Convert.ToDouble(NumericUpDown_Bias_Max.Value);
        }
        private void NumericUpDown_Weight_Min_ValueChanged(object sender, EventArgs e)
        {
            Weight_Min = Convert.ToDouble(NumericUpDown_Weight_Min.Value);
        }
        private void NumericUpDown_Weight_Max_ValueChanged(object sender, EventArgs e)
        {
            Weight_Max = Convert.ToDouble(NumericUpDown_Weight_Max.Value);
        }
        // Console Settings
        private void ColorBox_Back_Click(object sender, EventArgs e)
        {
            ColorDialog_Back.ShowDialog();
            ConsoleBackColor = ColorDialog_Back.Color;
        }
        private void ColorBox_Text_Click(object sender, EventArgs e)
        {
            ColorDialog_Text.ShowDialog();
            ConsoleTextColor = ColorDialog_Text.Color;
        }
        private void Button_ChangeFont_Click(object sender, EventArgs e)
        {
            FontFamily fontFamily = new FontFamily(ConsoleFont);
            Font font = new Font(fontFamily, ConsoleFontSize,
                ((ConsoleBold ? FontStyle.Bold : FontStyle.Regular) | (ConsoleItalics ? FontStyle.Italic : FontStyle.Regular) | (ConsoleUnderlined ? FontStyle.Underline : FontStyle.Regular) | (ConsoleStrikethrough ? FontStyle.Strikeout : FontStyle.Regular)),
                GraphicsUnit.Point);

            fontDialog1.Font = font;

            if(fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                ConsoleFont = fontDialog1.Font.Name;
                ConsoleBold = fontDialog1.Font.Bold;
                ConsoleItalics = fontDialog1.Font.Italic;
                ConsoleUnderlined = fontDialog1.Font.Underline;
                ConsoleStrikethrough = fontDialog1.Font.Strikeout;
                ConsoleFontSize = Convert.ToInt16(fontDialog1.Font.Size);
            }

        }
        private void ComboBox_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsoleFont = ComboBox_Font.SelectedItem.ToString();
        }
        private void ComboBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsoleFontSize = Convert.ToInt16(ComboBox_Size.SelectedItem.ToString());
        }
        private void Button_Bold_Click(object sender, EventArgs e)
        {
            ConsoleBold = !ConsoleBold;
        }
        private void Button_Italics_Click(object sender, EventArgs e)
        {
            ConsoleItalics = !ConsoleItalics;
        }
        private void Button_Underline_Click(object sender, EventArgs e)
        {
            ConsoleUnderlined = !ConsoleUnderlined;
        }
        private void CheckBox_Console_CheckedChanged(object sender, EventArgs e)
        {
            ConsoleEnabled = !ConsoleEnabled;
        }
        private void ComboBox_PreferedColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreferedAmountOfColumns = Convert.ToInt16(ComboBox_PreferedColumns.SelectedItem.ToString());
        }
        // Saving Settings
        private void Button_SaveLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveLocation = fileDialog.SelectedPath;
            }
        }
        private void Button_OpenLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenLocation = fileDialog.SelectedPath;
            }
        }
        #endregion

        #region Values changed functions
        // General Settings
        private void Antialiasing_changed()
        {
            CheckBox_Antialiasing.Checked = Antialiasing;
        }
        private void Progressbars_changed()
        {
            Checkbox_Progressbars.Checked = Progressbars;
        }
        private void Theme_changed()
        {

        }
        private void WindowBackColor_changed()
        {

        }
        private void WindowTextColor_changed()
        {

        }
        private void WindowHighlightColor_changed()
        {

        }
        // Neural Network Settings
        private void AmountOfColumns_Min_changed()
        {
            if(AmountOfColumns_Min > AmountOfColumns_Max)
            {
                ComboBox_Columns_Max.SelectedIndex = ComboBox_Columns_Min.SelectedIndex;
            }
            if(PreferedAmountOfColumns != 0)
            {
                if(PreferedAmountOfColumns < AmountOfColumns_Min)
                {
                    PreferedAmountOfColumns = AmountOfColumns_Min;
                }
            }
        }
        private void AmountOfColumns_Max_changed()
        {
            if(AmountOfColumns_Max < AmountOfColumns_Min)
            {
                ComboBox_Columns_Min.SelectedIndex = ComboBox_Columns_Max.SelectedIndex;
            }
            if(PreferedAmountOfColumns != 0)
            {
                if(PreferedAmountOfColumns > AmountOfColumns_Max)
                {
                    PreferedAmountOfColumns = AmountOfColumns_Max;
                }
            }
        }
        private void AmountOfNeurons_Min_changed()
        {
            if(AmountOfNeurons_Min > AmountOfNeurons_Max)
            {
                ComboBox_Neurons_Max.SelectedIndex = ComboBox_Neurons_Min.SelectedIndex;
            }
        }
        private void AmountOfNeurons_Max_changed()
        {
            if(AmountOfNeurons_Max < AmountOfNeurons_Min)
            {
                ComboBox_Neurons_Min.SelectedIndex = ComboBox_Neurons_Max.SelectedIndex;
            }
        }
        private void PreferedAmountOfColumns_changed()
        {
            if(PreferedAmountOfColumns < AmountOfColumns_Min) PreferedAmountOfColumns = AmountOfColumns_Min;
            if(PreferedAmountOfColumns > AmountOfColumns_Max) PreferedAmountOfColumns = AmountOfColumns_Max;
            ComboBox_PreferedColumns.SelectedIndex = ComboBox_PreferedColumns.FindStringExact(PreferedAmountOfColumns.ToString());
        }
        private void Bias_Min_changed()
        {
            if(Bias_Min > Bias_Max)
            {
                NumericUpDown_Bias_Max.Value = Convert.ToDecimal(Bias_Min);
            }
        }
        private void Bias_Max_changed()
        {
            if(Bias_Max < Bias_Min)
            {
                NumericUpDown_Bias_Min.Value = Convert.ToDecimal(Bias_Max);
            }
        }
        private void Weight_Min_changed()
        {
            if(Weight_Min > Weight_Max)
            {
                NumericUpDown_Weight_Max.Value = Convert.ToDecimal(Weight_Min);
            }
        }
        private void Weight_Max_changed()
        {
            if(Weight_Max < Weight_Min)
            {
                NumericUpDown_Weight_Min.Value = Convert.ToDecimal(Weight_Max);
            }
        }
        // Console Settings
        private void FontSettingChanged()
        {
            FontFamily fontFamily = new FontFamily(ConsoleFont);
            Font font = new Font(fontFamily, ConsoleFontSize, ((ConsoleBold ? FontStyle.Bold : FontStyle.Regular) | (ConsoleItalics ? FontStyle.Italic : FontStyle.Regular) | (ConsoleUnderlined ? FontStyle.Underline : FontStyle.Regular) | (ConsoleStrikethrough ? FontStyle.Strikeout : FontStyle.Regular)), GraphicsUnit.Point);

            richTextBox1.Font = font;
        }
        private void ConsoleBackColor_changed()
        {
            ColorBox_Back.BackColor = ConsoleBackColor;
            richTextBox1.BackColor = ConsoleBackColor;
        }
        private void ConsoleTextColor_changed()
        {
            ColorBox_Text.BackColor = ConsoleTextColor;
            richTextBox1.ForeColor = ConsoleTextColor;
        }
        private void ConsoleFont_changed()
        {
            FontSettingChanged();
            ComboBox_Font.SelectedIndex = ComboBox_Font.FindStringExact(ConsoleFont);
        }
        private void ConsoleFontSize_changed()
        {
            FontSettingChanged();
            ComboBox_Size.SelectedIndex = ComboBox_Size.FindStringExact(ConsoleFontSize.ToString());
        }
        private void ConsoleBold_changed()
        {
            FontSettingChanged();
            Button_Bold.BackColor = ConsoleBold ? ButtonPressed : ButtonUnPressed;
        }
        private void ConsoleItalics_changed()
        {
            FontSettingChanged();
            Button_Italics.BackColor = ConsoleItalics ? ButtonPressed : ButtonUnPressed;
        }
        private void ConsoleUnderlined_changed()
        {
            FontSettingChanged();
            Button_Underline.BackColor = ConsoleUnderlined ? ButtonPressed : ButtonUnPressed;
        }
        private void ConsoleStrikethrough_changed()
        {
            FontSettingChanged();
        }
        private void ConsoleEnabled_changed()
        {
            richTextBox1.Visible = ConsoleEnabled;
        }
        // Saving settings
        private void SaveLocation_changed()
        {
            CheckSaveLocation();
            TextBox_SaveLocation.Text = SaveLocation;
        }
        private void OpenLocation_changed()
        {
            CheckOpenLocation();
            TextBox_OpenLocation.Text = OpenLocation;
        }
        private bool CheckSaveLocation()
        {
            if(SaveLocation != null)
            {
                if(!Directory.Exists(SaveLocation))
                {
                    machineLearning.WriteLine("Save File location doesn't exist");
                    SaveLocation = null;
                    return false;
                }
            }
            return true;
        }
        private bool CheckOpenLocation()
        {
            if(OpenLocation != null)
            {
                if(!Directory.Exists(OpenLocation))
                {
                    machineLearning.WriteLine("Open File location doesn't exist");
                    OpenLocation = null;
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region User controls
        private void Button_Default_Click(object sender, EventArgs e)
        {
            // General Settings
            Antialiasing = default_Antialiasing;
            Progressbars = default_Progressbars;
            // Neural Network Settings
            AmountOfColumns_Min = default_AmountOfColumns_Min;
            AmountOfColumns_Max = default_AmountOfColumns_Max;
            AmountOfNeurons_Min = default_AmountOfNeurons_Min;
            AmountOfNeurons_Max = default_AmountOfNeurons_Max;
            PreferedAmountOfColumns = default_PreferedAmountOfColumns;
            Bias_Min = default_Bias_Min;
            Bias_Max = default_Bias_Max;
            Weight_Min = default_Weight_Min;
            Weight_Max = default_Weight_Max;
            // Console Settings
            ConsoleBackColor = default_ConsoleBackColor;
            ConsoleTextColor = default_ConsoleTextColor;
            ConsoleFont = default_ConsoleFont;
            ConsoleFontSize = default_ConsoleFontSize;
            ConsoleBold = default_ConsoleBold;
            ConsoleItalics = default_ConsoleItalics;
            ConsoleUnderlined = default_ConsoleUnderlined;
            ConsoleStrikethrough = default_ConsoleStrikethrough;
            ConsoleEnabled = default_ConsoleEnabled;
            // Saving settings
            SaveLocation = default_SaveLocation;
            OpenLocation = default_OpenLocation;
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            // General Settings
            Antialiasing = temp_Antialiasing;
            Progressbars = temp_Progressbars;
            // Neural Network Settings
            AmountOfColumns_Min = temp_AmountOfColumns_Min;
            AmountOfColumns_Max = temp_AmountOfColumns_Max;
            AmountOfNeurons_Min = temp_AmountOfNeurons_Min;
            AmountOfNeurons_Max = temp_AmountOfNeurons_Max;
            PreferedAmountOfColumns = temp_PreferedAmountOfColumns;
            Bias_Min = temp_Bias_Min;
            Bias_Max = temp_Bias_Max;
            Weight_Min = temp_Weight_Min;
            Weight_Max = temp_Weight_Max;
            // Console Settings
            ConsoleBackColor = temp_ConsoleBackColor;
            ConsoleTextColor = temp_ConsoleTextColor;
            ConsoleFont = temp_ConsoleFont;
            ConsoleFontSize = temp_ConsoleFontSize;
            ConsoleBold = temp_ConsoleBold;
            ConsoleItalics = temp_ConsoleItalics;
            ConsoleUnderlined = temp_ConsoleUnderlined;
            ConsoleStrikethrough = temp_ConsoleStrikethrough;
            ConsoleEnabled = temp_ConsoleEnabled;
            // Saving settings
            SaveLocation = temp_SaveLocation;
            OpenLocation = temp_OpenLocation;

            this.Close();
        }
        private void Button_OK_Click(object sender, EventArgs e)
        {
            ApplySettings();      // Apply current settings
            this.Close();
        }
        private void Button_Apply_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }
        #endregion  // End User controls

        #endregion  // End Form Functions


        public void ApplySettings()
        {
            SaveSettings();


        }

        public void SaveSettings()
        {

        }

        public void OpenSettings()
        {

        }
    }

}
