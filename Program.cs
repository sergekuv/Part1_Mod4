using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1.1 Запишите код, который проверяет следующее выражение: переменная A типа string не равна переменной B типа string.
            //код, приведенный в качестве правильного ответа не компилируется
            //string a, b;
            //bool c = a != a;

            //Задание 4.1.5
            //Запишите код, который проверяет следующее выражение: переменная A типа int меньше переменной B типа int, или переменная X типа double больше переменной Y типа double.
            int a = 0;
            int b = 0;
            double x = 0;
            double y = 0;
            bool c = (a < b) || (x > y);
            Console.WriteLine($"{c}");

            //4.1.10 - непонятно, почему ответ "Console.WriteLine(result);" не принимается системой
            var inv = true;
            var result = !inv;
            Console.WriteLine(result);

            //4.1.17 
            Console.WriteLine("Введите название своего любимого цвета на английском");

            string color = Console.ReadLine().ToLower();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Вы выбрали красный");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Выбран зеленый!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Такой вариант не предусмотрен, но можем предложить голубой!");
            }

        Console.ReadKey();
        }
    }
}
