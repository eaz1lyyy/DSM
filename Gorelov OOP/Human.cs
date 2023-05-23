using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorelov_OOP
{
    class Human
    {
        public string name { get; private set; }
        string house;
        int age;
        double money;
        bool havehouse;

        public Human(string name, int age, double money, bool havehouse)
        {
            this.name = name;
            this.age = age;
            this.money = money;
            this.havehouse = havehouse;
        }

        public void Info()
        {
            if (havehouse) house = "есть жильё.";
            else house = "нет жилья.";
            Console.WriteLine($"Меня зовут {name}. Мне {age} лет. Я имею {money} рублей. У меня {house}");
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
                havehouse = true;
                Console.WriteLine($"Поздравляем, {name} купил(а) дом.");
            }
            else
            {
                Console.WriteLine($"К сожалению {name} не хватило денег на покупку дома.");
            }
        }
    }
}
