namespace MachineLearning1
{
    partial class ColorRecognitionHistory
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
            this.label_generateamount = new System.Windows.Forms.Label();
            this.Button_Generate = new System.Windows.Forms.Button();
            this.numericUpDown_generate = new System.Windows.Forms.NumericUpDown();
            this.Button_Open = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generate)).BeginInit();
            this.SuspendLayout();
            // 
            // label_generateamount
            // 
            this.label_generateamount.AutoSize = true;
            this.label_generateamount.Location = new System.Drawing.Point(13, 12);
            this.label_generateamount.Name = "label_generateamount";
            this.label_generateamount.Size = new System.Drawing.Size(142, 13);
            this.label_generateamount.TabIndex = 1;
            this.label_generateamount.Text = "Amount of data to generate: ";
            // 
            // Button_Generate
            // 
            this.Button_Generate.Location = new System.Drawing.Point(263, 7);
            this.Button_Generate.Name = "Button_Generate";
            this.Button_Generate.Size = new System.Drawing.Size(112, 23);
            this.Button_Generate.TabIndex = 2;
            this.Button_Generate.Text = "Generate Data";
            this.Button_Generate.UseVisualStyleBackColor = true;
            this.Button_Generate.Click += new System.EventHandler(this.Button_Generate_Click);
            // 
            // numericUpDown_generate
            // 
            this.numericUpDown_generate.Location = new System.Drawing.Point(155, 10);
            this.numericUpDown_generate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_generate.Name = "numericUpDown_generate";
            this.numericUpDown_generate.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown_generate.TabIndex = 3;
            // 
            // Button_Open
            // 
            this.Button_Open.Location = new System.Drawing.Point(476, 7);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(176, 23);
            this.Button_Open.TabIndex = 4;
            this.Button_Open.Text = "Open Color Recognition History";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(476, 36);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(176, 23);
            this.Button_Save.TabIndex = 5;
            this.Button_Save.Text = "Save Color Recognition History";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // ColorRecognitionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Open);
            this.Controls.Add(this.numericUpDown_generate);
            this.Controls.Add(this.Button_Generate);
            this.Controls.Add(this.label_generateamount);
            this.Name = "ColorRecognitionHistory";
            this.Text = "ColorRecognitionHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorRecognitionHistory_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_generateamount;
        private System.Windows.Forms.Button Button_Generate;
        private System.Windows.Forms.NumericUpDown numericUpDown_generate;
        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.Button Button_Save;
    }
}