using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearning1
{
    public partial class Savefile : Form
    {
        SaveFileDialog saveFileDialog_NeuralNetwork;
        OpenFileDialog openFileDialog_NeuralNetwork;
        SaveFileDialog saveFileDialog_ColorRecognition;
        OpenFileDialog openFileDialog_ColorRecognition;
        SaveFileDialog saveFileDialog_Settings;
        OpenFileDialog openFileDialog_Settings;

        string defaultSettingsName = "Settings";

        MachineLearning machinelearning;

        public Savefile(MachineLearning parent)
        {
            machinelearning = parent;
            InitializeComponent();
            InitializeDialogs();
        }

        private void InitializeDialogs()
        {

            string date = DateTime.Today.ToString("yyyy-MM-dd");

            // Settings
            saveFileDialog_Settings = new SaveFileDialog()
            {
                Filter = "Machine Learning Settings| *.mls",
                Title = "Save your settings",
                DefaultExt = ".mls",
                FileName = "Settings",
                RestoreDirectory = true,
                InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath),
            };
            openFileDialog_Settings = new OpenFileDialog()
            {
                Filter = "Machine Learning Settings| *.mls",
                Title = "Open your settings",
                DefaultExt = ".mls",
                FileName = "Settings",
                RestoreDirectory = true,
                InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath),
            };

            // Neural Networks
            saveFileDialog_NeuralNetwork = new SaveFileDialog()
            {
                Filter = "Neural Networks | *.nn",
                Title = "Save a Neural Network",
                DefaultExt = ".nn",
                FileName = date.ToString(),
                RestoreDirectory = true,
                InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath),
            };
            openFileDialog_NeuralNetwork = new OpenFileDialog()
            {
                Filter = "Neural Networks | *.nn",
                Title = "Open a Neural Network",
                DefaultExt = ".nn",
                RestoreDirectory = true,
                InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath),
            };

           // Color Recognition files
           saveFileDialog_ColorRecognition = new SaveFileDialog()
            {
              Filter = "Color Recognition Files | *.cr",
              Title = "Save Color Recognition data",
              DefaultExt = ".cr",
              FileName = date.ToString(),
              RestoreDirectory = true,
              InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath),
            };
            openFileDialog_ColorRecognition = new OpenFileDialog()
            {
                Filter = "Color Recognition Files | *.cr",
                Title = "Load Color Recognition data",
                DefaultExt = ".cr",
                RestoreDirectory = true,
                InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath),
            };
        }

        #region Neural Networks
        public void Save_NeuralNetwork()
        {
            saveFileDialog_NeuralNetwork.ShowDialog();
            if (saveFileDialog_NeuralNetwork.FileName == "")
            {
                machinelearning.WriteLine("Couldn't save file");
                return;
            }

            StreamWriter wr = new StreamWriter(saveFileDialog_NeuralNetwork.OpenFile());
            wr.WriteLine(richTextBox1.Text);

            wr.Dispose();
            wr.Close();

            Clear();
        }
        public void Open_NeuralNetwork()
        {
            StreamReader rd;
            Clear();
            if (openFileDialog_NeuralNetwork.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rd = new StreamReader(openFileDialog_NeuralNetwork.OpenFile());
                    richTextBox1.Text = rd.ReadToEnd();
                }
                catch { }
            }
        }
        #endregion
        #region Color Recognition
        public void Save_ColorRecognition()
        {
            saveFileDialog_ColorRecognition.ShowDialog();
            if (saveFileDialog_ColorRecognition.FileName == "")
            {
                machinelearning.WriteLine("Couldn't save file");
                return;
            }

            StreamWriter wr = new StreamWriter(saveFileDialog_ColorRecognition.OpenFile());
            wr.WriteLine(richTextBox1.Text);

            wr.Dispose();
            wr.Close();

            Clear();
        }
        public void Open_ColorRecognition()
        {
            StreamReader rd;
            Clear();
            if (openFileDialog_ColorRecognition.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rd = new StreamReader(openFileDialog_ColorRecognition.FileName);
                    richTextBox1.Text = rd.ReadToEnd();
                }
                catch { }
            }
        }
        #endregion
        #region Settings
        public void Save_Settings()
        {
            try
            {
                saveFileDialog_Settings.FileName = saveFileDialog_Settings.InitialDirectory + "\\" + defaultSettingsName + "." + saveFileDialog_Settings.DefaultExt;
                if((saveFileDialog_Settings.FileName == "") || (saveFileDialog_Settings.FileName == null))
                {
                    machinelearning.WriteLine("Couldn't save settings; empty file location");
                    return;
                }
                if (!File.Exists(saveFileDialog_Settings.FileName))
                {
                    machinelearning.WriteLine("Couldn't save settings; file doesn't exists");
                    return;
                }

                StreamWriter wr = new StreamWriter(saveFileDialog_Settings.OpenFile());
                wr.WriteLine(richTextBox1.Text);

                wr.Dispose();
                wr.Close();

                Clear();
            }
            catch
            {
                machinelearning.WriteLine("Couldn't save settings");
            }
        }
        public int Open_Settings()
        {
            StreamReader rd;
            Clear();


            openFileDialog_Settings.FileName = openFileDialog_Settings.InitialDirectory + "\\" + defaultSettingsName + "." + openFileDialog_Settings.DefaultExt;
            if ((openFileDialog_Settings.FileName == "") || (openFileDialog_Settings.FileName == null))
            {
                machinelearning.WriteLine("Couldn't open settings; empty file location");
                return 2;
            }
            if (!File.Exists(openFileDialog_Settings.FileName))
            {
                machinelearning.WriteLine("Couldn't open settings; file doesn't exists... attempting creation");
                try
                {
                    File.Create(openFileDialog_Settings.FileName);
                }
                catch
                {
                    WriteLine("Couldn't create file");
                    return 2;
                }
                if (File.Exists(openFileDialog_Settings.FileName))
                {
                    machinelearning.WriteLine("Applying default settings");
                    return 1;
                }
            }
            if(openFileDialog_NeuralNetwork.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rd = new StreamReader(openFileDialog_NeuralNetwork.OpenFile());
                    richTextBox1.Text = rd.ReadToEnd();
                }
                catch { }
            }

            return 0;
        }
        #endregion
        #region Textbox methods
        public void Clear()
        {
            richTextBox1.Clear();
        }

        public void Write(string String)
        {
            richTextBox1.AppendText(String);
        }

        public string Read(int linenumber, int size)
        {
            richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(linenumber), size);
            return richTextBox1.SelectedText;
        }
        public string ReadLine(int linenumber)
        {
            richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(linenumber), (richTextBox1.GetFirstCharIndexFromLine(linenumber + 1) - richTextBox1.GetFirstCharIndexFromLine(linenumber)) - 1);
            return richTextBox1.SelectedText;
        }

        public void WriteLine(string String)
        {
            richTextBox1.AppendText(String);
            NextLine();
        }

        public void NextLine()
        {
            richTextBox1.AppendText("\n");
        }
        #endregion
    }
}
