using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Menu
{
    class HW4_Calculate
    {
        public static void UseCalculate()
        {
            WriteLine("Привет, это калькулятор ");
            Write("Введите первое число: ");
            double num1 = double.Parse(ReadLine());

            double DoubleResult = giveMeInfo(num1);
            WriteLine(DoubleResult);
            Start(num1);
            Program.goToMenu();
        }
        static void Start(double num1)
        {
            if (goAgain())
            {
                WriteLine(giveMeInfo(num1));
                Start(num1);
            }
        }
        static bool goAgain()
        {
            WriteLine("Вы хотите продолжить? Если да, напиши 1, если нет, то 0: ");

            int answer = int.Parse(ReadLine());
            if (answer == 1)
                return true;
            else return false;
        }
        static double giveMeInfo(double num1)
        {
            Write("Введите действие: ");
            string action = ReadLine();
            Write("Введите второе число: ");
            double num2 = double.Parse(ReadLine());

            return Calculate(num1, num2, action);
        }

        public static double Calculate(double number1, double number2, string action)
        {
            double result = 0;
            if (action.Equals("+"))
                result = GetSum(number1, number2);
            else if (action.Equals("-"))
                result = GetMinus(number1, number2);
            else if (action.Equals("*"))
                result = GetMultiply(number1, number2);
            else if (action.Equals("/"))
            {
                if (number2 != 0)
                    result = GetDivide(number1, number2);
                else
                {
                    WriteLine("На ноль делить нельзя...");
                    Start(number1);
                }
            }
            else
            {
                WriteLine("Вы ввели некорректное действие. Попробуйте снова: ");
                Start(number1);
            }
            return result;
        }
        static double GetSum(double number1, double number2) => number1 + number2;
        static double GetMinus(double number1, double number2) => number1 - number2;
        static double GetMultiply(double number1, double number2) => number1 * number2;
        static double GetDivide(double number1, double number2) => number1 / number2;
    }
}
