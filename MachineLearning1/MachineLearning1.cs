using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* TODO:
 *  - Loading/Progress bars
 *      - Neural Network Generation
 *      - Color Recognition Dataset generation
 *      - Loading and saving
 *          - Neural Network
 *          - Color Recognition History
 *          - Settings
 *          
 *  - Complete settings
 *      - Appearance tab
 *          - Antialiasing
 *          - Themes
 *              - Dark Theme
 *              - Grey Theme
 *              - Light Theme
 *              - Blue Theme
 *              - Custom
 *          - Highlights
 *      - Bind variables with rest of project
 *      - Save settings and load them at the begginning of project
 *      
 *  - Fix input textboxes
 *      - Make text appear within them
 *      - Allow user to input
 *      - NumericUpDown?
 *      
 *  - NeuralNetwork class
 */

namespace MachineLearning1
{
    public partial class MachineLearning : Form
    {
        public bool MachineLearningReady = true;
        public string Version = "Version 2";
        public Savefile saveFile;
        public Settings settings;
        public NeuralNetworkGeneration neuralNetworkGeneration;
        public ColorRecognition colorRecognition;

        public int Columns;
        public List<int> Neuron_AmountInColumn = new List<int>();
        public List<List<Neuron>> NeuronsList = new List<List<Neuron>>();
        public List<List<Connection>> ConnectionList = new List<List<Connection>>();
        public bool NetworkExisting = false;

        public MachineLearning()
        {
            Console.WriteLine("------------------------- PROGRAM START -------------------------");
            InitializeComponent();

            saveFile = new Savefile(this);
            settings = new Settings(this);
            neuralNetworkGeneration = new NeuralNetworkGeneration(this);
            colorRecognition = new ColorRecognition(this);

            this.Enabled = false;
            while(MachineLearningReady == false) { }
            this.Enabled = true;
            saveFile.WriteLine("This a test, waddup");
            saveFile.Save_Settings();
        }


        public void CreateNeurons()
        {
            WriteLine("Creating neurons");
            for (int i = 0; i <= Columns - 1; i++)
            {
                List<Neuron> NList = new List<Neuron>();
                NeuronsList.Add(NList);
                for (int j = 1; j <= Neuron_AmountInColumn[i]; j++)
                {
                    Neuron neuron = new Neuron(this, "Neuron_" + i + "_" + j, i, j + ((6 - Neuron_AmountInColumn[i]) / 2), (double)neuralNetworkGeneration.Neuron_Biases[i][j - 1].Value);
                    NList.Add(neuron);
                }
            }            
        }
        public void CreateConnections()
        {
            int j = 0;
            for (int i = 0; i <= Columns - 2; i++)
            {
                List<Connection> CList = new List<Connection>();
                ConnectionList.Add(CList);
                foreach (Neuron NeuronOut in NeuronsList[i])
                {
                    foreach (Neuron NeuronIn in NeuronsList[i+1])
                    {
                        Connection connection = new Connection(this, ("C_" + NeuronOut.Name + "_" + NeuronIn.Name), NeuronOut, NeuronIn, neuralNetworkGeneration.Weights[i][j]);
                        CList.Add(connection);
                        j++;
                    }
                }
                j = 0;
            }

            NetworkExisting = true;
        }
        public void ClearInputsOutputs()
        {
            foreach (List<Neuron> L in NeuronsList)
            {
                foreach (Neuron N in L)
                {
                    N.Input = 0;
                    N.Output = 0;
                }
            }
        }

