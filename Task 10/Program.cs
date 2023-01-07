using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namber;
            namber = Convert.ToInt32(Console.ReadLine());
            int dozens = namber / 10;
            int unit = namber % 10;

            switch (dozens)
            {
                case 1:
                    switch (unit)
                    {
                        case 0:
                            Console.WriteLine("Десять");
                            break;
                        case 1:
                            Console.WriteLine("Одиннадцать");
                            break;
                        case 2:
                            Console.WriteLine("Двенадцать");
                            break;
                        case 3:
                            Console.WriteLine("Тринадцать");
                            break;
                        case 4:
                            Console.WriteLine("Четырнадцать");
                            break;
                        case 5:
                            Console.WriteLine("Пятнадцать");
                            break;
                        case 6:
                            Console.WriteLine("Шестнадцать");
                            break;
                        case 7:
                            Console.WriteLine("Семнадцать");
                            break;
                        case 8:
                            Console.WriteLine("Восемнадцать");
                            break;
                        case 9:
                            Console.WriteLine("Девятнадцать");
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Двадцать");
                    break;
                case 3:
                    Console.Write("Тридцать");
                    break;
                case 4:
                    Console.Write("Сорок");
                    break;
                case 5:
                    Console.Write("Пятьдесят");
                    break;
                case 6:
                    Console.Write("Шестьдесят");
                    break;
                case 7:
                    Console.Write("Семьдесят");
                    break;
                case 8:
                    Console.Write("Восемьдесят");
                    break;
                case 9:
                    Console.Write("Девяносто");
                    break;
            }

            if (dozens != 1)
            {
                switch (unit)
                {
                    case 1:
                        Console.Write(" Один");
                        break;
                    case 2:
                        Console.Write(" Два");
                        break;
                    case 3:
                        Console.Write(" Три");
                        break;
                    case 4:
                        Console.Write(" Четыре");
                        break;
                    case 5:
                        Console.Write(" Пять");
                        break;
                    case 6:
                        Console.Write(" Шесть");
                        break;
                    case 7:
                        Console.Write(" Семь");
                        break;
                    case 8:
                        Console.Write(" Восемь");
                        break;
                    case 9:
                        Console.Write(" Девять");
                        break;
                }
            }
        }
    }
}
