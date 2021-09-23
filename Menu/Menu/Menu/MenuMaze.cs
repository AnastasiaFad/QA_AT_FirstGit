using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class MenuMaze
    {
        public static void StartMenu6()
        {
            Console.WriteLine("\n Какой номер решения вывести на экран? \n");
            Console.WriteLine(" 1. Вывести рандомный массив\n" +
                " 2. Пройти рандосный лабиринт\n" +
                " 3. Вернуться назад\n ");

            int todo6_1 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (todo6_1)
            {
                case 1:
                    Maze_Start.PaintMaze();
                    break;
                case 2:
                    Maze_Start.MainStart();
                    break;
                case 3:
                    Program.Start();
                    break;
            }
        }
    }
}
