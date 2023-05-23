using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Симулятор_программиста
{
    static class Programmer
    {
        public static int satiety { get; private set; } = 100;
        public static int energy { get; private set; } = 100;
        public static int money { get; private set; } = 10000;
        public static int exp { get; private set; } = 0;
        public static Job job = new Job(exp);
        public static House house;
        static Random rand = new Random();
        static int changes = 0;

        public static void Eat()
        {
            if (satiety == 100)
            {
                MessageBox.Show("Программист не нуждается в еде");
                return;
            }
            int needed = (100 - satiety) * 75;
            if (needed <= money)
            {
                money -= needed;
                satiety = 100;
            }
            else if (money >= 75)
            {
                needed = money / 75;
                money -= needed * 75;
                satiety += needed;
            }
            else MessageBox.Show("Программисту не хватило денег, чтобы поесть");
        }

        public static void Rest()
        {
            if (energy == 100)
            {
                MessageBox.Show("Программист не нуждается в отдыхе");
                return;
            }
            if (40 < satiety)
            {
                if (house != null)
                {
                    satiety -= 40;
                    energy = 100;
                }
                else
                {
                    satiety -= 40;
                    if (energy + 40 >= 100) energy = 100;
                    else energy += 40;
                }
            }
            else
            {
                MessageBox.Show("Программист сильно проголодался и уехал в село жить своим хозяйством, подальше от техники :(");
                Application.Exit();
            }
        }

        public static void Work()
        {
            changes = 0;
            int hungry = rand.Next(50, 70), tired = rand.Next(60, 75);
            if (satiety > hungry && energy > tired)
            {
                satiety -= hungry;
                energy -= tired;
                money += job.income;
                if (rand.Next(0, 100) < 5)
                {
                    int bonus = rand.Next(5000, 25000);
                    MessageBox.Show($"Программист очень хорошо поработал и получил премию в размере {bonus} ₽");
                    money += bonus;
                }
            }
            else
            {
                MessageBox.Show("Программист очень устал на работе, поэтому уехал в село жить своим хозяйством, подальше от техники :(");
                Application.Exit();
            }
        }

        public static void ChangeJob()
        {
            Job newjob = new Job(exp);
            if (MessageBox.Show($"Есть работа. Требуемый опыт: {newjob.needexp}. Зарплата: {newjob.income}. Интересует?", "Биржа труда", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (changes < 3)
                {
                    job = newjob;
                    changes++;
                }
                else MessageBox.Show("Хватит менять работу. Пора трудиться");
            }
        }

        public static void BuyHouse()
        {
            House hnew = new House();
            if (MessageBox.Show($"Купить дом за {hnew.price} ₽, площадью {hnew.square} кв. м.?", "Покупка дома", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (hnew.price > money)
                {
                    MessageBox.Show("Программисту не хватило денег на покупку дома");
                    return;
                }
                if (house == null)
                {
                    house = hnew;
                    money -= house.price;
                }
                else
                {
                    money += house.price / 2;
                    house = hnew;
                    money -= house.price;
                }
            }
        }

        public static void Practice()
        {
            if (exp < 500)
            {
                int hungry = rand.Next(35, 60), tired = rand.Next(50, 75);
                if (satiety > hungry && energy > tired)
                {
                    satiety -= hungry;
                    energy -= tired;
                    exp += rand.Next(1, 11);
                }
                else
                {
                    MessageBox.Show("Программисту надоело изучать программирование, поэтому он уехал в село жить своим хозяйством, подальше от техники :(");
                    Application.Exit();
                }
            }
            else MessageBox.Show("Вы уже стали самым опытным программистом на Земле. Дальше практиковаться некуда.");
        }
    }
}
