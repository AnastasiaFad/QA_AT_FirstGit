using System;
using static System.Console;
using System.Threading;

namespace Menu
{
    class Program
    {
        public static string StartMenu = ("  Задания до курсов -> 0\n" 
                                        + "  Первая неделя -> 1\n" 
                                        + "  Вторая неделя -> 2\n" 
                                        + "  Третья неделя -> 3\n" 
                                        + "  Четверная неделя -> 4\n" 
                                        + "  Пятая неделя -> 5\n"                                          
                                        + "  Лабиринт -> 6\n" 
                                        + "  Закрыть -> 7\n");        
        static void Main(string[] args)// "  Шестая неделя -> 6\n"
        {
            Start();
           
        }

        public enum MainMenu 
        {
            HwBeforeCourse = 0,
            DataTypesAndIfElse,
            Strings,
            ArraysAndLoops,
            Functions,
            Struct,
            Maze,
            Exit
        }

        public static void Start()
        {
            Title = "Меню домашек";
            WriteLine("  Для перехода в необходимый раздел, нажмите число после указателя '->' \n");
            WriteLine(StartMenu);
            //MainMenu todo1 = (MainMenu)Enum.typeof((MainMenu), ReadLine());
            int goToDo1 = int.Parse(ReadLine());
            if(goToDo1 > 8 || goToDo1 < -1)
            {
                Clear();
                Start();
            }
            MainMenu todo1 = (MainMenu)goToDo1;
            Clear();
            goFromMenu1(todo1);            
        }
       
        public static void goFromMenu1(MainMenu menu)
        {
            switch (menu)
            {
                case MainMenu.HwBeforeCourse: Menu0.StartMenu0();
                    break;
                case MainMenu.DataTypesAndIfElse:
                    Menu1.StartMenu1();
                    break;
                case MainMenu.Strings:
                    Menu2.StartMenu2(); 
                    break;
                case MainMenu.ArraysAndLoops:
                    Menu3.StartMenu3();
                    break;
                case MainMenu.Functions:
                    Menu4.StartMenu4();
                    break;
                case MainMenu.Struct:
                    Menu5.StartMenu5();
                    break;
                case MainMenu.Maze:
                    MenuMaze.StartMenu6();
                    break;
                case MainMenu.Exit: return;
            }
        }
        public static void goToMenu()
        {
            WriteLine("\n Если хотите вернуться в начало меню -> 1\n" +
                " Если хотите закрыть программу полностью -> 2\n");
            int value = int.Parse(ReadLine());
            Clear();
            if (value == 1)
                Program.Start();
            else if (value == 2)
                goFromMenu1(MainMenu.Exit);
        }
    }
}
