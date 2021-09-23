using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class HW1_Conditions
    {
        public static void CountSumOrMultip()
        {
            Console.Write("Пожалуйста, введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Пожалуйста, введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Результат: " + (a % 2 != 0 ? a + b : a * b) + "\n");
            Program.goToMenu();
        }
        public static string Coordinates()
        {
            Console.Write("Пожалуйста, введите 1-ю координату х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Пожалуйста, введите 2-ю координату у: ");
            int y = Convert.ToInt32(Console.ReadLine());
            string quater = "ups...";

            if (!(x == 0 || y == 0))
                switch (x > 0)
                {
                    case false when y > 0:
                        quater = "2 quarter";
                        break;
                    case true when y > 0:
                        quater = "1 quarter";
                        break;
                    case true when y < 0:
                        quater = "4 quarter";
                        break;
                    case false when y < 0:
                        quater = "3 quarter";
                        break;
                }
            Program.goToMenu();
            return quater;
        }
        public static int GetSumPositiveNum()
        {
            Console.Write("Введите число а: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c: "); int c = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a >= 0)
                sum += a;
            if (b >= 0)
                sum += b;
            if (c >= 0)
                sum += c;
            Program.goToMenu();
            return sum;
        }
        public static void PrintMaximumFromSumOrMultip()
        {
            Console.Write("Введите число а: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c: "); int c = Convert.ToInt32(Console.ReadLine());
            int multip = a * b * c;
            int sum = a + b + c;
            Console.WriteLine("Результат: " + (sum > multip ? sum + 3 : multip + 3));
            Program.goToMenu();
        }
        public static string Rating()
        {
            Console.Write("Введите оценку: ");
            int value = Convert.ToInt32(Console.ReadLine());
            string rating = "ups...";
            if (value > 0 && value <= 19)
                rating = "rating: F";
            else if (value >= 20 && value <= 39)
                rating = "rating: E";
            else if (value >= 40 && value <= 59)
                rating = "rating: D";
            else if (value >= 60 && value <= 74)
                rating = "rating: C";
            else if (value >= 75 && value <= 89)
                rating = "rating: B";
            else if (value >= 90 && value <= 100)
                rating = "rating: A";
            Program.goToMenu();
            return rating;
        }
    }
}