        public void NeuralNetworkCalculation()
        {
            try
            {
                WriteLine("Calculating values of the network");
                for (int i = 0; i <= Columns - 1; i++)
                {
                    foreach (Neuron N in NeuronsList[i])
                    {
                        N.Calculation();
                    }
                }
            }
            catch
            {
                WriteLine("No Neural Network to calculate");
            }
            int AmountOfCharactersInTextbox = 5;
            try
            {               // Inputs
                foreach (TextBox T in NeuralNetworkTextboxes[0])
                {
                    Neuron N = T.Tag as Neuron;
                    if (N.Input < 0)
                    {
                        AmountOfCharactersInTextbox = 6;
                    }
                    else
                    {
                        AmountOfCharactersInTextbox = 5;
                    }
                    T.AllowDrop = true;
                    T.Text = N.Input.ToString().Substring(0, AmountOfCharactersInTextbox);
                }
            }
            catch
            {
                WriteLine("Couldn't display input");
            }
            try
            {               // Outputs
                foreach (TextBox T in NeuralNetworkTextboxes[1])
                {
                    Neuron N = T.Tag as Neuron;
                    if (N.Output < 0)
                    {
                        AmountOfCharactersInTextbox = 6;
                    }
                    else
                    {
                        AmountOfCharactersInTextbox = 5;
                    }
                    T.Text = N.Output.ToString().Substring(0, AmountOfCharactersInTextbox);
                }
            }
            catch
            {
                WriteLine("Couldn't display output");
            }
        }
        public static double Sigmoid(double value)
        {
            double k = Math.Exp(value);
            //return ((-1.0 / 1.0f + k) + 1);
            return ((1 / (1.0f + k)) - 0.5f) * -2.0f;
        }

        #region Saving and opening networks
        public void SaveNetwork()
        {
            saveFile.Clear();
            string date = DateTime.Today.ToString("yyyy-MM-dd");

            saveFile.WriteLine(Version);
            saveFile.WriteLine(date);

            saveFile.WriteLine(Columns + " columns in Network");
            for (int i = 0; i <= Columns - 1; i++)
            {
                saveFile.WriteLine(Neuron_AmountInColumn[i].ToString() + " Neurons in Column " + i);
            }

            
            for (int i = 0; i <= Columns - 1; i++)
            {
                saveFile.WriteLine("Column " + (i + 1) + " neurons biases:");
                foreach (Neuron N in NeuronsList[i])
                {
                    saveFile.WriteLine(string.Format("{0:0.00}", N.Bias.ToString()));
                }
            }

            for(int i = 0; i <= Columns - 2; i++)
            {
                saveFile.WriteLine("Connection weights columns " + (i + 1) + " to " + (i + 2));
                foreach (Connection C in ConnectionList[i])
                {
                    saveFile.WriteLine(string.Format("{0:0.00}", C.Weight));
                }
            }
            saveFile.WriteLine("END");
        }

        public void OpenNetwork()
        {
            WriteLine("Opened " + saveFile.ReadLine(0) + " Neural Network file");
            if (!saveFile.ReadLine(0).Equals(Version))
            {
                WriteLine(saveFile.ReadLine(0) + " file is incompatible with current version : " + Version);
                return;
            }
            WriteLine("Neural Network Saved on " + saveFile.ReadLine(1));

            DeleteNetwork();

            WriteLine("There are " + saveFile.ReadLine(2));
            Columns = Int32.Parse(saveFile.Read(2, 1));
            
            neuralNetworkGeneration.ComboBox_Columns.SelectedIndex = Columns - 2;
            neuralNetworkGeneration.GenerateNeuronsInColumns();

            
            WriteLine("Neural Network contains ");
            for (int i = 0; i<= Columns - 1; i++)
            {
                Write(saveFile.ReadLine(3 + i) + ", ");
                string Amount = new string(saveFile.ReadLine(3 + i).Where(char.IsDigit).ToArray());
                Amount = Amount.Remove(Amount.Length - 1);
                Neuron_AmountInColumn[i] = Int32.Parse(Amount);
                //Neuron_AmountInColumn[i] = Int32.Parse(saveFile.Read(3 + i, 1));
                neuralNetworkGeneration.Neuron_Columns[i].SelectedIndex = Neuron_AmountInColumn[i] - 1;
                neuralNetworkGeneration.GenerateBiasInColumn(i);
            }

            int j = 4 + Columns;
            for (int k = 0; k <= Columns - 1; k++)
            {
                for (int i = 0; i <= Neuron_AmountInColumn[k] - 1; i++)
                {
                    neuralNetworkGeneration.Neuron_Biases[k][i].Value = (decimal)Convert.ToDouble(saveFile.ReadLine(j));
                    j++;
                }
                j++;
            }
            WriteLine("");
            WriteLine("Neurons opened");

            neuralNetworkGeneration.GenerateWeights();
            for (int i = 0; i <= Columns - 2; i++)
            {
                for (int k = 0; k <= (Neuron_AmountInColumn[i] * Neuron_AmountInColumn[i + 1]) - 1; k++)
                {
                    neuralNetworkGeneration.Weights[i].Add(Convert.ToDouble(saveFile.ReadLine(j)));
                    j++;
                }
                j++;
            }
            int l = 0;
            foreach (ComboBox C in neuralNetworkGeneration.Connection_Weights)
            {
                foreach (double W in neuralNetworkGeneration.Weights[l])
                {
                    C.Items.Add(W);
                }

            }

            if (!saveFile.ReadLine(j).Equals("END"))
            {
                WriteLine("Reading error!");
            }
            try
            {
                CreateNeurons();
                CreateConnections();
            }
            catch { }
        }

