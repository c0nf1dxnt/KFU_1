using System;
using System.Text;
using System.Threading;

namespace Part3
{
    internal class Program
    {
        static void Task1_1()
        {
            Console.WriteLine("Задание №1:\nВыведите на экран информацию о каждом типе данных в виде:\r\nТип данных – максимальное значение – минимальное значение\n");
            Console.WriteLine($"Максимальное значение float: {float.MaxValue}");
            Console.WriteLine($"Минимальное значение float: {float.MinValue}");
            Console.WriteLine($"Максимальное значение double: {double.MaxValue}");
            Console.WriteLine($"Минимальное значение double: {double.MinValue}");
            Console.WriteLine($"Максимальное значение decimal: {decimal.MaxValue}");
            Console.WriteLine($"Минимальное значение decimal: {decimal.MinValue}");
            Console.WriteLine($"Максимальное значение byte: {byte.MaxValue}");
            Console.WriteLine($"Минимальное значение byte: {byte.MinValue}");
            Console.WriteLine($"Максимальное значение sbyte: {sbyte.MaxValue}");
            Console.WriteLine($"Минимальное значение sbyte: {sbyte.MinValue}");
            Console.WriteLine($"Максимальное значение short: {short.MaxValue}");
            Console.WriteLine($"Минимальное значение short: {short.MinValue}");
            Console.WriteLine($"Максимальное значение ushort: {ushort.MaxValue}");
            Console.WriteLine($"Минимальное значение ushort: {ushort.MinValue}");
            Console.WriteLine($"Максимальное значение int: {int.MaxValue}");
            Console.WriteLine($"Минимальное значение int: {int.MinValue}");
            Console.WriteLine($"Максимальное значение uint: {uint.MaxValue}");
            Console.WriteLine($"Минимальное значение uint: {uint.MinValue}");
            Console.WriteLine($"Максимальное значение long: {long.MaxValue}");
            Console.WriteLine($"Минимальное значение long: {long.MinValue}");
            Console.WriteLine($"Максимальное значение ulong: {ulong.MaxValue}");
            Console.WriteLine($"Минимальное значение ulong: {ulong.MinValue}");
        }
        static void Task1()
        {
            Console.WriteLine("Задание №1:\nВывести информацию о каждом типе данных в формате\nТип данных\tМаксимальное значение\t\tМинимальное значение\n");
            Console.WriteLine($"float\t\t{float.MaxValue}\t\t\t{float.MinValue}");
            Console.WriteLine($"double\t\t{double.MaxValue}\t\t{double.MinValue}");
            Console.WriteLine($"decimal\t\t{decimal.MaxValue}\t{decimal.MinValue}");
            Console.WriteLine($"byte\t\t{byte.MaxValue}\t\t\t\t{byte.MinValue}");
            Console.WriteLine($"sbyte\t\t{sbyte.MaxValue}\t\t\t\t{sbyte.MinValue}");
            Console.WriteLine($"short\t\t{short.MaxValue}\t\t\t\t{short.MinValue}");
            Console.WriteLine($"ushort\t\t{ushort.MaxValue}\t\t\t\t{ushort.MinValue}");
            Console.WriteLine($"int\t\t{int.MaxValue}\t\t\t{int.MinValue}");
            Console.WriteLine($"uint\t\t{uint.MaxValue}\t\t\t{uint.MinValue}");
            Console.WriteLine($"long\t\t{long.MaxValue}\t\t{long.MinValue}");
            Console.WriteLine($"ulong\t\t{ulong.MaxValue}\t\t{ulong.MinValue}");
            Console.WriteLine($"char\t\t{char.MaxValue}\t\t{char.MinValue}\n");

        }
        struct UserData
        {
            public string Name;
            public int Age;
            public int PinCode;
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2:\nНапишите программу, в которой принимаются данные пользователя в виде имени,\r\nгорода, возраста и PIN-кода. Далее сохраните все значение в соответствующей\r\nпеременной, а затем распечатайте всю информацию в правильном формате.\r\n");
            UserData user1 = new UserData();
            Console.Write("Введите имя: ");
            user1.Name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            user1.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите PIN-код:");
            user1.PinCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Данные пользователя user1:\nИмя пользователя: {user1.Name}\nВозраст пользователя: {user1.Age}\nPIN-код пользователя: {user1.PinCode}");
        }
        static void Task3()
        {
            Console.WriteLine("Задание №3:\nПреобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на\r\nстрочные.\n");
            Console.Write("Введите строку: ");
            string InputString = Console.ReadLine();
            string Answer = "";
            for (int i = 0; i < InputString.Length; i++)
            {
                if (char.IsUpper(InputString[i]))
                {
                    Answer += char.ToLower(InputString[i]);
                }
                else
                {
                    Answer += char.ToUpper(InputString[i]);
                }
            }
            Console.WriteLine($"Получилась строка: {Answer}\n");
        }
        static void Task4()
        {
            Console.WriteLine("Задание №4:\nВведите строку, введите подстроку. Необходимо найти количество вхождений и вывести\r\nна экран");
            string InputString = Console.ReadLine();
            string InputSubstring = Console.ReadLine();
            Console.WriteLine((InputString.Length - InputString.Replace(InputSubstring, "").Length) / InputSubstring.Length);
        }
        static void Task5()
        {
            Console.WriteLine("Задание №4:\nЦель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам\r\nнужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически\r\nпокрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),\r\nскидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка\r\nобычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы\r\nсэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов\r\nстерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут\r\nцелыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону");
            Console.Write("Введите стоимость одной бутылки виски(в фунтах стерлингов): ");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер скидки (в процентах): ");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расходы на отпуск(в фунтах стерлингов): ");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            double answer = normPrice * Convert.ToDouble(salePrice) / 100 * holidayPrice;
            Console.WriteLine($"Для покрытия расходов на отпуск требуется выпить {Math.Floor(answer)} бутылок виски");
        }
        static void Task6()
        {
            Console.WriteLine("Задание №6:\nВоспроизвести разговор Гарри Поттера и дневника Тома Реддла. Пользователь\r\nздоровается с консолью. Консоль спрашивает, как зовут пользователя. Пользователь\r\nназывает имя. Консоль пишет: привет, <имя пользователя>. После этого пользователь\r\nспрашивает, знает ли консоль что-то о тайной комнате. Консоль отвечает «Да». После\r\nэтого пользователь спрашивает, может ли рассказать. Консоль отвечает «Нет». Спустя 5\r\nсекунд консоль дополняет «но могу показать». Консоль меняет цвет на любой случайный\r\nцвет.\r\n");
            Console.Write("Гарри Поттер: ");
            string UserInput = Console.ReadLine();
            Console.Write("Том Реддл: Как тебя зовут?\nГарри Поттер: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Том Реддл: Привет, {Name}!\nГарри Поттер: Знаешь ли ты что-нибудь о тайной комнате?");
            Console.WriteLine("Том Реддл: Да\nГарри Поттер: Можешь ли ты рассказать о ней?\nТом Реддл: Нет");
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write("Но могу показать...");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();

            Console.ReadKey();
        }
    }
}
