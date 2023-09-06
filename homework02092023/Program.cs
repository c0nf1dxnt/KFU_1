//c0nf1dxnt code
//11:45 PM 9/4/2023
//9:23 PM

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
            Console.WriteLine("Задание: Вывод трёх строк в указанном в файле с домашним заданием порядке\n");
            Console.WriteLine("a. Мир Труд Май");
            Console.WriteLine("b. Мир");
            Console.WriteLine("     Труд");
            Console.WriteLine("         Май\n");
        }
        static void task2()
        {
            Console.WriteLine("Task2:");
            Console.WriteLine("Задание: \n");
            Console.WriteLine("\n");
        }
        static void task3()
        {
            Console.WriteLine("Task3:");
            Console.WriteLine("Задание: Считать с клавиатуры радиус и вывести длину соответствующей окружности и площадь круга\n");
            Console.Write("Радиус окружности равен: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности равна: " + 2 * radius * Math.PI);
            Console.WriteLine("Площадь круга равна: " + Math.Pow(radius,2) * Math.PI + "\n");
        }
        static void task4()
        {
            Console.WriteLine("Task4:");
            Console.WriteLine("Задание: Найти значение y = cos(x), считать x с клавиатуры\n");
            Console.Write("x = ");
            Console.WriteLine("y = " + Math.Cos(Convert.ToDouble(Console.ReadLine())) + "\n");
        }

        static void task5()
        {
            Console.WriteLine("Task5:");
            Console.WriteLine("Задание: Считать коэф. кв. ур. с клавиатуры и найти корни кв. ур.\n");
            Console.Write("Введите коэффициент \"a\" квадратного уравнения: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент \"b\" квадратного уравнения: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент \"c\" квадратного уравнения: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (Math.Pow(b, 2) - 4 * a * c < 0)
            {
                Console.WriteLine("Корней нет\n");
            }
            else if (Math.Pow(b, 2) - 4 * a * c == 0)
            {
                Console.WriteLine("Один корень");
                Console.WriteLine("x = " + (-b / (2 * a)) + "\n");
            }
            else
            {
                Console.WriteLine("Два корня:");
                Console.WriteLine("x1 = " + (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
                Console.WriteLine("x2 = " + ((-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a)) + "\n");
            }


        }
        static void task6()
        {
            Console.WriteLine("Task6:");
            Console.WriteLine("Задание 6: Считать числа a,b,c с клавиатуры и обменять их значения\n");
            Console.Write("Переменная а равна: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Переменная b равна: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Переменная c равна: ");
            int c = Convert.ToInt32(Console.ReadLine());
            (a, b) = (b, a);
            (b, c) = (c, b);
            Console.WriteLine("После схемы \"a\":");
            Console.WriteLine($"Переменная а равна: {a}");
            Console.WriteLine($"Переменная b равна: {b}");
            Console.WriteLine($"Переменная c равна: {c}");
            (b, c) = (c, b);
            (a, b) = (b, a);
            Console.WriteLine("После схемы \"b\":");
            Console.WriteLine($"Переменная а равна: {a}");
            Console.WriteLine($"Переменная b равна: {b}");
            Console.WriteLine($"Переменная c равна: {c}");
            Console.WriteLine("\n");
        }

        static void task7()
        {
            Console.WriteLine("Task7:");
            Console.WriteLine("Задание: Вывести столбиком 4 случайных числа\n");
            Random random = new Random();
            Console.WriteLine("Случайное число №1 " + random.Next());
            Console.WriteLine("Случайное число №2 " + random.Next());
            Console.WriteLine("Случайное число №3 " + random.Next());
            Console.WriteLine("Случайное число №4 " + random.Next() + "\n");
        }
        static void task8()
        {
            Console.WriteLine("Task8:");
            Console.WriteLine("Задание: Ввести трёхзначное число и перенести самую правую цифру в начало\n");
            Console.Write("Введите трёхзначное число: ");
            string number = Console.ReadLine();
            if (number.Length != 3 || number[0] == '0')
            {
                Console.WriteLine("Введено не трёхзначное число!\n");
            }
            else
            {
                number = number[2] + number.Remove(number.Length - 1);
                Console.WriteLine("Полученное число: " + Convert.ToInt32(number) + "\n");
            }
        }
        static void task9()
        {
            Console.WriteLine("Task9:");
            Console.WriteLine("Задание: Считать с клавиатуры стоимость 1 кг конфет, печенья, яблок и вес купленных конфет, печенья и яблок, а затем вывести стоимость покупки\n");
            Console.Write("Введите стоимость конфет за кг:");
            double priceOfCandy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость печенья за кг:");
            double priceOfCookies = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость яблок за кг:");
            double priceOfApple = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес конфет:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес печенья:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес яблок:");
            double z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Стоимость всей покупки равна: " + (priceOfCandy * x + priceOfCookies * y + priceOfApple * z) + "\n");
        }

        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.OutputEncoding = Encoding.UTF8;

            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            task6();
            //task7();
            //task8();
            //task9();

            Console.ReadKey();
        }
    }
}
