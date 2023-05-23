using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Горелов
{
    class TypedHouse : House
    {
        public TypedHouse(double price) : base(price)
        {
            square = 40;
        }

        public override void Price()
        {
            Console.WriteLine($"На данный момент в продаже есть типизированный дом. Он стоит {price}. Его площадь {square}.");
        }

        public override void HasHouse()
        {
            Console.WriteLine($"Типизированный дом площадью 40 и стоимостью {price}.");
        }
    }
}
