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
            goto currentTask;
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
            Console.Write("4.17 (с if - else) Введите название своего любимого цвета на английском: ");

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

            //4.1.18
            Console.Write("\n4.1.18 (switch) Введите название своего любимого цвета на английском: ");
            color = Console.ReadLine().ToLower();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Не нашлось такого цвета; будем использовать наши значения по умолчанию. ");
                    break;
            }
            Console.WriteLine($"Введено: {color}");

            // Задание 4.2.6 -проверка "бесконечного цикла"
            for (; ; )
            {
                Console.WriteLine("Infinite Cycle");
                break;
            }
            Console.WriteLine("After the Cycle");

            //4.2.11
            Console.WriteLine("4.2.11");
            int k = 0;
            do
            {
                Console.WriteLine("Iteration {0}. Напишите свой любымый цвет на английскм с маленькой буквы или просто нажмите Enter: ", k);
                switch (Console.ReadLine()) { }; //пропустим действия, которые уже выполнялись ранее
            } while (++k < 3);


            //задача из скринкаста по сле 4.2.15
            int sum = 0;
            int number;
            do
            {
                Console.WriteLine("Введите число: ");
                bool numberEntered = Int32.TryParse(Console.ReadLine(), out number);
                sum += number > 0 ? number : 0;
                Console.WriteLine($"Промежуточный результат = {sum}");
            } while (number != 0);

            Console.WriteLine($"Окончательный результат: {sum}");

            //перед 4.5.3 - обращение со строкой как с массивом
            string name = "Eugenia";
            foreach (char item in name)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"Последняя буквва имени: {name[name.Length - 1]}");


            //4.3.7  напишите программу, которая переставляет буквы вашего имени в обратном порядке.
            string straightName = "Eugenia";
            char[] charsOfName = straightName.ToCharArray();
            Array.Reverse(charsOfName);
            string reversedName = new string(charsOfName);

            Console.WriteLine($"1) Name: {straightName}; reversed Name: {reversedName}");

            string anotherReverse = string.Concat(Enumerable.Reverse(straightName));
            Console.WriteLine($"2) Name: {straightName}; reversed Name: {anotherReverse}");

            string thirdReverse = new string(straightName.ToCharArray().Reverse().ToArray());
            Console.WriteLine($"3) Name: {straightName}; reversed Name: {thirdReverse}");

            //ну, и с помощью for
            char[] charsInName = new char[straightName.Length];
            for (int i = 0; i < straightName.Length; i++)
            {
                charsInName[i] = straightName[straightName.Length - i - 1];
            }
            string lastReversedName = new string(charsInName);
            Console.WriteLine($"4) Name: {straightName}; reversed Name: {lastReversedName}");


            //4.3.9 Многомерные массивы 
            int[,] twoDimArray = {{ 1,2, 3}, { 4, 5, 6}  };
            foreach (int item in twoDimArray)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nКоличество строк: ");
            Console.WriteLine(twoDimArray.GetUpperBound(0) + 1 + " ");

            Console.Write("Количество колонок: ");
            Console.WriteLine(twoDimArray.GetUpperBound(1) + 1 + " ");

            //4.3.1  Напишите программу, которая отображает этот же массив, но только перебор начинается по столбцам.
            //То есть сначала отображаем все знания строк первого столбца, потом второго и далее
            for (int i = 0; i < twoDimArray.GetLength(1); i++)
            {
                for (int j = 0; j < twoDimArray.GetLength(0); j++)
                    Console.Write(twoDimArray[j,i] + " ");

                Console.WriteLine();
            }


            //4.3.12  сортировка одномерного массива
            int[] arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            //Array.Sort(arr);  // это слишком просто, не будем так делать))
            int currentMin;   
            int itemToChange;
            int actions = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                currentMin = arr[i];
                itemToChange = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < currentMin)
                    {
                        itemToChange = j;
                        currentMin = arr[j];
                        actions += 2;
                    }
                }
                arr[itemToChange] = arr[i];
                arr[i] = currentMin;
                actions += 2;
                Console.WriteLine("\nIteration: {0}", i);
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine("Finished. Total {0} actions", actions);


            //4.3.13 Для заданного массива Необходимо найти сумму всех его элементов.

            var ar = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sumOfElements = 0;
            foreach (int element in ar)
            {
                Console.Write(element + " + ");
                sumOfElements += element;
            }
            Console.WriteLine("\b\b= " + sumOfElements);


            //4.3.14 перебор элементов зубчатого массива
            int[][] zarray = new int[3][];
            zarray[0] = new int[] { 1, 2};
            zarray[1] = new int[] { 1, 2, 3};
            zarray[2] = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Перебор зубчатого массива: ");
            foreach (int[] zrow in zarray)
            {
                foreach (int zitem in zrow)
                {
                    Console.Write(zitem + " ");
                }
                Console.WriteLine();
            }


            //4.3.15 Задайте одномерный массив и напишите алгоритм, который находит в нем количество положительных чисел
            int[] oneDimArray = { -2, -1, 0, 1, 2, -3, 3 };
            int positiveItems = 0;
            foreach(int item in oneDimArray)
            {
                positiveItems += item > 0 ? 1 : 0;
            }
            Console.WriteLine($"{positiveItems} positive items in array");

            //4.3.16 найти количество положительных элементов массива
            int[,] biDimArr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int positives = 0;
            foreach (int item in biDimArr)
            {
                positives += item > 0 ? 1 : 0;
            }
            Console.WriteLine($"{positives} positive items in 2-dim array");

            currentTask:
            //4.3.17 сортировка каждой из строк двумерного массива
            int[,] arr17 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < arr17.GetLength(0); i++)
            {
                for (int j = 0; j < arr17.GetLength(1); j++)
                {
                    Console.Write(arr17[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int row = 0; row < arr17.GetLength(0); row++)
            {
                int tmp;
                for (int i = 0; i < arr17.GetLength(1) - 1; i++)
                {
                    for (int j = i + 1; j < arr17.GetLength(1); j++)
                    {
                        if (arr17[row, j] < arr17[row, i])
                        {
                            tmp = arr17[row, i];
                            arr17[row, i] = arr17[row, j];
                            arr17[row, j] = tmp;
                        }
                    }
                }
            }

            Console.WriteLine("Результат сортировки");
            for (int i = 0; i < arr17.GetLength(0); i++)
            {
                for (int j = 0; j < arr17.GetLength(1); j++)
                {
                    Console.Write(arr17[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
