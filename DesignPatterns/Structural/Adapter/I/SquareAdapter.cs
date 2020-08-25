using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.I
{
    class SquareAdapter : ICircle
    {
        private readonly Square _square;

        public SquareAdapter(Square square)
        {
            _square = square;
        }

        public float Radius => _square.Width * (float)Math.Sqrt(2) / 2f;
    }
}
