using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class HW3_week3_part2
    {
        public static void print2Array()
        {
            Console.WriteLine("Please, enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the dimension length of the array: ");
            int diment = int.Parse(Console.ReadLine());

            int[,] array = Cout(size, diment);
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" " + array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Program.goToMenu();
        }
        public static int[,] Cout(int size, int diment)
        {
            Console.WriteLine("Please, enter an array: ");
            int[,] array = new int[size, diment];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"y: {i}, x: {j}");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Program.goToMenu();
            return array;
        }

        public static void printPosivive2Array()
        {
            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                        Console.Write(" " + array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Program.goToMenu();
        }

        public static void MainWords()
        {
            Console.WriteLine("Введите, пожалуйста, предложение, в котором нужно найти слова с заглавных букв: ");
            string text = Console.ReadLine();
            string[] words = text.Split(" ");
            int count = 0;

            Console.Write("Это слова: ");
            for (int i = 0; i < words.Length; i++)
            {
                var isBigLetter = Char.ToUpper(words[i][0]);
                if (isBigLetter.Equals(words[i][0]))
                {
                    count++;
                    Console.Write(words[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Кол-во слов соответствующие условиям: " + count);
            Program.goToMenu();
        }

        public static void AllSalary()
        {
            Console.WriteLine("Введите, пожалуйста 6 своих последних зарплат: ");
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = array[0], max = array[0], sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
                sum += array[i];
            }
            Console.WriteLine($"Максимальная ЗП: {max}\nМинамальная ЗП: {min}\nСреднаяя ЗП: {sum / 6}\nОбщая сумма: {sum}");
            Program.goToMenu();
        }
        public static void fillTheTable()
        {
            Console.WriteLine("Введите данные для таблицы в формате '23;Dima;Petrov;Dnepr;' ,\nчтобы закончить и вывести таблицу, введите: stop \n");
            var text = new string[1000];

            for (int i = 0; ; i++)
            {
                text[i] = Console.ReadLine();
                if (text[i] == "stop")
                    break;
            }
            var mass = "Age,First Name,Second Name,City";
            var mass2 = mass.Split(',');
            Console.Write("| ");
            for (int i = 0; i < mass2.Length; i++)
            {
                Console.Write(mass2[i] + " | ");
            }
            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (!text[i].Equals("stop"))
                {
                    var mass3 = text[i].Split(';');
                    Console.Write("| ");
                    for (int j = 0; j < mass3.Length - 1; j++)
                    {
                        Console.Write(mass3[j] + " | ");
                    }
                    Console.WriteLine();
                }
                else break;
            }
            Program.goToMenu();
        }
        public static void GameWithRandomNumbers()
        {
            int[,] arrayNum = new int[5, 5];
            string[,] arrayStr = new string[5, 5];
            string[,] zvezda = new string[5, 5];
            int success = 0, fail = 0, tryMore = 0;
            int counter = 25;
            int max = 0;

            Random random = new Random();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    arrayNum[i, j] = random.Next(0, 20);
                    arrayStr[i, j] = Convert.ToString(arrayNum[i, j]);
                }

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    zvezda[i, j] = "*";

            Console.WriteLine("Попробуй угадать какое число есть в массиве!");
            while (true)
            {
                bool result = false;
                Console.WriteLine("Введите одно число если хотите попытаться угадать число матрицы или нажмите клавишу 'S' если хотите закончить");
                string chance = Console.ReadLine().ToLower();
                tryMore++;
                if (chance.Contains("s"))
                    break;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arrayStr[i, j].Equals(chance))
                        {
                            zvezda[i, j] = zvezda[i, j].Replace("*", chance);
                            result = true;
                            counter--;
                        }
                    }
                }
                if (result == true)
                {
                    Console.WriteLine($"Поздравляю, вы угадали число {chance}!");
                    success++;
                }
                else
                {
                    Console.WriteLine("Не повезло!");
                    fail++;
                    if (max < success)
                        max = success;
                    success = 0;
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                        Console.Write(zvezda[i, j] + " ");
                    Console.WriteLine();
                }
                if (counter == 0)
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"Общее число попыток: {tryMore}. Количество неудачных попыток: {fail}. Самая длинная серия успешних попыток: {max}");
            Program.goToMenu();
        }        
        public static void Array3()
        {
            //string str = "!@#$%^&*()_+~";
            var array = new[, ,]
            {
                {
                    { "(((&Y@#06u%^&", "m6u%$^s!1", " t0" },
                    { "k@!!^n0!@w", "?*()h0&&w", "!1#$!0*" },
                    { " !@#w0)(r&*(&k ", "&*w*i61^h%", "a@#$r$$$$r@ay#%s" },
                    { "!@a@!##@n!@#!@d##", "w*i61^h%", "!@#!$%$c!@#!y^&*^&*c$%^l$%^e$%^s!#@!@" }
                }
            };

            Console.WriteLine("Y0u must t0 kn0w h0w t0 w0rk with arrays and with cycles");
            Program.goToMenu();
        }


    }
}

