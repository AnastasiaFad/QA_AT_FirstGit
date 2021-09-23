using System;
using static System.Console;

namespace Menu
{
    class Menu2
    {
        public static string Menu3_1 = (" 1. Вводим дату словами\n" +
            " 2. Необходимо создать простой калькулятор, который может при вводе строке в виде 'отними 123 от 31' \n" +
            " 3. Нужно удалить из строки лишние пробелы, изменить имя Гриша на Григорий, и номер заказа '#123123' удалить вместе с ненужными пробелами.\n" +
            " 4. Найти кол-во дубликатов 'я' в предложении и вывести их кол-во\n " +
            " 5. Ввести 4 строки в консоль. Найти палиндром\n" +
            " 6. Из введенной строки необходимо удалить все записи на транслите, выделить каждое имя собственное как обращение и все большие буквы стоящие в середине слова заменить на маленькие \n" +
            " 7. Вернуться назад\n");
        public static void StartMenu2()
        {
            WriteLine("\nКакой номер решения вывести на экран? \n");
            WriteLine(Menu3_1);
            int todo3_1 = int.Parse(ReadLine());
            Clear();
            switch (todo3_1)
            {
                case 1:
                    HW2_week2_part2.strToDate();
                    break;
                case 2:
                    HW2_week2_part1._Calculate();
                    break;
                case 3:
                    HW2_week2_part1.ChangeName();
                    break;
                case 4:
                    HW2_week2_part1.myBigMe();
                    break;
                case 5:
                    HW2_week2_part2.Palindrome();
                    Program.goToMenu();
                    break;
                case 6:
                    HW2_week2_part2.textWithTranslite();
                    break;
                case 7:                   
                    Program.Start();
                    break;
            }
        }
    }
}
