using System;

namespace RPG_Saga
{
    class Wizard : Player
    {
        public Wizard() : base()
        {
            _class = "Маг";
        }

        public override void Hit(Player player)
        {
            if (random.Next(0, 2) == 0)
            {
                Console.WriteLine($"{Info()} ударяет по {Info(player)}");
                player.TakeDamage(strength);
            }
            else
            {
                Console.WriteLine($"{Info()} завораживает {Info(player)}");
                Console.WriteLine($"{Info(player)} пропускает ход");
                Console.WriteLine($"{Info()} ударяет по {Info(player)}");
                player.TakeDamage(strength);
                if (player.health > 0)
                {
                    Console.WriteLine($"{Info()} ударяет по {Info(player)}");
                    player.TakeDamage(strength);
                }
            }
        }
    }
}
