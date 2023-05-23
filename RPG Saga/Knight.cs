using System;

namespace RPG_Saga
{
    class Knight : Player
    {
        public Knight() : base()
        {
            _class = "Рыцарь";
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
                Console.WriteLine($"{Info()} наносит удар возмездия по {Info(player)}");
                player.TakeDamage((int)Math.Round(strength * 1.3));
            }
        }
    }
}
