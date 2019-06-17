using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearning1
{
    partial class ColorRecognition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Random RandColor = new Random();
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
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.Button_Enter = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.Button_Random = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_RGB = new System.Windows.Forms.Label();
            this.numericUpDown_B = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_G = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_R = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_ShowHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_SaveHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.exitColorRecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_ExitColorRecognition = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_NewColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_RandColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_More = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_About = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_R)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorDialog
            // 
            this.ColorDialog.AnyColor = true;
            this.ColorDialog.FullOpen = true;
            // 
            // Button_Enter
            // 
            this.Button_Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Enter.Location = new System.Drawing.Point(62, 325);
            this.Button_Enter.Name = "Button_Enter";
            this.Button_Enter.Size = new System.Drawing.Size(241, 75);
            this.Button_Enter.TabIndex = 0;
            this.Button_Enter.Text = "Enter";
            this.Button_Enter.UseVisualStyleBackColor = true;
            this.Button_Enter.Click += new System.EventHandler(this.Button_Enter_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColorBox.Location = new System.Drawing.Point(62, 125);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(241, 200);
            this.ColorBox.TabIndex = 1;
            this.ColorBox.TabStop = false;
            this.ColorBox.Click += new System.EventHandler(this.ColorBox_Click);
            // 
            // Button_Random
            // 
            this.Button_Random.Location = new System.Drawing.Point(62, 50);
            this.Button_Random.Name = "Button_Random";
            this.Button_Random.Size = new System.Drawing.Size(241, 75);
            this.Button_Random.TabIndex = 2;
            this.Button_Random.Text = "Random Color";
            this.Button_Random.UseVisualStyleBackColor = true;
            this.Button_Random.Click += new System.EventHandler(this.Button_Random_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label_RGB);
            this.groupBox1.Controls.Add(this.numericUpDown_B);
            this.groupBox1.Controls.Add(this.numericUpDown_G);
            this.groupBox1.Controls.Add(this.numericUpDown_R);
            this.groupBox1.Controls.Add(this.Button_Random);
            this.groupBox1.Controls.Add(this.ColorBox);
            this.groupBox1.Controls.Add(this.Button_Enter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 450);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // label_RGB
            // 
            this.label_RGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_RGB.AutoSize = true;
            this.label_RGB.Location = new System.Drawing.Point(1, 430);
            this.label_RGB.Name = "label_RGB";
            this.label_RGB.Size = new System.Drawing.Size(33, 13);
            this.label_RGB.TabIndex = 5;
            this.label_RGB.Text = "RGB:";
            // 
            // numericUpDown_B
            // 
            this.numericUpDown_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_B.Location = new System.Drawing.Point(246, 426);
            this.numericUpDown_B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_B.Name = "numericUpDown_B";
            this.numericUpDown_B.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_B.TabIndex = 4;
            // 
            // numericUpDown_G
            // 
            this.numericUpDown_G.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_G.Location = new System.Drawing.Point(140, 426);
            this.numericUpDown_G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_G.Name = "numericUpDown_G";
            this.numericUpDown_G.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_G.TabIndex = 4;
            // 
            // numericUpDown_R
            // 
            this.numericUpDown_R.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_R.Location = new System.Drawing.Point(34, 426);
            this.numericUpDown_R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_R.Name = "numericUpDown_R";
            this.numericUpDown_R.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_R.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_File,
            this.MenuStrip_Color,
            this.MenuStrip_More});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStrip_File
            // 
            this.MenuStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_ShowHistory,
            this.MenuStrip_Delete,
            this.MenuStrip_SaveHistory,
            this.MenuStrip_Open,
            this.exitColorRecToolStripMenuItem,
            this.MenuStrip_ExitColorRecognition,
            this.MenuStrip_Exit});
            this.MenuStrip_File.Name = "MenuStrip_File";
            this.MenuStrip_File.Size = new System.Drawing.Size(37, 20);
            this.MenuStrip_File.Text = "File";
            // 
            // MenuStrip_ShowHistory
            // 
            this.MenuStrip_ShowHistory.Name = "MenuStrip_ShowHistory";
            this.MenuStrip_ShowHistory.Size = new System.Drawing.Size(247, 22);
            this.MenuStrip_ShowHistory.Text = "Show Color Recognition History";
            this.MenuStrip_ShowHistory.Click += new System.EventHandler(this.MenuStrip_ShowHistory_Click);
            // 
            // MenuStrip_Delete
            // 
            this.MenuStrip_Delete.Name = "MenuStrip_Delete";
            this.MenuStrip_Delete.Size = new System.Drawing.Size(247, 22);
            this.MenuStrip_Delete.Text = "Delete Color Recognition History";
            this.MenuStrip_Delete.Click += new System.EventHandler(this.MenuStrip_Delete_Click);
            // 
            // MenuStrip_SaveHistory
            // 
            this.MenuStrip_SaveHistory.Name = "MenuStrip_SaveHistory";
            this.MenuStrip_SaveHistory.Size = new System.Drawing.Size(247, 22);
            this.MenuStrip_SaveHistory.Text = "Save Color Recognition History";
            this.MenuStrip_SaveHistory.Click += new System.EventHandler(this.MenuStrip_SaveHistory_Click);
            // 
            // MenuStrip_Open
            // 
            this.MenuStrip_Open.Name = "MenuStrip_Open";
            this.MenuStrip_Open.Size = new System.Drawing.Size(247, 22);
            this.MenuStrip_Open.Text = "Open Color Recognition History";
            this.MenuStrip_Open.Click += new System.EventHandler(this.MenuStrip_Open_Click);
            // 
            // exitColorRecToolStripMenuItem
            // 
            this.exitColorRecToolStripMenuItem.Name = "exitColorRecToolStripMenuItem";
            this.exitColorRecToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.exitColorRecToolStripMenuItem.Text = " ";
            // 
            // MenuStrip_ExitColorRecognition
            // 
            this.MenuStrip_ExitColorRecognition.Name = "MenuStrip_ExitColorRecognition";
            this.MenuStrip_ExitColorRecognition.Size = new System.Drawing.Size(247, 22);
            this.MenuStrip_ExitColorRecognition.Text = "Exit Color Recognition";
            this.MenuStrip_ExitColorRecognition.Click += new System.EventHandler(this.MenuStrip_ExitColorRecognition_Click);
            // 
            // MenuStrip_Exit
            // 
            this.MenuStrip_Exit.Name = "MenuStrip_Exit";
            this.MenuStrip_Exit.Size = new System.Drawing.Size(247, 22);
            this.MenuStrip_Exit.Text = "Exit";
            this.MenuStrip_Exit.Click += new System.EventHandler(this.MenuStrip_Exit_Click);
            // 
            // MenuStrip_Color
            // 
            this.MenuStrip_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_NewColor,
            this.MenuStrip_RandColor});
            this.MenuStrip_Color.Name = "MenuStrip_Color";
            this.MenuStrip_Color.Size = new System.Drawing.Size(48, 20);
            this.MenuStrip_Color.Text = "Color";
            // 
            // MenuStrip_NewColor
            // 
            this.MenuStrip_NewColor.Name = "MenuStrip_NewColor";
            this.MenuStrip_NewColor.Size = new System.Drawing.Size(151, 22);
            this.MenuStrip_NewColor.Text = "New Color";
            this.MenuStrip_NewColor.Click += new System.EventHandler(this.MenuStrip_NewColor_Click);
            // 
            // MenuStrip_RandColor
            // 
            this.MenuStrip_RandColor.Name = "MenuStrip_RandColor";
            this.MenuStrip_RandColor.Size = new System.Drawing.Size(151, 22);
            this.MenuStrip_RandColor.Text = "Random Color";
            this.MenuStrip_RandColor.Click += new System.EventHandler(this.MenuStrip_RandColor_Click);
            // 
            // MenuStrip_More
            // 
            this.MenuStrip_More.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Help,
            this.MenuStrip_About});
            this.MenuStrip_More.Name = "MenuStrip_More";
            this.MenuStrip_More.Size = new System.Drawing.Size(24, 20);
            this.MenuStrip_More.Text = "?";
            // 
            // MenuStrip_Help
            // 
            this.MenuStrip_Help.Name = "MenuStrip_Help";
            this.MenuStrip_Help.Size = new System.Drawing.Size(107, 22);
            this.MenuStrip_Help.Text = "Help";
            // 
            // MenuStrip_About
            // 
            this.MenuStrip_About.Name = "MenuStrip_About";
            this.MenuStrip_About.Size = new System.Drawing.Size(107, 22);
            this.MenuStrip_About.Text = "About";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(684, 450);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 450);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outputs";
            // 
            // ColorRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 488);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ColorRecognition";
            this.Text = "ColorRecognition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorRecognition_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_R)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button Button_Enter;
        private System.Windows.Forms.PictureBox ColorBox;
        private Button Button_Random;
        private GroupBox groupBox1;
        private Label label_RGB;
        private NumericUpDown numericUpDown_B;
        private NumericUpDown numericUpDown_G;
        private NumericUpDown numericUpDown_R;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuStrip_File;
        private ToolStripMenuItem MenuStrip_ShowHistory;
        private ToolStripMenuItem MenuStrip_Delete;
        private ToolStripMenuItem MenuStrip_SaveHistory;
        private ToolStripMenuItem MenuStrip_Open;
        private ToolStripMenuItem exitColorRecToolStripMenuItem;
        private ToolStripMenuItem MenuStrip_ExitColorRecognition;
        private ToolStripMenuItem MenuStrip_Exit;
        private ToolStripMenuItem MenuStrip_Color;
        private ToolStripMenuItem MenuStrip_NewColor;
        private ToolStripMenuItem MenuStrip_RandColor;
        private ToolStripMenuItem MenuStrip_More;
        private ToolStripMenuItem MenuStrip_Help;
        private ToolStripMenuItem MenuStrip_About;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
    }
}