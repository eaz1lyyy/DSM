using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Battle
{
    class Ship
    {
        public int decks = 0;
        public Button[] cells;
        public Ship(int decks)
        {
            this.decks = decks;
            cells = new Button[decks];
        }
    }
}
