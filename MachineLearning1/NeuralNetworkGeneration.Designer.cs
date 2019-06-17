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
    partial class NeuralNetworkGeneration
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
            this.label_NeuronsPerColumn = new System.Windows.Forms.Label();
            this.button_generation = new System.Windows.Forms.Button();
            this.Button_Random = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_columns = new System.Windows.Forms.Label();
            this.ComboBox_Columns = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NeuronsPerColumn
            // 
            this.label_NeuronsPerColumn.AutoSize = true;
            this.label_NeuronsPerColumn.Location = new System.Drawing.Point(12, 72);
            this.label_NeuronsPerColumn.Name = "label_NeuronsPerColumn";
            this.label_NeuronsPerColumn.Size = new System.Drawing.Size(107, 13);
            this.label_NeuronsPerColumn.TabIndex = 4;
            this.label_NeuronsPerColumn.Text = "Neurons per columns";
            this.label_NeuronsPerColumn.Visible = false;
            // 
            // button_generation
            // 
            this.button_generation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_generation.Location = new System.Drawing.Point(428, 38);
            this.button_generation.Name = "button_generation";
            this.button_generation.Size = new System.Drawing.Size(106, 23);
            this.button_generation.TabIndex = 5;
            this.button_generation.Text = "Generate Neurons";
            this.button_generation.UseVisualStyleBackColor = true;
            this.button_generation.Click += new System.EventHandler(this.Button_generation_Click);
            // 
            // Button_Random
            // 
            this.Button_Random.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Random.Location = new System.Drawing.Point(428, 67);
            this.Button_Random.Name = "Button_Random";
            this.Button_Random.Size = new System.Drawing.Size(106, 23);
            this.Button_Random.TabIndex = 6;
            this.Button_Random.Text = "Random";
            this.Button_Random.UseVisualStyleBackColor = true;
            this.Button_Random.Click += new System.EventHandler(this.Button_Random_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.button_generation);
            this.groupBox1.Controls.Add(this.Button_Random);
            this.groupBox1.Controls.Add(this.label_columns);
            this.groupBox1.Controls.Add(this.ComboBox_Columns);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 544);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neural Network Generation";
            // 
            // label_columns
            // 
            this.label_columns.AutoSize = true;
            this.label_columns.Location = new System.Drawing.Point(9, 22);
            this.label_columns.Name = "label_columns";
            this.label_columns.Size = new System.Drawing.Size(100, 13);
            this.label_columns.TabIndex = 11;
            this.label_columns.Text = "Columns of neurons";
            // 
            // ComboBox_Columns
            // 
            this.ComboBox_Columns.FormattingEnabled = true;
            this.ComboBox_Columns.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ComboBox_Columns.Location = new System.Drawing.Point(10, 38);
            this.ComboBox_Columns.Name = "ComboBox_Columns";
            this.ComboBox_Columns.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Columns.TabIndex = 10;
            this.ComboBox_Columns.SelectedValueChanged += new System.EventHandler(this.ComboBox_Columns_SelectedValueChanged);
            // 
            // NeuralNetworkGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(540, 544);
            this.Controls.Add(this.label_NeuronsPerColumn);
            this.Controls.Add(this.groupBox1);
            this.Name = "NeuralNetworkGeneration";
            this.Text = "NeuralNetworkGeneration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NeuralNetworkGeneration_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label_NeuronsPerColumn;
        private System.Windows.Forms.Button button_generation;
        private Button Button_Random;
        private GroupBox groupBox1;
        private Label label_columns;
        public ComboBox ComboBox_Columns;
    }
}