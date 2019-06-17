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
    public partial class ColorRecognitionHistory : Form
    {
        public string Version = "Version 1";
        ColorRecognition colorRecognition;
        public List<List<string>> history = new List<List<string>>();
        public List<string> output = new List<string>();
        public List<List<TextBox>> TextHistory = new List<List<TextBox>>();
        public List<PictureBox> ColorHistory = new List<PictureBox>();
        public List<ComboBox> OutputHistory = new List<ComboBox>();

        public ColorRecognitionHistory(ColorRecognition parent)
        {
            colorRecognition = parent;
            InitializeComponent();
        }

        private void RandomPopulation(int rows)
        {
            Random Rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                List<string> H = new List<string>();
                string Red = Rand.Next(0, 255).ToString();
                string Green = Rand.Next(0, 255).ToString();
                string Blue = Rand.Next(0, 255).ToString();
                H.Add(Red); H.Add(Green); H.Add(Blue);
                history.Add(H);
            }
        }

        public void ClearHistory()
        {
            foreach (List<TextBox> L in TextHistory)
            {
                foreach (TextBox T in L)
                {
                    Controls.Remove(ColorHistory[L.IndexOf(T)]);
                    ColorHistory[L.IndexOf(T)].Dispose();
                    T.Clear();
                    Controls.Remove(T);
                    T.Dispose();
                }
                L.Clear();
            }

            foreach (PictureBox P in ColorHistory)
            {
                Controls.Remove(P);
            }

            foreach (ComboBox C in OutputHistory)
            {
                Controls.Remove(C);
            }
            OutputHistory.Clear();
            ColorHistory.Clear();
            TextHistory.Clear();
            history.Clear();
            output.Clear();
        }

        public void CreateTextboxes()
        {
            foreach (List<string> H in history) // Creating textboxes for each rows
            {
                List<TextBox> LT = new List<TextBox>();
                TextHistory.Add(LT);
                foreach (string S in H)
                {
                    TextBox T = new TextBox()
                    {
                        Location = new Point(30 + (110 * H.IndexOf(S)), 50 + (20 * history.IndexOf(H))),
                        Size = new Size(100, 20),
                        Text = S.ToString(),
                    };
                    TextHistory[history.IndexOf(H)].Add(T);
                    this.Controls.Add(T);
                    T.Show();
                    T.BringToFront();
                }
            }
            foreach(List<TextBox> L in TextHistory)
            {
                PictureBox P = new PictureBox()
                {
                    Location = new Point(10, 50 + (20 * TextHistory.IndexOf(L))),
                    Size = new Size(20, 20),
                    BackColor = new Color()
                };
                P.BackColor = Color.FromArgb(Convert.ToInt32(L[0].Text),
                                                Convert.ToInt32(L[1].Text),
                                                Convert.ToInt32(L[2].Text));
                ColorHistory.Add(P);
                this.Controls.Add(P);
                P.Show();
                P.BringToFront();

                ComboBox C = new ComboBox()
                {
                    Location = new Point(360, 50 + (20 * TextHistory.IndexOf(L))),
                    Size = new Size(100, 20),
                };
                C.Items.AddRange(colorRecognition.Colors);
                OutputHistory.Add(C);
                this.Controls.Add(C);
                C.Show();
                C.BringToFront();
                if (OutputHistory.IndexOf(C) < output.Count)
                {
                    C.SelectedItem = output[OutputHistory.IndexOf(C)];
                }
            }
        }


        #region Save and open color history
        public void SaveColorHistory()
        {
            colorRecognition.machineLearning.saveFile.Clear();
            string date = DateTime.Today.ToString("yyyy-MM-dd");

            colorRecognition.machineLearning.saveFile.WriteLine(Version);
            colorRecognition.machineLearning.saveFile.WriteLine(date);

            colorRecognition.machineLearning.saveFile.WriteLine(ColorHistory.Count + " elements in the color history");

            int i = 1;
            foreach (List<string> H in history)
            {
                colorRecognition.machineLearning.saveFile.WriteLine("Row " + i);
                foreach (string S in H)
                {
                    colorRecognition.machineLearning.saveFile.WriteLine(S);
                }
                try
                {
                    colorRecognition.machineLearning.saveFile.WriteLine(OutputHistory[history.IndexOf(H)].SelectedItem.ToString());
                }
                catch
                {
                    colorRecognition.machineLearning.WriteLine("Error writing in row " + i);
                    return;
                }
                i++;
            }
            colorRecognition.machineLearning.saveFile.WriteLine("END");
        }
        public void OpenColorHistory()
        {
            colorRecognition.machineLearning.WriteLine("Opened " + colorRecognition.machineLearning.saveFile.ReadLine(0) + " Color Recognition History file");
            if (!colorRecognition.machineLearning.saveFile.ReadLine(0).Equals(Version))
            {
                colorRecognition.machineLearning.WriteLine(colorRecognition.machineLearning.saveFile.ReadLine(0) + " file is incompatible with current version : " + Version);
                return;
            }
            colorRecognition.machineLearning.WriteLine("Color Recognition History Saved on " + colorRecognition.machineLearning.saveFile.ReadLine(1));

            ClearHistory();

            colorRecognition.machineLearning.WriteLine("There are " + colorRecognition.machineLearning.saveFile.ReadLine(2));

            int counter = 0;
            string Amount = new string(colorRecognition.machineLearning.saveFile.ReadLine(2).Where(char.IsDigit).ToArray());
            counter = Int32.Parse(Amount);

            int j = 3;
            for (int i = 0; i <= counter - 1; i++)
            {
                List<string> L = new List<string>();
                j++;
                string R = colorRecognition.machineLearning.saveFile.ReadLine(j);
                j++;
                string G = colorRecognition.machineLearning.saveFile.ReadLine(j);
                j++;
                string B = colorRecognition.machineLearning.saveFile.ReadLine(j);
                j++;
                string Out = colorRecognition.machineLearning.saveFile.ReadLine(j);
                j++;
                L.Add(R); L.Add(G); L.Add(B);
                history.Add(L);
                output.Add(Out);
            }
        }
        #endregion

        #region Form Functions
        private void ColorRecognitionHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void Button_Generate_Click(object sender, EventArgs e)
        {
            ClearHistory();
            RandomPopulation((int)numericUpDown_generate.Value);
            CreateTextboxes();
        }
        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveColorHistory();
            colorRecognition.machineLearning.saveFile.Save_ColorRecognition();
        }
        private void Button_Open_Click(object sender, EventArgs e)
        {
            colorRecognition.machineLearning.saveFile.Open_ColorRecognition();
            OpenColorHistory();
            CreateTextboxes();
        }
        #endregion
    }
}
