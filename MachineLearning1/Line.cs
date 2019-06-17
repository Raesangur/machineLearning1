using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MachineLearning1
{
    class Line
    {
        public Point Point1 = new Point();
        public Point Point2 = new Point();
        public readonly Pen blackPen = new Pen(Color.Black, 3)
        {
            Width = 2
        };
    }
}
