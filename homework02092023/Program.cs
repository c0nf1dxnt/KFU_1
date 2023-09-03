using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace homework02092023
{
    internal class Program
    {
        static void task1()
        {
            Console.WriteLine("Task1:");
            Console.WriteLine("a. Мир Труд Май");
            Console.WriteLine("b. Мир");
            Console.WriteLine("     Труд");
            Console.WriteLine("         Май");
        }
        static void task2()
        {
            Console.WriteLine("Task2:");
        }
        static void task3()
        {
            Console.WriteLine("Task3:");
            Console.Write("Радиус окружности равен: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности равна: " + 2 * radius * Math.PI);
            Console.WriteLine("Площадь круга равна: " + Math.Pow(radius,2) * Math.PI);
        }
        static void task4()
        {
            Console.WriteLine("Task4:");
        }

        static void task5()
        {
            Console.WriteLine("Task5:");
            Console.Write("Введите коэффициент \"a\" квадратного уравнения: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент \"b\" квадратного уравнения: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент \"c\" квадратного уравнения: ");
            int c = Convert.ToInt32(Console.ReadLine());

            //int discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (Math.Pow(b, 2) - 4 * a * c < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (Math.Pow(b, 2) - 4 * a * c == 0)
            {
                Console.Write("Один корень, x = " + (-b / (2 * a)));
            }
            else
            {
                Console.WriteLine("Два корня, x1 = " +  ((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a)));
                Console.WriteLine("x2 = " + ((-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a)));
            }


        }
        static void task6()
        {
            Console.WriteLine("Task6:");
        }

        static void task7()
        {
            Console.WriteLine("Task7:");
            Random random = new Random();

            int range1 = -2147483648;
            int range2 = 2137483647;

            Console.WriteLine("Случайное число №1 " + random.Next(range1,range2));
            Console.WriteLine("Случайное число №2 " + random.Next(range1, range2));
            Console.WriteLine("Случайное число №3 " + random.Next(range1, range2));
            Console.WriteLine("Случайное число №4 " + random.Next(range1, range2));
        }
        static void task8()
        {
            Console.WriteLine("Task8:");
            Console.WriteLine("Введите трёхзначное число");
            string number = Console.ReadLine();
            if (number.Length != 3)
            {
                Console.WriteLine("Введено не трёхзначное число!");

            }
        }
        static void task9()
        {
            Console.WriteLine("Task9:");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            task1();
            task2();
            task3();
            task4();
            task5();
            task6();
            task7();
            task8();
            task9();
            Console.ReadKey();
        }
    }
}
