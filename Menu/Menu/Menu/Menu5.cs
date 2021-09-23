using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Menu5
    {

        public static string Menu5_1 = (" СТРУКТУРЫ\n" +
            " 1. Необходимо создать программу по регистрации и авторизации пользователя. \n" +
            " 2. Организовать очередь на прием к доктору с помощью Queue\n" +
            " 3. Создать телефонную книгу\n " +
            " 4. Расширенная версия игры “Камень-ножницы-бумага и правила игры” \n" +            
            " 5. Вернуться назад\n");
        public static void StartMenu5()
        {
            string[] args = { "hello" };
            Console.WriteLine("\nКакой номер решения вывести на экран? \n");
            Console.WriteLine(Menu5_1);
            int todo5_1 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (todo5_1)
            {
                case 1:
                    hw5_registration.Start5.Menu();
                    Program.goToMenu();
                    break;
                case 2:
                    hw5_phoneBook.Program.MainStart();
                    Program.goToMenu();
                    break;
                case 3:
                    hw5_Doctor.Program.MainStart();
                    Program.goToMenu();
                    break;
                case 4:
                    Game.Start.Main(args);
                    Program.goToMenu();
                    //Console.WriteLine("Не подкючен в меню из-за проблем с доступностью линкед листа");                    
                    break;
                case 5:                    
                    Program.Start();
                    break;
            }
        }
    }
}
