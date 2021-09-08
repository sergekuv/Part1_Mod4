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
            //Это декларация для 4.5.1

            goto currentTask;
            #region 4.1
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
            #endregion 4.1

            #region 4.2
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
            string name453 = "Eugenia";
            foreach (char item in name453)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"Последняя буквва имени: {name453[name453.Length - 1]}");
            #endregion 4.2

            #region 4.3
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
            #endregion 4.3

            #region 4.4
            // 4.4.2 Модифицируйте свою программу для ввода личной информации пользователя так, чтобы данные записывались в кортеж anketa
            (string name, int age, float footSsize) anketa;
            Console.Write("Введите Ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            bool ageIsNumber = Int32.TryParse(Console.ReadLine(), out anketa.age);
            Console.WriteLine("Введите размер ноги: ");
            bool footSizeIsFloat = float.TryParse(Console.ReadLine(), out anketa.footSsize);
            Console.WriteLine($"Ваше имя: {anketa.name}, возраст: {anketa.age}, размер ноги: {anketa.footSsize}");

            // 4.4.3 Используя такую запись кортежа, измените предыдущую программу. Сначала отобразите на экран имя и возраст.
            var (name443, age) = ("Евгения", 27);
            Console.Write($"Старые данные: имя {name443}, возраст {age}.\nВведите новое имя: ");
            name443 = Console.ReadLine();
            Console.Write("Введите новый возраст: ");
            ageIsNumber = Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine($"Новые данные: имя {name443}, возраст {age}.");

            //4.4.5 Заполните данный кортеж значениями аналогично примерам, разобранным в модуле выше.
            (string name445, string type, double age, int nameCount) pet;
            Console.Write("Введите имя вашего pet: ");
            pet.name445 = Console.ReadLine();
            Console.Write("Введите тип (кошка, собака, муха и т.п.): ");
            pet.type = Console.ReadLine();
            Console.Write("Введите возраст в годах: ");
            ageIsNumber = double.TryParse(Console.ReadLine(), out pet.age);
            pet.nameCount = pet.name445.Length;
            Console.WriteLine("Вы ввели: " + pet.name445 + ", " + pet.type + ", " + pet.age + ". Длина введенного имени равна " + pet.nameCount);

            #endregion 4.4


            currentTask:
            #region 4.5
            //4.5.1 фамилии, логине, длине логина, наличии/отсутствии у пользователя питомца, возрасте пользователя, трех любимых цветах пользователя
            //Не совсем понятно, зачем хранить LoginLength
            (string FirstName, string LastName, string Login, int LoginLength, bool hasPet, string[] FavColors, double Age)[] user451 = new (string FirstName, string LastName, string Login, int LoginLength, bool hasPet, string[] FavColors, double Age)[3];

            for (int i = 0; i < user451.Length; i++)
            {
                Console.WriteLine($"Ввод информации о пользователе {i}");

                Console.Write("Введите имя: ");
                user451[i].FirstName = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                user451[i].LastName = Console.ReadLine();
                Console.Write("Введите логин: ");
                user451[i].Login = Console.ReadLine();
                //4.5.3
                user451[i].LoginLength = user451[i].Login.Length;
                //4.5.4 Напишите условие, которое устанавливает значение ИСТИНА в поле наличие/отсутствие животных, если пользователь вводит "Да", и ЛОЖЬ
                //при любом другом варианте
                Console.Write("Есть ли у Вас животные? ответьте y или n :");
                user451[i].hasPet = Console.ReadLine().ToLower() == "y" ? true : false;
                //4.5.5 Напишите код для ввода возраста пользователя и трех его любимых цветов
                Console.Write("Введите Ваш возраст: ");
                ageIsNumber = double.TryParse(Console.ReadLine(), out user451[i].Age);
                user451[i].FavColors = new string[3];
                for (int j = 0; j < user451[i].FavColors.Length; j++)
                {
                    Console.Write($"Введите любимый цвет № {j}: ");
                    user451[i].FavColors[j] = Console.ReadLine();
                }
            }
            for(int i = 0; i < user451.Length; i++)
            {
                Console.WriteLine($"\nВывод информации о пользователе {i}");
                Console.Write($"{user451[i].FirstName} {user451[i].LastName}, {user451[i].Login} (length is {user451[i].LoginLength}), {user451[i].Age}" +
                    $"{(user451[i].hasPet ? "" : "не")} имеет животных \nЛюбимые цвета:");
                foreach (string s in user451[i].FavColors)
                {
                    Console.Write(s + " ");
                }

            }
            #endregion

            Console.ReadKey();
        }
    }
}
