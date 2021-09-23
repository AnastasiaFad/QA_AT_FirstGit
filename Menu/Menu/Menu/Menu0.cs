using System;
using static System.Console;

namespace Menu
{
    public class Menu0
    {
        public static string Menu1_1 = (" Условные операторы -> 1\n" + " Циклы -> 2\n" + " Одномерные массивы -> 3\n" + " Функции -> 4\n" + " Назад -> 5\n");

        public static void StartMenu0()
        {
            WriteLine("\n" + Menu1_1);
            int todo1_1 = int.Parse(ReadLine());
            Clear();
            switch (todo1_1)
            {
                case 1:
                    Condition();
                    break;
                case 2:
                    Loops();
                    break;
                case 3:
                    Arrays();
                    break;
                case 4:
                    Funcions();
                    break;
                case 5:
                    Program.Start();
                    break;
            }
        }
        static void Condition()
        {
            WriteLine("\n Какой номер решения вывести на экран? \n");

            string taskCondition = (" 1. Если а – четное посчитать а*б, иначе а+б\n" +
            " 2. Определить какой четверти принадлежит точка с координатами(х, у)\n" +
            " 3. Найти суммы только положительных из трех чисел \n" +
            " 4. Посчитать выражение макс(а* б*с, а + б + с)+3\n" +
            " 5. Написать программу определения оценки студента по его рейтингу, на основе следующих правил: \n" +
            " Рейтинг - Оценка\n" +
            "  0 - 19 F\n" +
            "  20 - 39 E\n" +
            "  40 - 59 D\n" +
            "  60 - 74 C \n" +
            "  75 - 89 B\n" +
            "  90 - 100 A\n"+
            " 6. Вернуться назад\n");
            WriteLine(taskCondition);
            int num = int.Parse(ReadLine());
            Clear();
            switch (num)
            {
                case 1:
                    HW1_Conditions.CountSumOrMultip();
                    break;
                case 2:
                    Console.WriteLine("Result "+ HW1_Conditions.Coordinates());                    
                    break;
                case 3:
                    Console.WriteLine("Result " + HW1_Conditions.GetSumPositiveNum());                    
                    break;
                case 4:
                    HW1_Conditions.PrintMaximumFromSumOrMultip();
                    break;
                case 5:
                    Console.WriteLine("Result " + HW1_Conditions.Rating());                    
                    break;
                case 6:
                    StartMenu0();
                    break;
            }
            
        }
        static void Loops()
        {
            WriteLine("\n Какой номер решения вывести на экран? \n");
            string loopsTask = (" 1. Найти сумму четных чисел и их количество в диапазоне от 1 до 99 \n" +
                " 2. Проверить простое ли число ?\n" +
                " 3. Найти корень натурального числа с точностью до целого методом последовательного подбора \n" +
                " 4. Найти корень натурального числа с точностью до целого методом бинарного поиска\n" +
                " 5. Вычислить факториал числа n.\n" +
                " 6. Посчитать сумму цифр заданного числа\n" +
                " 7. Вывести число, которое является зеркальным отображением последовательности цифр заданного числа\n" +
                " 8. Вернуться назад\n");
            WriteLine(loopsTask);
            int num = int.Parse(ReadLine());
            Clear();
            switch (num)
            {
                case 1:
                      HW1_Loops.SumEvenNum();
                    break;
                case 2:
                    Console.WriteLine("Result " + HW1_Loops.IsSimpleNumber(7));                    
                    break;
                case 3:
                    Console.WriteLine("Result " + HW1_Loops.GetFindTheRoot(345));                    
                    break;
                case 4:
                    Console.WriteLine("Result " + HW1_Loops.GetFindTheRootBinary(623));                    
                    break;
                case 5:
                    Console.WriteLine("Result " + HW1_Loops.SearchFactorial(14));                    
                    break;
                case 6:
                    Console.WriteLine("Result " + HW1_Loops.GetSumOfDigits(7081));                    
                    break;
                case 7:
                    HW1_Loops.MirrorNumber(12345);
                    break;
                case 8:
                    StartMenu0();
                    break;
            }
        }
        static void Arrays()
        {
            WriteLine("\n Какой номер решения вывести на экран? \n");
            string arrayTask = (" 1. Найти минимальный элемент массива\n" +
                " 2. Найти максимальный элемент массива \n" +
                " 3. Найти индекс минимального элемента массива\n" +
                " 4. Найти индекс максимального элемента массива\n" +
                " 5. Посчитать сумму элементов массива с нечетными индексами\n" +
                " 6. Сделать реверс массива\n" +
                " 7. Посчитать количество нечетных элементов массива\n" +
                " 8. Поменять местами первую и вторую половину массива\n" +
                " 9. Bubble sort\n" +
                " 10. Select sort\n" +
                " 11. Insert sort\n" +
                " 12. Вернуться назад\n");
            WriteLine(arrayTask);
            int num = int.Parse(ReadLine());
            Clear();
            int[] theArray = { -1, 2, 4, 5, 7, 1, 6, 0 };
            switch (num)
            {
                case 1:
                    Console.WriteLine("Result " + HW1_Array.GetMinElemArray(theArray));
                    Program.goToMenu();
                    break;
                case 2:
                    Console.WriteLine("Result " + HW1_Array.GetMaxElemArray(theArray));
                    Program.goToMenu();
                    break;
                case 3:
                    Console.WriteLine("Result " + HW1_Array.GetMinIndex(theArray));
                    Program.goToMenu();
                    break;
                case 4:
                    Console.WriteLine("Result " + HW1_Array.GetMaxIndex(theArray));
                    Program.goToMenu();
                    break;
                case 5:
                    Console.WriteLine("Result " + HW1_Array.GetSumOfOddIndex(theArray));
                    Program.goToMenu();
                    break;
                case 6:
                    HW1_Array.ReversArray(theArray);
                    Program.goToMenu();
                    break;
                case 7:
                    Console.WriteLine("Result " + HW1_Array.CountOfOddIndex(theArray));
                    Program.goToMenu();
                    break;
                case 8:
                    HW1_Array.ReversFirtHalfOfArray(theArray);
                    Program.goToMenu();
                    break;
                case 9:
                    var array = HW1_Array.BubleSort(theArray);
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    Program.goToMenu();
                    break;
                case 10:
                    array = HW1_Array.SelectionSort(new int[] { 9, 3, 4, 5, 7, 1, 6, 0, 9, 4, 3, 9, 10 });
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    Console.WriteLine();
                    Program.goToMenu();
                    break;
                case 11:
                    array = HW1_Array.InsertionSort(theArray);
                    Console.Write("Insert sort: { ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    Console.Write("}");
                    Program.goToMenu();
                    break;
                case 12:
                    StartMenu0();
                    break;
            }
        }
        static void Funcions()
        {
            WriteLine("\n Какой  номер решения вывести на экран? \n");
            string functionTask = ("1. Получить строковое название дня недели по номеру дня.\n" +
                " 2. Вводим число(0 - 999), получаем строку с прописью числа.\n" +
                " 3. Вводим строку, которая содержит число, написанное прописью(0 - 999). Получить само число\n" +
                " 4. Найти расстояние между двумя точками в двумерном декартовом пространстве.\n" +
                " 5. Вернуться назад\n");
            WriteLine(functionTask);
            int num = int.Parse(ReadLine());
            Clear();
            switch (num)
            {
                case 1:
                    Console.WriteLine("Result " + HW1_Functions.DayOfTheWeek(3));
                    Program.goToMenu();
                    break;
                case 2:
                    HW1_Functions.NumberToString(465);
                    Program.goToMenu();
                    break;
                case 3:
                    HW1_Functions.StringToNumber("пятьсот четырнадцать");
                    Program.goToMenu();
                    break;
                case 4:
                    Console.WriteLine("Result " + HW1_Functions.Distance(-1, 4, 2, 9));
                    Program.goToMenu();
                    break;
                case 5:
                    StartMenu0();
                    break;
                
            }
        }
    }
}
