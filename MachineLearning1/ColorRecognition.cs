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
    public partial class ColorRecognition : Form
    {
        public int Red; public int Green; public int Blue;
        public MachineLearning machineLearning;
        public ColorRecognitionHistory History;

        public List<NumericUpDown> OutputValues = new List<NumericUpDown>();
        public List<RadioButton> Output = new List<RadioButton>();

        public string[] Colors = new string[16] { "White", "Light Grey", "Dark Grey", "Black", "Red", "Light Green", "Dark Green", "Light Blue", "Dark Blue", "Yellow", "Pink", "Turquoise", "Brown", "Orange", "Purple", "Other" };

        public ColorRecognition(MachineLearning parent)
        {
            History = new ColorRecognitionHistory(this);
            machineLearning = parent;

            InitializeComponent();
            ChangeColorBox((byte)RandColor.Next(0, 255), (byte)RandColor.Next(0, 255), (byte)RandColor.Next(0, 255));
        }


        #region Form methods
        private void ColorRecognition_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (NumericUpDown N in OutputValues)
            {
                groupBox2.Controls.Remove(N);
                N.Dispose();
            }
            OutputValues.Clear();
            foreach (RadioButton R in Output)
            {
                groupBox2.Controls.Remove(R);
                R.Dispose();
            }
            Output.Clear();
            foreach(FlowLayoutPanel L in groupBox2.Controls)
            {
                groupBox2.Controls.Remove(L);
                L.Dispose();
            }
            this.Hide();
            e.Cancel = true;
        }

        public void ChangeColorBox(byte R, byte G, byte B)
        {
            ColorBox.BackColor = Color.FromArgb(R, G, B);
            numericUpDown_R.Value = R;
            numericUpDown_G.Value = G;
            numericUpDown_B.Value = B;

            Red = R;
            Green = G;
            Blue = B;
        }
        public void ColorBox_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            ChangeColorBox(ColorDialog.Color.R, ColorDialog.Color.G, ColorDialog.Color.B);
        }
        public void Button_Enter_Click(object sender, EventArgs e)
        {
            machineLearning.ClearInputsOutputs();
            // Inputs data into network
            try
            {
                machineLearning.NeuronsList[0][0].Input = Convert.ToDouble(numericUpDown_R.Value / 100);
                machineLearning.NeuronsList[0][1].Input = Convert.ToDouble(numericUpDown_G.Value / 100);
                machineLearning.NeuronsList[0][2].Input = Convert.ToDouble(numericUpDown_B.Value / 100);
                machineLearning.WriteLine("Inputing data into neural network. R: " + (numericUpDown_R.Value / 100) + " G: " + (numericUpDown_G.Value / 100) + " B: " + (numericUpDown_B.Value / 100));
            }
            catch
            {
                machineLearning.WriteLine("Couldn't input data into neural network");
                return;
            }

            // Calculate data
            machineLearning.NeuralNetworkCalculation();

            // Outputs data
            try
            {
                decimal maxData = 0;
                foreach(Neuron N in machineLearning.NeuronsList[machineLearning.Columns - 1])
                {
                    OutputValues[machineLearning.NeuronsList[machineLearning.Columns - 1].IndexOf(N)].Value = Convert.ToDecimal(N.Output);
                }
                foreach(NumericUpDown N in OutputValues)
                {
                    if (N.Value > maxData)
                    {
                        maxData = N.Value;
                        foreach (RadioButton R in Output)
                        {
                            R.Checked = false;
                        }
                        Output[OutputValues.IndexOf(N)].Checked = true;
                    }
                }
            }
            catch
            {
                machineLearning.WriteLine("Couldn't display outputted data");
                return;
            }
        }
        public void Button_Random_Click(object sender, EventArgs e)
        {
            ChangeColorBox((byte)RandColor.Next(0, 255), (byte)RandColor.Next(0, 255), (byte)RandColor.Next(0, 255));
        }
        
        public void GenerateOutputs()
        {
            for (int i = 0; i < machineLearning.Neuron_AmountInColumn[machineLearning.Columns - 1]; i++)
            {
                FlowLayoutPanel F = new FlowLayoutPanel()
                {
                    Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left),
                    Location = new Point(50, 59 + (23 * i)),
                    Size = new Size(200, 25),
                    TabIndex = 0,
                    WrapContents = false,
                    Name = "FlowLayoutPanel" + i,
                };
                this.groupBox2.Controls.Add(F);
                F.BringToFront();

                NumericUpDown N = new NumericUpDown()
                {
                    DecimalPlaces = 2,
                    Location = new Point(0, 0),
                    Maximum = new decimal(new int[] { 5, 0, 0, 0 }),
                    Minimum = new decimal(new int[] { 5, 0, 0, -2147483648 }),
                    Name = "numericUpDown_Output" + Colors[i],
                    Size = new Size(50, 20),
                    AutoSize = false,
                    Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left),
                };
                OutputValues.Add(N);
                

                RadioButton R = new RadioButton()
                {
                    AutoSize = true,
                    Location = new Point((OutputValues[i].Location.X + OutputValues[i].Size.Width) + 7, OutputValues[i].Location.Y),
                    Name = "radioButton" + Colors[i],
                    Size = new Size(53, 17),
                    Text = Colors[i],
                    Anchor = AnchorStyles.None,
                    Tag = false,
                };
                Output.Add(R);
                F.Controls.Add(R);
                R.BringToFront();
                F.Controls.Add(N);
                N.BringToFront();
            }
        }


        #region Menu
        private void MenuStrip_ShowHistory_Click(object sender, EventArgs e)
        {
            History.Show();
        }
        private void MenuStrip_ExitColorRecognition_Click(object sender, EventArgs e)
        {
            History.Close();
            this.Close();
        }
        private void MenuStrip_Exit_Click(object sender, EventArgs e)
        {
            machineLearning.Close();
        }
        private void MenuStrip_Delete_Click(object sender, EventArgs e)
        {
            History.ClearHistory();
        }
        private void MenuStrip_SaveHistory_Click(object sender, EventArgs e)
        {
            History.SaveColorHistory();
            machineLearning.saveFile.Save_ColorRecognition();
        }
        private void MenuStrip_Open_Click(object sender, EventArgs e)
        {
            machineLearning.saveFile.Open_ColorRecognition();
            History.OpenColorHistory();
            History.CreateTextboxes();
        }
        private void MenuStrip_NewColor_Click(object sender, EventArgs e)
        {
            ColorBox_Click(sender, e);
        }
        private void MenuStrip_RandColor_Click(object sender, EventArgs e)
        {
            Button_Random_Click(sender, e);
        }
        #endregion

        #endregion

    }
}
