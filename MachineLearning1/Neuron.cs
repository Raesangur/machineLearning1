using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearning1
{
    public class Neuron
    {
        MachineLearning form;
        public List<Connection> ConnectionsIn = new List<Connection>();
        public List<Connection> ConnectionsOut = new List<Connection>();

        public string Name;
        public int Column;
        public int Row;
        public object Button;       // For the form. Ugly coding practices, ignore this
        public double Bias = 0;
        public double Output = 0;
        public double Input = 0;

        public Neuron(MachineLearning father, string name)
        {
            form = father;
            Name = name;

            form.WriteLine("Neuron created: " + Name + "Bias: " + Bias);
        }
        public Neuron(MachineLearning father, string name, int column, int row, double bias)
        {
            form = father;
            Name = name;
            Column = column;
            Row = row;

            Bias = bias;

            form.WriteLine("Neuron created: " + Name + ", Bias: " + Bias);
        }

        public void Calculation()
        {
            // a=σ(∑(w⋅ai−1)+b)
            Input = 0;
            foreach (Connection C in ConnectionsIn)
            {
                Input += (C.NeuronIn.Output * C.Weight);
            }
            Output = MachineLearning.Sigmoid(Input + Bias);
            string OutputS = string.Format("{0:0.##}", Output);

            //Output = (ConnectionsIn[0].Weight * ConnectionsIn[0].NeuronIn.Output) + Bias;
            form.WriteLine(Name + " outputs " + OutputS);
        }
        public void Calculation(double input)
        {
            Input = input;
            Output = MachineLearning.Sigmoid(Input + Bias);
            string OutputS = string.Format("{0:0.##}", Output);
            form.WriteLine(Name + " outputs " + OutputS);
        }

        public void AddConnectionIn(Connection connection)
        {
            ConnectionsIn.Add(connection);
        }
        public void AddConnectionOut(Connection connection)
        {
            ConnectionsOut.Add(connection);
        }
    }
}
