using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Menu4
    {
        public static string Menu4_1 = (" 1. Создать простой, но надежный калькулятор с использованием методов.\n" +
            " 2. Kнигa имен.\n" +
            " 3. Создать программу, которая может вычислить периметр, площадь, радиус окружности \n" +
            " 4. Разработать методы вывода фигур из ноликов\n" +
            " 5. Вернуться назад\n");
        public static void StartMenu4()
        {
            Console.WriteLine("\n Какой номер решения вывести на экран? \n");
            Console.WriteLine(Menu4_1);
            int todo5_1 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (todo5_1)
            {
                case 1:
                    HW4_Calculate.UseCalculate();
                    break;
                case 2:
                    HW4_Vocabulary.CallVocabulary();
                    break;
                case 3:
                    HW4_Cyrcle.calculateParametersOfTheCircle();
                    break;
                case 4:
                    HW4_Shapes.PrintShapes();
                    break;
                case 5:
                    Program.Start();
                    break;
            }
        }        
    }
}
