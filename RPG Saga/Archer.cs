using System;

namespace RPG_Saga
{
    class Archer : Player
    {
        private bool fire = false;
        public Archer() : base()
        {
            _class = "Лучник";
        }

        public override void Hit(Player player)
        {
            if (random.Next(0, 2) == 0 && !fire)
            {
                Console.WriteLine($"{Info()} поджигает {Info(player)}");
                fire = true;
            }
            else
            {
                Console.WriteLine($"{Info()} ударяет по {Info(player)}");
                player.TakeDamage(strength);
            }
            if (fire)
            {
                Console.WriteLine($"{Info(player)} горит и получает 2 единицы урона");
                player.TakeDamage(2);
            }
        }

        public override void Reset()
        {
            base.Reset();
            fire = false;
        }
    }
}
