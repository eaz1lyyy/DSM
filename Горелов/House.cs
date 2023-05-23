using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Горелов
{
    class House
    {
        protected int square = 10;
        public double price { get; protected set; }

        public House(double price)
        {
            this.price = price;
        }

        public House(int square, double price)
        {
            this.square = square;
            this.price = price;
        }

        public virtual void Price()
        {
            Console.WriteLine($"На данный момент в продаже есть обычный дом. Он стоит {price}. Его площадь {square}.");
        }

        public void Reduction(int percent)
        {
            price = price - (price / 100 * percent);
            Console.WriteLine($"Вы применили скидку на дом. Теперь он стоит {price}.");
        }

        public virtual void HasHouse()
        {
            Console.WriteLine($"Обычный дом площадью {square} и стоимостью {price}.");
        }
    }
}
