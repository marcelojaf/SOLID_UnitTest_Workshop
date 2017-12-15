using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.LSP.Solution
{
    public class Square : Parallelogram
    {
        public Square(int _height, int _width)
            :base(_height, _width)
        {
            if (_width != _height)
            {
                throw new ArgumentException("Both sides of a square need to be equal!");
            }
        }
    }
}
