using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Симулятор_программиста
{
    class House
    {
        public int square { get; private set; }
        public int price { get; private set; }

        public House()
        {
            Random random = new Random();
            square = random.Next(30, 251);
            price = square * 7000;
        }
    }
}
