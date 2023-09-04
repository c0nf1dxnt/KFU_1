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
            Console.WriteLine("Задание: Вывод трёх строк в указанном в файле с домашним заданием порядке");
            Console.WriteLine("a. Мир Труд Май");
            Console.WriteLine("b. Мир");
            Console.WriteLine("     Труд");
            Console.WriteLine("         Май\n");
        }
        static void task1ver2()
        {
            Console.WriteLine("Task1:");
            Console.WriteLine("Задание: Вывод трёх строк в указанном в файле с домашним заданием порядке");
            Console.WriteLine("a. Мир Труд Май");
            Console.WriteLine("b. Мир\n\tТруд\n\t\tМай\n");
        }
        static void task2()
        {
            Console.WriteLine("Task2:");
            Console.WriteLine("Задание: ");
        }
        static void task3()
        {
            Console.WriteLine("Task3:");
            Console.WriteLine("Задание: Считать с клавиатуры радиус и вывести длину соответствующей окружности и площадь круга");
            Console.Write("Радиус окружности равен: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности равна: " + 2 * radius * Math.PI);
            Console.WriteLine("Площадь круга равна: " + Math.Pow(radius,2) * Math.PI + "\n");
        }
        static void task4()
        {
            Console.WriteLine("Task4:");
            Console.WriteLine("Задание: Найти значение y = cos(x), считать x с клавиатуры");
            Console.Write("x = ");
            Console.WriteLine("y = " + Math.Cos(Convert.ToDouble(Console.ReadLine())));
        }

        static void task5()
        {
            Console.WriteLine("Task5:");
            Console.WriteLine("Задание: Считать коэф. кв. ур. с клавиатуры и найти корни кв. ур.");
            Console.Write("Введите коэффициент \"a\" квадратного уравнения: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент \"b\" квадратного уравнения: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент \"c\" квадратного уравнения: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (Math.Pow(b, 2) - 4 * a * c < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (Math.Pow(b, 2) - 4 * a * c == 0)
            {
                Console.WriteLine("Один корень");
                Console.WriteLine("x = " + (-b / (2 * a)));
            }
            else
            {
                Console.WriteLine("Два корня:");
                Console.WriteLine("x1 = " + (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
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
            Console.WriteLine("Задание: Вывести столбиком 4 случайных числа");
            Random random = new Random();

            Console.WriteLine("Случайное число №1 " + random.Next());
            Console.WriteLine("Случайное число №2 " + random.Next());
            Console.WriteLine("Случайное число №3 " + random.Next());
            Console.WriteLine("Случайное число №4 " + random.Next());
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
            Console.WriteLine("Задание: Считать с клавиатуры стоимость 1 кг конфет, печенья, яблок и вес купленных конфет, печенья и яблок, а затем вывести стоимость покупки");
            double priceOfCandy = Convert.ToDouble(Console.ReadLine());
            double priceOfCookies = Convert.ToDouble(Console.ReadLine());
            double priceOfApple = Convert.ToDouble(Console.ReadLine());

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(priceOfCandy * x + priceOfCookies * y + priceOfApple * z);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //task1();
            //task1ver2();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();
            //task8();
            task9();
            Console.ReadKey();
        }
    }
}
