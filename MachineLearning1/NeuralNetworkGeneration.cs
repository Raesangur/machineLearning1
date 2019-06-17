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
    public partial class NeuralNetworkGeneration : Form
    {
        public bool Existing = false;
        MachineLearning machineLearning;

        public List<ComboBox> Neuron_Columns = new List<ComboBox>();
        public List<ComboBox> Connection_Weights = new List<ComboBox>();
        public List<List<NumericUpDown>> Neuron_Biases = new List<List<NumericUpDown>>();
        public List<List<double>> Biases = new List<List<double>>();
        public List<List<double>> Weights = new List<List<double>>();


        public NeuralNetworkGeneration(MachineLearning parent)
        {
            Existing = true;
            machineLearning = parent;
            InitializeComponent();
        }

        #region Generation
        public void GenerateNeuronsInColumns()
        {
            CleanAll();
            machineLearning.Neuron_AmountInColumn.Clear();

            machineLearning.Columns = ComboBox_Columns.SelectedIndex + 2;

            for (int i = 0; i <= machineLearning.Columns - 1; i++)
            {
                int Column = new int();
                machineLearning.Neuron_AmountInColumn.Add(Column);

                ComboBox C = new ComboBox()
                {
                    Location = new Point(69 * i + 13, 88),
                    Size = new Size(63, 21),
                    TabIndex = 0,
                    Tag = i,
                    Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                };
                C.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" });
                C.SelectedValueChanged += new EventHandler(ComboBox_Neuron_SelectedValueChanged);
                this.Controls.Add(C);
                Neuron_Columns.Add(C);
                C.BringToFront();

                List<NumericUpDown> Biases = new List<NumericUpDown>();
                Neuron_Biases.Add(Biases);
            }
            GenerateConnections();
        }
        public void GenerateBiasInColumn(int column)
        {
            CleanBiasesTextboxes(column);

            machineLearning.Neuron_AmountInColumn[column] = Neuron_Columns[column].SelectedIndex + 1;

            for (int i = 0; i <= machineLearning.Neuron_AmountInColumn[column] - 1; i++)
            {
                NumericUpDown N = new NumericUpDown()
                {
                    Location = new Point(69 * (column) + 13, (i * 25) + 113),
                    Size = new Size(63, 20),
                    Maximum = new decimal(new int[] { 5, 0, 0, 0 }),
                    Minimum = new decimal(new int[] { 5, 0, 0, -2147483648 }),
                    DecimalPlaces = 2,
                    Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                };
                Neuron_Biases[column].Add(N);
                this.Controls.Add(N);
                N.BringToFront();
            }
        }
        public void GenerateConnections()
        {
            CleanConnectionWeights();
            for (int i = 1; i <= machineLearning.Columns - 1; i++)
            {
                ComboBox W = new ComboBox()
                {
                    Location = new Point(69 * (i-1) + 42, 513),
                    Size = new Size(63, 21),
                    Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
                };
                Connection_Weights.Add(W);
                this.Controls.Add(W);
                W.BringToFront();
            }
        }
        public void GenerateWeights()
        {
            Random Rand = new Random();
            for (int i = 0; i <= machineLearning.Columns - 2; i++)
            {
                List<double> D = new List<double>();
                Weights.Add(D);
            }
            for (int i = 0; i <= machineLearning.Columns - 2; i++)  // Generating random weights for each connections in each column
            {
                foreach (NumericUpDown N in Neuron_Biases[i])
                {
                    foreach (NumericUpDown Out in Neuron_Biases[i + 1])
                    {
                        //Weights[i].Add(Convert.ToDouble(string.Format("{0:0.00}", Rand.NextDouble() * 5)));
                        Weights[i].Add(Convert.ToDouble(string.Format("{0:0.00}", (Rand.NextDouble() - 0.5) * 4)));
                    }
                }
            }
            for (int i = 0; i <= machineLearning.Columns - 2; i++)
            {
                foreach (double W in Weights[i])
                {
                    Connection_Weights[i].Items.Add(W);
                }
            }
        }
        #endregion
        

        #region Form functions
        private void Button_Random_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();

            CleanAll();

            ComboBox_Columns.SelectedIndex = Rand.Next(0, 5);       // Generating random column amount
            GenerateNeuronsInColumns();

            foreach (ComboBox C in Neuron_Columns)                  // Generating random neurons amount in each column
            {
                C.SelectedIndex = Rand.Next(1, 16);
                GenerateBiasInColumn((int)C.Tag);
            }

            for (int i = 0; i <= machineLearning.Columns - 1; i++)      // Generating random biases for each neurons in each column
            {
                foreach (NumericUpDown N in Neuron_Biases[i])
                {
                    //N.Value = Decimal.Parse(string.Format("{0:0.00}", Rand.NextDouble() * 5));
                    N.Value = Decimal.Parse(string.Format("{0:0.00}", (Rand.NextDouble() -0.5) * 4));
                }
            }

            GenerateWeights();
            
        }

        private void Button_generation_Click(object sender, EventArgs e)
        {
            try
            {
                if (machineLearning.NeuronsList[0].Count != 0)
                {
                    machineLearning.WriteLine("Neurons already exists");
                    return;
                }
            }
            catch
            {
                machineLearning.WriteLine("Neurons already exists");
            }
            foreach (ComboBox C in Neuron_Columns)
            {
                if (C.SelectedItem == null)
                {
                    machineLearning.WriteLine("Please select a number of neurons");
                    return;
                }
            }

            foreach (ComboBox C in Neuron_Columns)
            {
                machineLearning.Neuron_AmountInColumn[(int)C.Tag] = C.SelectedIndex + 1;
            }
            GenerateWeights();
            machineLearning.CreateNeurons();
            machineLearning.CreateConnections();
        }

        private void ComboBox_Columns_SelectedValueChanged(object sender, EventArgs e)
        {            
            GenerateNeuronsInColumns();
            label_NeuronsPerColumn.Visible = true;
        }
        private void ComboBox_Neuron_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox C = sender as ComboBox;
            GenerateBiasInColumn((int)C.Tag);
        }
        private void NeuralNetworkGeneration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Existing = false;
            this.Hide();
            e.Cancel = true;
        }

        #endregion

        #region Cleanups
        public void CleanAll()
        {
            CleanNeuronColumns();
            CleanBiasesTextboxes();
            CleanConnectionWeights();
            CleanWeights();
            CleanBiases();
        }
        public void CleanNeuronColumns()
        {
            foreach (ComboBox C in Neuron_Columns)
            {
                C.Items.Clear();
                this.Controls.Remove(C);
                C.Dispose();
            }
            Neuron_Columns.Clear();
        }
        public void CleanBiasesTextboxes()
        {
            try
            {
                foreach (List<NumericUpDown> L in Neuron_Biases)
                {
                    foreach (NumericUpDown N in L)
                    {
                        this.Controls.Remove(N);
                        N.Dispose();
                    }
                    L.Clear();
                }
                Neuron_Biases.Clear();
            }
            catch { }
        }
        public void CleanBiasesTextboxes(int column)
        {
            try
            {

                foreach (NumericUpDown N in Neuron_Biases[column])
                {
                    this.Controls.Remove(N);
                    N.Dispose();
                }
                Neuron_Biases[column].Clear();
            }
            catch { }
        }
        public void CleanConnectionWeights()
        {
            foreach (ComboBox C in Connection_Weights)
            {
                C.Items.Clear();
                this.Controls.Remove(C);
                C.Dispose();
            }
            Connection_Weights.Clear();
        }
        public void CleanWeights()
        {
            foreach (List<Double> L in Weights)
            {
                L.Clear();
            }
            Weights.Clear();
        }
        public void CleanBiases()
        {
            foreach (List<Double> L in Biases)
            {
                L.Clear();
            }
            Biases.Clear();
        }
        #endregion
    }
}
