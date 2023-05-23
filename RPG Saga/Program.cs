using System;
using System.Collections.Generic;

namespace RPG_Saga
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerscol;
            List<Player> players = new List<Player>();
            do
            {
                Console.Write("Количество игроков: ");
                playerscol = Int32.Parse(Console.ReadLine());
                if (playerscol <= 0 || playerscol % 2 != 0)
                {
                    Console.WriteLine("Ошибка: неверное количество игроков.");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            while (playerscol <= 0 || playerscol % 2 != 0);
            for (int number = 0; number <= playerscol; number++)
            {
                int variant = Player.random.Next(0, 3);
                if (variant == 0) players.Add(new Knight());
                else if (variant == 1) players.Add(new Archer());
                else players.Add(new Wizard());
            }
            Console.WriteLine($"Сражение: {players[0].Info()} с уроном {players[0].strength} vs {players[1].Info()} с уроном {players[1].strength}");
            while (true)
            {
                players[0].Hit(players[1]);
                if (players[1].islose)
                {
                    Console.WriteLine($"{players[0].Info()} победил!");
                    break;
                }
                players[1].Hit(players[0]);
                if (players[0].islose)
                {
                    Console.WriteLine($"{players[1].Info()} победил!");
                    break;
                }
            }
        }
    }
}