        public void DeleteNetwork()
        {
            WriteLine("Deleting current Neural Network");
            HideNeuralNetwork();
            buttonNeuralNetwork.Enabled = true;
            Button_HideNetwork.Enabled = false;

            neuralNetworkGeneration.label_NeuronsPerColumn.Visible = false;
            foreach (List<Button> LB in NeuralNetworkButtons)
            {
                foreach (Button B in LB)
                {
                    Panel1.Controls.Remove(B);
                }
                LB.Clear();
            }
            foreach (List<TextBox> LT in NeuralNetworkTextboxes)
            {
                foreach (TextBox T in LT)
                {
                    Panel1.Controls.Remove(T);
                }
                LT.Clear();
            }
            NeuralNetworkButtons.Clear();
            NeuralNetworkLines.Clear();
            NeuralNetworkTextboxes[0].Clear();
            NeuralNetworkTextboxes[1].Clear();

            try
            {
                for (int i = 0; i <= Columns - 1; i++)              // Clearing Neurons
                {
                    Neuron_AmountInColumn[i] = 0;
                    NeuronsList[i].Clear();
                }
            }
            catch
            {
                WriteLine("No Neurons to clear");
            }
            Neuron_AmountInColumn.Clear();
            NeuronsList.Clear();

            try
            {
                for (int i = 0; i <= Columns - 2; i++)          // Clearning connections
                {
                    ConnectionList[i].Clear();
                }
            }
            catch
            {
                WriteLine("No Connections to clear");
            }
            ConnectionList.Clear();

            try
            {
                for (int i = 0; i <= Columns; i++)
                {
                    foreach (NumericUpDown N in neuralNetworkGeneration.Neuron_Biases[i])
                    {
                        neuralNetworkGeneration.Controls.Remove(N);
                    }
                    neuralNetworkGeneration.Neuron_Biases[i].Clear();
                }
            }
            catch { }

            foreach (ComboBox C in neuralNetworkGeneration.Neuron_Columns)
            {
                C.Items.Clear();
                neuralNetworkGeneration.Controls.Remove(C);
            }
            foreach (ComboBox C in neuralNetworkGeneration.Connection_Weights)
            {
                C.Items.Clear();
                neuralNetworkGeneration.Controls.Remove(C);
            }
            foreach (List<Double> L in neuralNetworkGeneration.Weights)
            {
                L.Clear();
            }
            
            neuralNetworkGeneration.Neuron_Biases.Clear();

            Columns = 0;
            neuralNetworkGeneration.ComboBox_Columns.SelectedItem = null;

            neuralNetworkGeneration.Existing = false;

            NetworkExisting = false;
        }
        #endregion

