using System;

namespace RPG_Saga
{
    class Player
    {
        public int health { protected set; get; }
        protected int inithealth;
        public int strength { protected set; get; }
        public string name { protected set; get; }
        protected string[] names = new string[] { "Mirana", "Enigma", "Sniper", "Ursa", "Bane", "Invoker", "Io", "Marchi", "Luna", "SF", "Rubick", "SK", "Riki", "Abaddon" };
        public bool islose { protected set; get; } = false;
        public string _class { protected set; get; } = "Игрок";
        public static Random random = new Random();

        public Player()
        {
            health = random.Next(10, 16);
            //health = random.Next(50, 101);
            inithealth = health;
            strength = random.Next(1, 7);
            name = names[random.Next(names.Length)];
        }

        public virtual void Hit(Player player)
        {
            Console.WriteLine($"{Info()} ударяет по {Info(player)}");
            player.TakeDamage(strength);
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                health = 0;
                islose = true;
            }
            Console.WriteLine($"{Info()} получил {damage} единиц урона");
        }

        public string Info()
        {
            return $"({_class}) {name}[{health}]";
        }

        public string Info(Player player)
        {
            return $"({player._class}) {player.name}[{player.health}]";
        }

        public virtual void Reset()
        {
            health = inithealth;
            islose = false;
        }
    }
}
