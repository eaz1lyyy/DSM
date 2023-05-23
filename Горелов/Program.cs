using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Горелов
{
    class Program
    {
        static List<Human> people = new List<Human>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Управление:\n" +
                    "1. Создать персонажа.\n" +
                    "2. Пойти работать.\n" +
                    "3. Посмотреть информацию о персонаже.\n" +
                    "4. Купить дом.");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Введите имя: ");
                        string name = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Введите возраст: ");
                        int age = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Введите начальное количество денег: ");
                        double money = Double.Parse(Console.ReadLine());
                        Console.Clear();
                        people.Add(new Human(name, age, money));
                        people.Last().Info();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Human hum;
                        if (people.Count != 0)
                        {
                            hum = ChoosePerson();
                            Console.Write("Количество заработанных денег: ");
                            hum.Work(Int32.Parse(Console.ReadLine()));
                        }
                        else Console.WriteLine("Сначала создайте персонажа");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        if (people.Count != 0) ChoosePerson().Info();
                        else Console.WriteLine("Сначала создайте персонажа");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Random random = new Random();
                        House house;
                        do
                        {
                            Console.Clear();
                            int square = random.Next(30, 251);
                            if (random.Next(1, 101) > 30) house = new House(square, random.Next(23000 * square, 29000 * square));
                            else house = new TypedHouse(random.Next(23000 * 40, 29000 * 40));
                            house.Price();
                            Console.WriteLine("\nВыберите действие:\n" +
                                "1. Следующий дом.\n" +
                                "2. Купить дом.");
                        } while (Console.ReadLine() != "2");
                        Console.Clear();
                        ChoosePerson().BuyHouse(house);
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }

        static Human ChoosePerson()
        {
            int position = 1;
            foreach (Human human in people)
            {
                Console.WriteLine($"{position}. {human.name}");
                position++;
            }
            Console.Write("Выберите человека: ");
            return people[Int32.Parse(Console.ReadLine()) - 1];
        }
    }
}
