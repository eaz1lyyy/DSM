using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle
{
    class CellInfo
    {
        public bool isShip = false;
        public Ship ship;
        public int x, y;

        public CellInfo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
