using System;

namespace Menu
{
    class Menu3
    {
        public static string Menu4_1 = (" 1. Вывести все элементы массива используя все виды циклов.\n" +
            " 2. Расположить все элементы массива в обратном порядке и вывести в консоль\n" +
            " 3. Выводить все элементы массива пока не встретится элемент с не положительным значением.\n" +
            " 4. Необходимо добавить элемент в конец или начало массива\n" +
            " 5. Вывести сумму всех чисел двумерного массива, нужно использовать циклы.\n" +
            " 6. Вывести двумерный массив в консоль, чтобы элементы располагались в виде матрицы.\n" +
            " 7. Вывести двумерный массив в консоль, чтобы элементы располагались в виде матрицы, негативные цифры не должны выводиться.\n" +
            " 8. Слова в предложении с заглавной буквы\n" +
            " 9. Пользователь вводит 6 своих последних зарплат, ему выводится максимальная, минимальная, средняя зп и общая сумма\n" +
            " 10. Пользователь может ввести сколько угодно данных в таблицу\n" +
            " 11. Угадай числа в массиве\n" +
            " 12. Вернуться назад\n");
        public static void StartMenu3()
        {
            Console.WriteLine("\nКакой номер решения вывести на экран? \n");
            Console.WriteLine(Menu4_1);
            int todo4_1 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (todo4_1)
            {
                case 1:
                    HW3_week3_part1.ArrayOtput(Print());
                    break;
                case 2:
                    HW3_week3_part1.ReversArray(Print());
                    break;
                case 3:
                    HW3_week3_part1.PositiveElemOfArray(Print());
                    break;
                case 4:
                    HW3_week3_part1.addElemToArray();
                    break;
                case 5:
                    HW3_week3_part1.SumOfElemInArr();
                    break;
                case 6:
                    HW3_week3_part2.print2Array();
                    break;
                case 7:
                    HW3_week3_part2.printPosivive2Array();
                    break;
                case 8:
                    HW3_week3_part2.MainWords();
                    break;
                case 9:
                    HW3_week3_part2.AllSalary();
                    break;
                case 10:
                    HW3_week3_part2.fillTheTable();
                    break;
                case 11:
                    HW3_week3_part2.GameWithRandomNumbers();
                    break;
                case 12:
                    Program.Start();
                    break;
                
            }

        }
        public static int[] Print()
        {
            Console.WriteLine("Please, enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter an array: ");
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
    }
}
