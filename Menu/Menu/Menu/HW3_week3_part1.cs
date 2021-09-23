using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class HW3_week3_part1
    {
        public static void ArrayOtput(int[] array)
        {
            Console.Write("foreach { ");
            foreach (var elem in array)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine("}");

            Console.Write("for { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("}");

            int j = 0;
            Console.Write("while { ");
            while (j < array.Length)
            {
                Console.Write(array[j] + " ");
                j++;
            }
            Console.WriteLine("}");

            int k = 0;
            Console.Write("do while { ");
            do
            {
                Console.Write(array[k] + " ");
                k++;
            }
            while (k < array.Length);
            Console.WriteLine("}");
            Program.goToMenu();
        }
        public static void ReversArray(int[] array)
        {
            Console.Write("Revers of array: ");
            Console.Write("{ ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                    Console.Write(array[i] + ", ");
                else if (i == 0)
                    Console.Write(array[i]);
            }
            Console.Write(" }");
            Program.goToMenu();
        }
        public static void PositiveElemOfArray(int[] array)
        {
            Console.Write("for { ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    break;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("}");
            Program.goToMenu();
        }
        public static void addElemToArray()
        {
            var array = new int[] { 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111 };
            Console.WriteLine("Напиши, куда ты хочешь ввести элемент массива: ");
            string word = Console.ReadLine().ToLower();
            Console.WriteLine($"Напиши, какое значение ты хочешь добавить {word}: ");
            int num = int.Parse(Console.ReadLine());

            int[] newArray = new int[12];
            if (word.Contains("нач"))
            {
                newArray[0] = num;
                for (int i = 1; i < newArray.Length;)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        newArray[i] = array[j];
                        i++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < newArray.Length - 1;)
                {
                    for (int j = 0; j < newArray.Length; j++)
                    {
                        if (i != 11)
                            newArray[i] = array[j];
                        else
                            newArray[11] = num;
                        i++;
                    }
                }
            }
            Console.Write(" { ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine("}");
            Program.goToMenu();
        }
        public static void SumOfElemInArr()
        {
            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
            int count = 0;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    count += array[i, j];
                }
            }
            Console.WriteLine(count);
            Program.goToMenu();
        }
    }
}