        #region Form functions
        private void HideNeuralNetwork()
        {
            NeuralNetworkLines.Clear();
            foreach (List<Button> LB in NeuralNetworkButtons)
            {
                foreach (Button button in LB)
                {
                    Panel1.Controls.Remove(button);
                    button.Dispose();
                }
            }
            foreach (List<TextBox> LT in NeuralNetworkTextboxes)
            {
                foreach(TextBox T in LT)
                {
                    Panel1.Controls.Remove(T);
                    T.Dispose();
                }
                LT.Clear();
            }
            Panel1.Controls.Remove(ShowingProgressBar);
            Panel1.Invalidate();
        }
        private void ShowNeuralNetwork()
        {
            // Progress bar
            try
            {
                ShowingProgressBar.Name = "Showing Network Progressbar";
                ShowingProgressBar.Size = new Size((int)(0.8f * Panel1.Size.Width), 23);
                ShowingProgressBar.Location = new Point(((int)(Panel1.Size.Width / 2f) - (int)(ShowingProgressBar.Size.Width / 2f)), 790);
                ShowingProgressBar.Maximum = 1;
                ShowingProgressBar.Value = 1;

                Panel1.Controls.Add(ShowingProgressBar);
                ShowingProgressBar.BringToFront();
                for (int i = 0; i < Columns; i++)
                {
                    ShowingProgressBar.Maximum += Neuron_AmountInColumn[i];
                }
                for (int i = 0; i < Columns - 1; i++)
                {
                    ShowingProgressBar.Maximum += ConnectionList[i].Count;
                }
                ShowingProgressBar.Maximum += Neuron_AmountInColumn[0];
                ShowingProgressBar.Maximum += Neuron_AmountInColumn[Columns - 1];
            }
            catch
            {
                WriteLine("Could not display Neural Network");
                try
                {
                    Panel1.Controls.Remove(ShowingProgressBar);
                }
                catch { }
                return;
            }
            try
            {
                Graphics g = this.CreateGraphics();
                // Buttons
                for (int i = 0; i <= Columns - 1; i++)
                {
                    List<Button> LB = new List<Button>();
                    NeuralNetworkButtons.Add(LB);
                    foreach (Neuron N in NeuronsList[i])
                    {
                        Button button = new Button()
                        {
                            Name = "Button" + N.Name,
                            TabIndex = 1,
                            Size = new Size(100, 25),
                            Location = new Point(67 + (200 * N.Column), 240 + (50 * N.Row)),
                            Text = N.Name,
                            UseVisualStyleBackColor = true,
                            Tag = N,
                        };
                        N.Button = button;
                        button.Click += new EventHandler(ButtonNeuron_popup);
                        NeuralNetworkButtons[N.Column].Add(button);
                        Panel1.Controls.Add(button);
                        button.BringToFront();
                        ShowingProgressBar.Value++;
                    }
                }

                // Connections
                for (int i = 0; i < Columns - 1; i++)
                {
                    foreach (Connection C in ConnectionList[i])
                    {
                        Line newLine = new Line();
                        // Y = 100
                        newLine.Point1.X = (C.NeuronIn.Button as Button).Location.X + (C.NeuronIn.Button as Button).Size.Width;
                        newLine.Point1.Y = (C.NeuronIn.Button as Button).Location.Y + ((C.NeuronIn.Button as Button).Size.Height / 2);
                        newLine.Point2.X = (C.NeuronOut.Button as Button).Location.X;
                        newLine.Point2.Y = (C.NeuronOut.Button as Button).Location.Y + ((C.NeuronOut.Button as Button).Size.Height / 2);

                        NeuralNetworkLines.Add(newLine);
                        Panel1.Invalidate();
                        ShowingProgressBar.Value++;
                    }
                }
                // Textboxes Input
                foreach (Neuron N in NeuronsList[0])
                {
                    TextBox T = new TextBox()
                    {
                        Name = "Textbox Input " + N.Name,
                        Size = new Size(48, 20),
                        Location = new Point(((N.Button as Button).Location.X) - (48 + 10), ((N.Button as Button).Location.Y + 2)),
                        MaxLength = 5,
                        Tag = N,
                    };
                    NeuralNetworkTextboxes[0].Add(T);
                    Panel1.Controls.Add(T);
                    T.BringToFront();
                    ShowingProgressBar.Value++;
                }
                // Textboxes Output
                foreach (Neuron N in NeuronsList[Columns - 1])
                {
                    TextBox T = new TextBox()
                    {
                        Name = "Textbox Output " + N.Name,
                        Size = new Size(48, 20),
                        Location = new Point(((N.Button as Button).Location.X) + ((N.Button as Button).Size.Width + 10), ((N.Button as Button).Location.Y + 2)),
                        MaxLength = 5,
                        Tag = N,
                        AllowDrop = false,          // This is dirty code. It's used as a flag to see whether the value is changed by the user or by a update to the value
                        
                };
                    T.TextChanged += new EventHandler(TextBoxInput_TextChanged);
                    NeuralNetworkTextboxes[1].Add(T);
                    Panel1.Controls.Add(T);
                    T.BringToFront();
                    ShowingProgressBar.Value++;
                }
            }
            catch
            {
                WriteLine("Could not display Neural Network");
            }
            Panel1.Controls.Remove(ShowingProgressBar);
            //ShowingProgressBar.Dispose();
            //this.Update();
            Panel1.Update();
        }

