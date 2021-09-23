using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class HW4_Cyrcle
    {
        public static void calculateParametersOfTheCircle()
        {
            double radius;
            int result = interactionWithUser();
            double res = 1;

            GiveRadius(out radius);
            if (result == 1)
                res = countPerimeter(radius);
            else if (result == 2)
                res = countSquare(radius);
            else if (result == 3)
                res = radius;

            Console.WriteLine("Результат: " + res);
            Program.goToMenu();
        }
        static int interactionWithUser()
        {
            Console.WriteLine("Привет, здесь ты можешь посчитать некоторые величины, относящиеся кругу: \n" +
                " \n Чтобы посчитать периметр, введи: 1 " +
                "\n Чтобы посчитать площадь, введи: 2 " +
                "\n Для вычисления радиуса окружности, введи: 3 \n");
            return int.Parse(Console.ReadLine());
        }
        static double GiveRadius(out double radius)
        {
            Console.Write("Введите, пожалуйста, диаметр: ");
            double diametr = double.Parse(Console.ReadLine());
            radius = diametr / 2;
            return diametr;
        }
        static double countPerimeter(double radius) => radius * 2 * 3.14;
        static double countSquare(double radius) => radius * radius * 3.14;

    }
}
