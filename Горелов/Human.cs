using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Горелов
{
    class Human
    {
        public string name { get; private set; }
        int age;
        double money;
        List<House> houses = new List<House>();

        public Human(string name, int age, double money)
        {
            this.name = name;
            this.age = age;
            this.money = money;
        }

        public void Info()
        {
            Console.WriteLine($"Меня зовут {name}. Мне {age} лет. Я имею {money} рублей. У меня есть {houses.Count} домов.");
            if (houses.Count != 0)
            {
                Console.WriteLine("Я имею:\n");
                foreach (House hou in houses)
                {
                    hou.HasHouse();
                }
            }
        }

        public void Work(int income)
        {
            money += income;
            Console.WriteLine($"{name} поработал и получил {income}. Теперь у него {money}");
        }

        public void BuyHouse(House house)
        {
            if (house.price <= money)
            {
                money -= house.price;
                houses.Add(house);
                Console.WriteLine($"Поздравляем, {name} купил(а) дом.");
            }
            else
            {
                Console.WriteLine($"К сожалению {name} не хватило денег на покупку дома.");
            }
        }
    }
}