        public void WriteLine(string text)
        {
            richTextBox1.AppendText(text);
            richTextBox1.AppendText(Environment.NewLine);
            Console.WriteLine(text);
        }
        public void Write(string text)
        {
            richTextBox1.AppendText(text);
            Console.Write(text);
        }

        #region Buttons
        private void ButtonNeuralNetwork_Click(object sender, EventArgs e)
        {
            WriteLine("Displaying Neural Network");
            ShowNeuralNetwork();
            buttonNeuralNetwork.Enabled = false;
            Button_HideNetwork.Enabled = true;
        }
        private void Button_HideNetwork_Click(object sender, EventArgs e)
        {
            WriteLine("Hiding Neural Network");
            HideNeuralNetwork();
            buttonNeuralNetwork.Enabled = true;
            Button_HideNetwork.Enabled = false;
        }
        private void Button_Calculation_Click(object sender, EventArgs e)
        {
            NeuralNetworkCalculation();
        }
        private void Button_Clearconsole_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
            button_Next.Visible = false;
        }
        private void Button_generation_Click(object sender, EventArgs e)
        {
            try
            {
                neuralNetworkGeneration.Show();
            }
            catch { }
        }
        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveNetwork();
            saveFile.Save_NeuralNetwork();
        }
        private void Button_Open_Click(object sender, EventArgs e)
        {
            saveFile.Open_NeuralNetwork();
            OpenNetwork();
        }
        private void Button_DeleteNetwork_Click(object sender, EventArgs e)
        {
            DeleteNetwork();
        }
        private void ButtonNeuron_popup(object sender, EventArgs e)
        {
            Button B = sender as Button;
            Neuron neuron = B.Tag as Neuron;
            WriteLine(neuron.Name + " information");

            string message = "";

            message += neuron.Name + Environment.NewLine;
            message += "Input: " + neuron.Input + Environment.NewLine;
            message += "Output: " + neuron.Output + Environment.NewLine;
            message += "Bias: " + neuron.Bias + Environment.NewLine;
            message += neuron.ConnectionsIn.Count + " Input Connection(s):" + Environment.NewLine;
            foreach (Connection C in neuron.ConnectionsIn)
            {
                message += C.Name + ": " + C.Weight + ", outpus: " + C.NeuronIn.Output + Environment.NewLine;
            }
            message += neuron.ConnectionsOut.Count + " Output Connection(s):" + Environment.NewLine;
            foreach (Connection C in neuron.ConnectionsOut)
            {
                message += C.Name + ": " + C.Weight + Environment.NewLine;
            }


            try
            {
                MessageBox.Show(message);
            }
            catch
            {
                WriteLine("Could not display neuron information");
            }
        }
        #endregion

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ShowingProgressBar == null)
            {
                return;
            }

            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 0; i <= ShowingProgressBar.Maximum; i++)
            {
                worker.ReportProgress(i);
                System.Threading.Thread.Sleep(100);
            }
        }
        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ShowingProgressBar.Value = e.ProgressPercentage;
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //SplitContainer1_Paint(sender, e);
            foreach (Line line in NeuralNetworkLines)
            {
                e.Graphics.DrawLine(line.blackPen, line.Point1, line.Point2);
            }
        }

        #region MenuStrip
        private void MenuStrip_NewNetwork_Click(object sender, EventArgs e)
        {
            Button_generation_Click(sender, e);
        }
        private void MenuStrip_DeleteNetwork_Click(object sender, EventArgs e)
        {
            DeleteNetwork();
        }
        private void MenuStrip_SaveNetwork_Click(object sender, EventArgs e)
        {
            Button_Save_Click(sender, e);
        }
        private void MenuStrip_OpenNetwork_Click(object sender, EventArgs e)
        {
            Button_Open_Click(sender, e);
        }
        private void MenuStrip_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MenuStrip_ShowNetwork_Click(object sender, EventArgs e)
        {
            ButtonNeuralNetwork_Click(sender, e);
        }
        private void MenuStrip_HideNetwork_Click(object sender, EventArgs e)
        {
            Button_HideNetwork_Click(sender, e);
        }
        private void MenuStrip_ClearConsole_Click(object sender, EventArgs e)
        {
            Button_Clearconsole_Click(sender, e);
        }
        private void MenuStrip_About_Click(object sender, EventArgs e)
        {
            string message = "";
            message += "MachineLearning, " + Version + Environment.NewLine;
            message += "By : Pascal-Emmanuel Lachance" + Environment.NewLine;
            message += "Project start : 2018-12-22" + Environment.NewLine + Environment.NewLine;
            message += "Goal of the project: Learning more about Neural Networks and Machine Learning" + Environment.NewLine;
            message += "No API or libraries were used in this project; everything is made from scratch by me" + Environment.NewLine;

            try
            {
                MessageBox.Show(message);
            }
            catch
            {
                WriteLine("Could not display project informations");
            }
        }
        private void MenuStrip_Settings_Click(object sender, EventArgs e)
        {
            settings.Show();
            settings.Display();
        }
        private void MenuStrip_ColorRecognition_Click(object sender, EventArgs e)
        {
            // Does the network exist?
            if(NetworkExisting == false)
            {
                WriteLine("You need a neural network to use this project");
                return;
            }

            // Proper inputs?
            try
            {
                if(Neuron_AmountInColumn[0] < 3)
                {
                    WriteLine("Neural Network doesn't have the proper amount of input neurons. (Needs at least 3)");
                    return;
                }
            }
            catch
            {
                WriteLine("Couldn't verify neural network outputs");
                return;
            }

            // Proper outputs?
            try
            {
                if(Neuron_AmountInColumn[Columns - 1] > 16)
                {
                    WriteLine("Neural Network is too big. (Maximum amount of output is 16)");
                    return;
                }
            }
            catch
            {
                WriteLine("Couldn't verify neural network ouputs");
                return;
            }


            try
            {
                colorRecognition.Show();
                colorRecognition.GenerateOutputs();
            }
            catch { }
        }
        #endregion
        #endregion

        #region Search engine
        private void Button_search_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Select(index_search, textBox1.Text.Length);
                richTextBox1.SelectionBackColor = Color.Black;
                richTextBox1.SelectionColor = Color.White;
            }
            catch { }
            index_search = 0;
            if (textBox1.Text == null)
            {
                WriteLine("Search box is empty");
                return;
            }
            if (textBox1.Text == "")
            {
                WriteLine("Search box is empty");
                return;
            }
            if (textBox1.Modified == false)
            {
                WriteLine("Search box is empty");
                return;
            }

            button_Next.Visible = true;
            try
            {
                index_search = richTextBox1.Find(textBox1.Text);
            }
            catch
            {
                WriteLine("Error while searching");
                return;
            }
            try
            {
                richTextBox1.Select(index_search, textBox1.Text.Length);
                richTextBox1.SelectionBackColor = Color.Yellow;
                richTextBox1.SelectionColor = Color.Black;
            }
            catch
            {
                WriteLine("Error while selecting");
                return;
            }
        }
        private void Button_Next_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Black;
            richTextBox1.SelectionColor = Color.White;
            try
            {
                index_search += textBox1.Text.Length;
                index_search = richTextBox1.Find(textBox1.Text, index_search, RichTextBoxFinds.MatchCase);
            }
            catch
            {
                WriteLine("Error while searching");
                return;
            }
            try
            {
                richTextBox1.Select(index_search, textBox1.Text.Length);
                richTextBox1.SelectionBackColor = Color.Yellow;
                richTextBox1.SelectionColor = Color.Black;
            }
            catch
            {
                WriteLine("Could not find result, restarting from top");
                return;
            }
        }

        #endregion

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            Neuron N = T.Tag as Neuron;
            if (T.AllowDrop == true)       // This is dirty code. It's used as a flag to see whether the value is changed by the user or by a update to the value
            {
                T.AllowDrop = false;
                return;
            }
            else
            {
                try
                {
                    N.Input = Convert.ToDouble(T.Text);
                }
                catch { }
            }
        }
    }
}
