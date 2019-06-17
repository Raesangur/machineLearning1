using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearning1
{
    public class Connection
    {
        readonly MachineLearning form;
        public string Name;
        public Neuron NeuronIn = null;
        public Neuron NeuronOut = null;
        public double Weight = 1;

        public Connection(MachineLearning father, string name, Neuron neuronIn, Neuron neuronOut)
        {
            form = father;
            Name = name;
            NeuronIn = neuronIn;
            NeuronOut = neuronOut;

            NeuronIn.AddConnectionOut(this);
            NeuronOut.AddConnectionIn(this);
        }
        public Connection(MachineLearning father, string name, Neuron neuronIn, Neuron neuronOut, double weight)
        {
            form = father;
            Name = name;
            NeuronIn = neuronIn;
            NeuronOut = neuronOut;
            Weight = weight;

            NeuronIn.AddConnectionOut(this);
            NeuronOut.AddConnectionIn(this);

            //form.WriteLine("Connection " + Name + " established between " + NeuronIn.Name + " and " + NeuronOut.Name + ", weight:" + Weight);
        }
    }
}
