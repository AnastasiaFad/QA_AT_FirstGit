using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class HW1_1Week
    {
        public static string TheCentury(int date)
        {
            int alfa = date / 100;
            if (date % 100 > 0)
                alfa++;
           return ($"Это {alfa} век");
        }
        public static string TypeOfData(string str)
        {
            string result = "";
            int a;
            double b;
            char c;
            bool d;

            bool resultInt = int.TryParse(str, out a);
            bool resultDouble = double.TryParse(str, out b);
            bool resultChar = char.TryParse(str, out c);
            bool resultBool = bool.TryParse(str, out d);

            if (resultInt) result = "int";
            else if (resultDouble) result = "double";
            if (resultChar) result = "char";
            if (resultBool) result = "bool";
            if (!resultInt && !resultDouble && !resultChar && !resultBool) result = "string";

            return result;
        }
        public static string crossOrPile(string value, int numRND)
        {
            string result = "";
            string coin;
            if (value != "орел" && value != "решка")
                result = ("Введено неверное значение... ");
            else
            {
                if (numRND == 0) coin = "орел";
                else coin = "решка";

                if (coin == value)
                    result = ("Вы победили! ");
                else
                    result = ("Вы проиграли... ");
            }
            return result;
        }
        public static string howOldAreYou(string name1, int age1, string name2, int age2, string newName)
        {
            string result = "";
            if ((age1 > 0 && age2 > 0) && (newName.Equals(name1) || newName.Equals(name2)))
            {
                if ((age1 >= age2 && newName == name1) || (age2 >= age1 && newName == name2))
                    result += ("Правильно ");
                else
                    result += ("Не правильно ");
                if (age1 >= age2)
                    result += ($"{name1} старше {name2} на {age1 - age2} лет");
                else
                    result += ($"{name2} старше {name1} на {age2 - age1} лет");
            }
            else
                result += ("Не корректные данные!");
            return result;
        }
        public static bool correctName(string name)
        {
            bool status = true;
            string ban = "?!@#$%^&*()_+=1234567890`|/.,><";
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < ban.Length; j++)
                {
                    if (name[i].Equals(ban[j]))
                    {
                        status = false;
                    }
                }
            }
            return status;
        }

        public static string salesOfBuy(int price)
        {
            string result = "";
            if (price < 500) result = "У вас нет скидки...";
            if (price >= 500 && price < 1000)
                result = ($"Ваша скидка составляет 50$, а окончательная стоимость покупки составляет {price - 50}");
            if (price >= 1000)
                result = ($"Ваша скидка составляет 100$, а окончательная стоимость покупки составляет {price - 100}");
            return result;
        }
        public static string quotientOfNumber(double number1, double number2)
        {
            string result = "";
            if (number2 == 0)
                result = ("На ноль делить нельзя!");
            else
                result = ($"{number1} / {number2} = " + (number1 / number2));
            return result;
        }
        public static string HotOrCold(int temperature)
        {
            string result = "";
            if (temperature >= -20 && temperature <= 5)
                result = "На улице холодно...";
            else if (temperature >= 6 && temperature <= 15)
                result = "Прохладно...";
            else if (temperature >= 16 && temperature <= 20)
                result = "Тепло))";
            else if (temperature >= 21 && temperature <= 35)
                result = "Жарко((";
            else if (temperature >= 36 && temperature <= 45)
                result = "ОЧЕНЬ Жарко((";
            else
                result = "Такая температура не может быть";

            return result;
        }
        public static string _3Numbers(int number1, int number2, int number3)
        {
            string result = "";
            if (number1 >= number2 && number1 >= number3)
                result = ($"Число {number1} самое больше из введенных чисел");

            else if (number2 >= number1 && number2 >= number3)
                result = ($"Число {number2} самое больше из введенных чисел");

            else if (number3 >= number1 && number3 >= number2)
                result = ($"Число {number3} самое больше из введенных чисел");
            return result;
        }
        public static string newDayOfTheWeek(string date)
        {
            DateTime today = (DateTime.Today);
            DateTime minday = (DateTime.MinValue);
            string result = "";
            string[] text = date.Split(".");
            int[] num = new int[3];
            num[0] = Convert.ToInt32(text[0]);
            num[1] = Convert.ToInt32(text[1]);
            num[2] = Convert.ToInt32(text[2]);

            if (num[0] > 0 && num[1] > 0 && num[2] > 0)
            {
                DateTime someDate = Convert.ToDateTime(date);
                if (someDate >= minday && someDate <= today)
                    result = (someDate.DayOfWeek).ToString();
                else result = ("Введенная дата некорректна \n");
            }
            else
                result = ("Введенная дата некорректна \n");
            return result;
        }
    }
}
