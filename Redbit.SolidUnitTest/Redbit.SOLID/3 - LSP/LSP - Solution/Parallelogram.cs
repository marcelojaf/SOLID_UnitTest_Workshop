using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.LSP.Solution
{
    public abstract class Parallelogram
    {
        protected Parallelogram(int _height, int _width)
        {
            Height = _height;
            Width = _width;
        }

        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Area { get { return Height * Width; } }
    }
}
