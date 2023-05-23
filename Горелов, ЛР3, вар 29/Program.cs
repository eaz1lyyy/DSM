using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Горелов__ЛР3__вар_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0;
            double sum = 0, result = 0;
            BEGIN:
            Console.Write("Введите номер задания ");
            switch (Console.ReadLine())
            {
                case "1":
                    double x = 0;
                    while (x <= 3) {
                        Console.WriteLine($"x = {x} F(x) = {(3 / 5) * Math.Cos((Math.PI / 6) - x) + Math.Sin(x)}");
                        x = Math.Round(x + 0.1, 1);
                    }
                    break;
                case "2":
                    xx = Double.Parse(Console.ReadLine());
                    for (int i = 2; i <= 20; i += 3)
                    {
                        result = Sqrt3(Math.Cos(i + Math.PI * xx));
                        sum += result;
                        Console.WriteLine(i + " " + result);
                    }
                    Console.WriteLine("Сумма = " + sum);
                    break;
                case "3":
                    sum = 1;
                    xx = Double.Parse(Console.ReadLine());
                    for (int j = 1; j <= 15; j += 2)
                    {
                        result = j * Math.Sqrt(Math.Abs(xx)) / Math.Pow(Math.Sin(j * xx), 2);
                        sum *= result;
                        Console.WriteLine(j + " " + result);
                    }
                    Console.WriteLine("Произведение = " + sum);
                    break;
                case "4":
                    for (int i = 10; i < 100; i++)
                    {
                        if ((Math.Pow(Double.Parse(i.ToString()[0].ToString()), 2) + Math.Pow(Double.Parse(i.ToString()[1].ToString()), 2)) % 22 == 0) Console.WriteLine(i);
                    }
                    break;
                case "5":
                    double xxx = Double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Pow(xxx, 1d / 3d));
                    Console.WriteLine(Sqrt3(xxx));
                    break;
                default:
                    Console.WriteLine("Номер задания неверный");
                    goto BEGIN;
            }
        }
        static double Sqrt3(double chislo)
        {
            if (chislo < 0) return -Math.Pow(-chislo, 1d / 3d);
            else return Math.Pow(chislo, 1d / 3d);
        }
    }
}