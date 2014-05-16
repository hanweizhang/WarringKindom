using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warring_Kingdom
{
    class Coordinate
    {
        public int xCor;
        public int yCor;

        public Coordinate(int x, int y)
        {
            this.xCor = x;
            this.yCor = y;
        }

        public void setCor(int x, int y)
        {
            this.xCor = x;
            this.yCor = y;
        }
    }
}
