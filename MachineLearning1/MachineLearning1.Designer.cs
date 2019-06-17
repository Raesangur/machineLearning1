using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearning1
{
    partial class MachineLearning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        int index_search = 0;
        List<Line> NeuralNetworkLines = new List<Line>();
        List<List<Button>> NeuralNetworkButtons = new List<List<Button>>();
        List<List<TextBox>> NeuralNetworkTextboxes = new List<List<TextBox>>() {new List<TextBox>(), new List<TextBox>()};
        ProgressBar ShowingProgressBar = new ProgressBar();

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
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_ClearConsole = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button_DeleteNetwork = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Open = new System.Windows.Forms.Button();
            this.Button_generation = new System.Windows.Forms.Button();
            this.Button_HideNetwork = new System.Windows.Forms.Button();
            this.button_Calculation = new System.Windows.Forms.Button();
            this.buttonNeuralNetwork = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_NewNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_DeleteNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_SaveNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_OpenNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_View = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_ShowNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_HideNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_ClearConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Projects = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_ColorRecognition = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_More = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_About = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 27);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.AutoScroll = true;
            this.SplitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.AutoScroll = true;
            this.SplitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.SplitContainer1.Size = new System.Drawing.Size(1942, 744);
            this.SplitContainer1.SplitterDistance = 771;
            this.SplitContainer1.SplitterIncrement = 10;
            this.SplitContainer1.SplitterWidth = 8;
            this.SplitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.button_Next);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.label_search);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button_ClearConsole);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 740);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console";
            // 
            // button_Next
            // 
            this.button_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Next.Location = new System.Drawing.Point(477, 707);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(60, 23);
            this.button_Next.TabIndex = 6;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_search.Location = new System.Drawing.Point(400, 707);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // label_search
            // 
            this.label_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(10, 712);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(99, 13);
            this.label_search.TabIndex = 2;
            this.label_search.Text = "Search in Console: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(9, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(748, 683);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(115, 709);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button_ClearConsole
            // 
            this.button_ClearConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClearConsole.Location = new System.Drawing.Point(616, 707);
            this.button_ClearConsole.Name = "button_ClearConsole";
            this.button_ClearConsole.Size = new System.Drawing.Size(141, 23);
            this.button_ClearConsole.TabIndex = 0;
            this.button_ClearConsole.Text = "Clear Console";
            this.button_ClearConsole.UseVisualStyleBackColor = true;
            this.button_ClearConsole.Click += new System.EventHandler(this.Button_Clearconsole_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.Panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1159, 740);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neural Network";
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.AutoSize = true;
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.Controls.Add(this.Button_DeleteNetwork);
            this.Panel1.Controls.Add(this.Button_Save);
            this.Panel1.Controls.Add(this.Button_Open);
            this.Panel1.Controls.Add(this.Button_generation);
            this.Panel1.Controls.Add(this.Button_HideNetwork);
            this.Panel1.Controls.Add(this.button_Calculation);
            this.Panel1.Controls.Add(this.buttonNeuralNetwork);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 16);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1153, 721);
            this.Panel1.TabIndex = 7;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Button_DeleteNetwork
            // 
            this.Button_DeleteNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_DeleteNetwork.Location = new System.Drawing.Point(122, 688);
            this.Button_DeleteNetwork.Name = "Button_DeleteNetwork";
            this.Button_DeleteNetwork.Size = new System.Drawing.Size(110, 23);
            this.Button_DeleteNetwork.TabIndex = 6;
            this.Button_DeleteNetwork.Text = "Delete Network";
            this.Button_DeleteNetwork.UseVisualStyleBackColor = true;
            this.Button_DeleteNetwork.Click += new System.EventHandler(this.Button_DeleteNetwork_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Save.Location = new System.Drawing.Point(1037, 688);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(110, 23);
            this.Button_Save.TabIndex = 5;
            this.Button_Save.Text = "Save Network";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Open
            // 
            this.Button_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Open.Location = new System.Drawing.Point(921, 688);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(110, 23);
            this.Button_Open.TabIndex = 4;
            this.Button_Open.Text = "Open Network";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // Button_generation
            // 
            this.Button_generation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_generation.Location = new System.Drawing.Point(6, 688);
            this.Button_generation.Name = "Button_generation";
            this.Button_generation.Size = new System.Drawing.Size(110, 23);
            this.Button_generation.TabIndex = 3;
            this.Button_generation.Text = "Generate Network";
            this.Button_generation.UseVisualStyleBackColor = true;
            this.Button_generation.Click += new System.EventHandler(this.Button_generation_Click);
            // 
            // Button_HideNetwork
            // 
            this.Button_HideNetwork.Enabled = false;
            this.Button_HideNetwork.Location = new System.Drawing.Point(122, 12);
            this.Button_HideNetwork.Name = "Button_HideNetwork";
            this.Button_HideNetwork.Size = new System.Drawing.Size(110, 23);
            this.Button_HideNetwork.TabIndex = 2;
            this.Button_HideNetwork.Text = "Hide Network";
            this.Button_HideNetwork.UseVisualStyleBackColor = true;
            this.Button_HideNetwork.Click += new System.EventHandler(this.Button_HideNetwork_Click);
            // 
            // button_Calculation
            // 
            this.button_Calculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Calculation.Location = new System.Drawing.Point(1037, 11);
            this.button_Calculation.Name = "button_Calculation";
            this.button_Calculation.Size = new System.Drawing.Size(110, 23);
            this.button_Calculation.TabIndex = 1;
            this.button_Calculation.Text = "Calculate";
            this.button_Calculation.UseVisualStyleBackColor = true;
            this.button_Calculation.Click += new System.EventHandler(this.Button_Calculation_Click);
            // 
            // buttonNeuralNetwork
            // 
            this.buttonNeuralNetwork.Location = new System.Drawing.Point(6, 12);
            this.buttonNeuralNetwork.Name = "buttonNeuralNetwork";
            this.buttonNeuralNetwork.Size = new System.Drawing.Size(110, 23);
            this.buttonNeuralNetwork.TabIndex = 0;
            this.buttonNeuralNetwork.Text = "Show Network";
            this.buttonNeuralNetwork.UseVisualStyleBackColor = true;
            this.buttonNeuralNetwork.Click += new System.EventHandler(this.ButtonNeuralNetwork_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_File,
            this.MenuStrip_View,
            this.MenuStrip_Projects,
            this.MenuStrip_More});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(197, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuStrip_File
            // 
            this.MenuStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_NewNetwork,
            this.MenuStrip_DeleteNetwork,
            this.MenuStrip_SaveNetwork,
            this.MenuStrip_OpenNetwork,
            this.MenuStrip_Exit});
            this.MenuStrip_File.Name = "MenuStrip_File";
            this.MenuStrip_File.Size = new System.Drawing.Size(37, 20);
            this.MenuStrip_File.Text = "File";
            // 
            // MenuStrip_NewNetwork
            // 
            this.MenuStrip_NewNetwork.Name = "MenuStrip_NewNetwork";
            this.MenuStrip_NewNetwork.Size = new System.Drawing.Size(155, 22);
            this.MenuStrip_NewNetwork.Text = "New Network";
            this.MenuStrip_NewNetwork.Click += new System.EventHandler(this.MenuStrip_NewNetwork_Click);
            // 
            // MenuStrip_DeleteNetwork
            // 
            this.MenuStrip_DeleteNetwork.Name = "MenuStrip_DeleteNetwork";
            this.MenuStrip_DeleteNetwork.Size = new System.Drawing.Size(155, 22);
            this.MenuStrip_DeleteNetwork.Text = "Delete Network";
            this.MenuStrip_DeleteNetwork.Click += new System.EventHandler(this.MenuStrip_DeleteNetwork_Click);
            // 
            // MenuStrip_SaveNetwork
            // 
            this.MenuStrip_SaveNetwork.Name = "MenuStrip_SaveNetwork";
            this.MenuStrip_SaveNetwork.Size = new System.Drawing.Size(155, 22);
            this.MenuStrip_SaveNetwork.Text = "Save Network";
            this.MenuStrip_SaveNetwork.Click += new System.EventHandler(this.MenuStrip_SaveNetwork_Click);
            // 
            // MenuStrip_OpenNetwork
            // 
            this.MenuStrip_OpenNetwork.Name = "MenuStrip_OpenNetwork";
            this.MenuStrip_OpenNetwork.Size = new System.Drawing.Size(155, 22);
            this.MenuStrip_OpenNetwork.Text = "Open Network";
            this.MenuStrip_OpenNetwork.Click += new System.EventHandler(this.MenuStrip_OpenNetwork_Click);
            // 
            // MenuStrip_Exit
            // 
            this.MenuStrip_Exit.Name = "MenuStrip_Exit";
            this.MenuStrip_Exit.Size = new System.Drawing.Size(155, 22);
            this.MenuStrip_Exit.Text = "Exit";
            this.MenuStrip_Exit.Click += new System.EventHandler(this.MenuStrip_Exit_Click);
            // 
            // MenuStrip_View
            // 
            this.MenuStrip_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_ShowNetwork,
            this.MenuStrip_HideNetwork,
            this.MenuStrip_ClearConsole});
            this.MenuStrip_View.Name = "MenuStrip_View";
            this.MenuStrip_View.Size = new System.Drawing.Size(44, 20);
            this.MenuStrip_View.Text = "View";
            // 
            // MenuStrip_ShowNetwork
            // 
            this.MenuStrip_ShowNetwork.Name = "MenuStrip_ShowNetwork";
            this.MenuStrip_ShowNetwork.Size = new System.Drawing.Size(151, 22);
            this.MenuStrip_ShowNetwork.Text = "Show Network";
            this.MenuStrip_ShowNetwork.Click += new System.EventHandler(this.MenuStrip_ShowNetwork_Click);
            // 
            // MenuStrip_HideNetwork
            // 
            this.MenuStrip_HideNetwork.Name = "MenuStrip_HideNetwork";
            this.MenuStrip_HideNetwork.Size = new System.Drawing.Size(151, 22);
            this.MenuStrip_HideNetwork.Text = "Hide Network";
            this.MenuStrip_HideNetwork.Click += new System.EventHandler(this.MenuStrip_HideNetwork_Click);
            // 
            // MenuStrip_ClearConsole
            // 
            this.MenuStrip_ClearConsole.Name = "MenuStrip_ClearConsole";
            this.MenuStrip_ClearConsole.Size = new System.Drawing.Size(151, 22);
            this.MenuStrip_ClearConsole.Text = "Clear Console";
            this.MenuStrip_ClearConsole.Click += new System.EventHandler(this.MenuStrip_ClearConsole_Click);
            // 
            // MenuStrip_Projects
            // 
            this.MenuStrip_Projects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_ColorRecognition});
            this.MenuStrip_Projects.Name = "MenuStrip_Projects";
            this.MenuStrip_Projects.Size = new System.Drawing.Size(61, 20);
            this.MenuStrip_Projects.Text = "Projects";
            // 
            // MenuStrip_ColorRecognition
            // 
            this.MenuStrip_ColorRecognition.Name = "MenuStrip_ColorRecognition";
            this.MenuStrip_ColorRecognition.Size = new System.Drawing.Size(167, 22);
            this.MenuStrip_ColorRecognition.Text = "ColorRecognition";
            this.MenuStrip_ColorRecognition.Click += new System.EventHandler(this.MenuStrip_ColorRecognition_Click);
            // 
            // MenuStrip_More
            // 
            this.MenuStrip_More.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_About,
            this.MenuStrip_Settings});
            this.MenuStrip_More.Name = "MenuStrip_More";
            this.MenuStrip_More.Size = new System.Drawing.Size(47, 20);
            this.MenuStrip_More.Text = "More";
            // 
            // MenuStrip_About
            // 
            this.MenuStrip_About.Name = "MenuStrip_About";
            this.MenuStrip_About.Size = new System.Drawing.Size(116, 22);
            this.MenuStrip_About.Text = "About";
            this.MenuStrip_About.Click += new System.EventHandler(this.MenuStrip_About_Click);
            // 
            // MenuStrip_Settings
            // 
            this.MenuStrip_Settings.Name = "MenuStrip_Settings";
            this.MenuStrip_Settings.Size = new System.Drawing.Size(116, 22);
            this.MenuStrip_Settings.Text = "Settings";
            this.MenuStrip_Settings.Click += new System.EventHandler(this.MenuStrip_Settings_Click);
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.WorkerReportsProgress = true;
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.BackgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            // 
            // MachineLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1949, 777);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MachineLearning";
            this.Text = "MachineLearning1";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer SplitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNeuralNetwork;
        private System.Windows.Forms.Button button_Calculation;
        private System.Windows.Forms.Button button_ClearConsole;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_Next;
        private Button Button_HideNetwork;
        private Button Button_generation;
        private Button Button_Open;
        private Button Button_Save;
        private Button Button_DeleteNetwork;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem MenuStrip_File;
        private ToolStripMenuItem MenuStrip_NewNetwork;
        private ToolStripMenuItem MenuStrip_DeleteNetwork;
        private ToolStripMenuItem MenuStrip_SaveNetwork;
        private ToolStripMenuItem MenuStrip_OpenNetwork;
        private ToolStripMenuItem MenuStrip_Exit;
        private ToolStripMenuItem MenuStrip_View;
        private ToolStripMenuItem MenuStrip_ShowNetwork;
        private ToolStripMenuItem MenuStrip_HideNetwork;
        private ToolStripMenuItem MenuStrip_ClearConsole;
        private ToolStripMenuItem MenuStrip_Projects;
        private ToolStripMenuItem MenuStrip_ColorRecognition;
        private ToolStripMenuItem MenuStrip_More;
        private ToolStripMenuItem MenuStrip_About;
        private ToolStripMenuItem MenuStrip_Settings;
        private BackgroundWorker BackgroundWorker1;
        private Panel Panel1;
    }
}

