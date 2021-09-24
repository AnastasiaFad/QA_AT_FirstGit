using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class HW2_week2_part1
    {
        public static void _Calculate()
        {
            Console.Write("посчитать выражение: ");
            var calculate = Console.ReadLine().ToLower();
            calculate = calculate.Replace("на ", "");
            calculate = calculate.Replace("с ", "");
            calculate = calculate.Replace("от ", "");

            var text = calculate.Split(" ");
            double num1 = double.Parse(text[1]);
            double num2 = double.Parse(text[2]);
            var textChar = text[0];
            double result = 0;

            if (textChar.Equals("отнять"))
                result = (num2 - num1);
            else if (textChar.Equals("суммировать"))
                result = (num1 + num2);
            else if (textChar.Equals("поделить"))
            {
                if (num2 != 0)
                    result = (num1 / num2);
                else
                    Console.WriteLine("На ноль делить нельзя");
            }
            else if (textChar.Equals("умножить"))
                result = (num1 * num2);

            Console.WriteLine($"Результат: {result}");
            Program.goToMenu();
        }
        public static void myBigMe()
        {
            string text = "Вчера я был на речке, там я купался и загорал, из-за того, что я уснул, то я очень обгорел.";
            var words = text.Split(" ");
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals("я"))
                    count1++;
                if (words[i].Contains("я"))
                    count2++;
            }
            Console.WriteLine("Кол-во отдельных я: " + count1);
            Console.WriteLine("Общее кол-во я: " + count2);
            Program.goToMenu();
        }
        public static void ChangeName()
        {
            string myString = "Добрый день, Гриша, ваш   заказ #123123 находится в обработке .";
            myString = myString.Replace("ш   з", "ш з");
            myString = myString.Replace("#123123 ", "");
            myString = myString.Replace(" .", ".");
            Console.WriteLine(myString);
            Program.goToMenu();
        }

        
    }
}
