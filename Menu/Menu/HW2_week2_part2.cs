using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class HW2_week2_part2
    {
        public static void Palindrome()
        {
            Console.WriteLine("Введите первую строку:");
            var str_1 = Console.ReadLine().ToLower();
            Console.WriteLine("Введите вторую строку:");
            var str_2 = Console.ReadLine().ToLower();
            Console.WriteLine("Введите третью строку:");
            var str_3 = Console.ReadLine().ToLower();
            Console.WriteLine("Введите четвертую строку:");
            var str_4 = Console.ReadLine().ToLower();
            Console.WriteLine();
            var result = false;

            int avarage = (str_1.Length + str_2.Length + str_3.Length + str_4.Length) / 4;

            var arreystr_1 = str_1.Split(" ");
            var arreystr_2 = str_2.Split(" ");
            var arreystr_3 = str_3.Split(" ");
            var arreystr_4 = str_4.Split(" ");


            if (avarage > str_1.Length && !arreystr_1.Length.Equals(" "))
            {
                for (int i = 0; i < arreystr_1.Length; i++)
                {
                    for (int j = 0; j < arreystr_1[i].Length / 2; j++)
                    {
                        var slovo_rev_1 = arreystr_1[i];
                        string reverse_slovo = Reverse(slovo_rev_1);
                        if (reverse_slovo.Equals(arreystr_1[i]))
                            result = true;
                    }
                }
                if (result != true)
                    Console.WriteLine("1 предложение не содержить полиндром");
                else
                    Console.WriteLine($"{str_1}, длинна: {str_1.Length}");
            }
            if (avarage > str_2.Length && !arreystr_2.Length.Equals(" "))
            {
                for (int i = 0; i < arreystr_2.Length; i++)
                {
                    for (int j = 0; j < arreystr_2[i].Length / 2; j++)
                    {
                        var slovo_rev_2 = arreystr_2[i];
                        string reverse_slovo = Reverse(slovo_rev_2);
                        if (reverse_slovo.Equals(arreystr_2[i]))
                            result = true;
                    }
                }
                if (result == true)
                    Console.WriteLine($"{str_2}, длинна: {str_2.Length}");
                else
                    Console.WriteLine("2 предложение не содержить полиндром");
            }
            if (avarage > str_3.Length && !arreystr_3.Length.Equals(" "))
            {
                for (int i = 0; i < arreystr_3.Length; i++)
                {
                    for (int j = 0; j < arreystr_3[i].Length / 2; j++)
                    {
                        var slovo_rev_3 = arreystr_3[i];
                        string reverse_slovo = Reverse(slovo_rev_3);
                        if (reverse_slovo.Equals(arreystr_3[i]))
                            result = true;
                    }
                }
                if (result == true)
                    Console.WriteLine($"{str_3}, длинна: {str_3.Length}");
                else
                    Console.WriteLine("3 предложение не содержить полиндром");
            }
            if (avarage > str_4.Length && !arreystr_4.Length.Equals(" "))
            {
                for (int i = 0; i < arreystr_4.Length; i++)
                {
                    for (int j = 0; j < arreystr_4[i].Length / 2; j++)
                    {
                        var slovo_rev_4 = arreystr_4[i];
                        string reverse_slovo = Reverse(slovo_rev_4);
                        if (reverse_slovo.Equals(arreystr_4[i]))
                            result = true;
                    }
                }
                if (result == true)
                    Console.WriteLine($"{str_4}, длинна: {str_4.Length}");
                else
                    Console.WriteLine("4 предложение не содержить полиндром");

            }
            if (avarage < str_4.Length && avarage < str_3.Length && avarage < str_2.Length && avarage < str_1.Length)
                Console.WriteLine("Нет строки подходящей под условия задания");

        }
        static String Reverse(String str)
        {
            var charArr = str.ToCharArray();
            int size = charArr.Length;
            for (int i = 0; i < size / 2; i++)
            {
                char temp = charArr[size - (i + 1)];
                charArr[size - (i + 1)] = charArr[i];
                charArr[i] = temp;
            }
            Program.goToMenu();
            return String.Join("", charArr);
        }
        public static void strToDate()
        {
            string[] num = new string[] {"первое", "второе", "третье", "четвертое", "пятое", "шестое", "седьмое", "восьмое",
                "девятое", "десятое","одинадцатое", "двенадцатое", "тринадцатое", "четырнадцатое", "пятьнадцатое", "шестьнадцатое",
                "семьнадцатое", "восемьнадцатое", "девятьнадцатое", "двадцатое", "двадцать первое", "двадцать второе", "двадцать третье",
                "двадцать четвертое","двадцать пятое", "двадцать шестое","двадцать седьмое", "двадцать восьмое", "двадцать девятое", "тридцатое", "тридцать первое"};
            string[] month = new string[12] { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };

            Console.WriteLine("Введите дату словами, в формате (двадцать первое марта 1999-го года): ");
            var words = Console.ReadLine().ToLower();
            var word = words.Split(" ");
            int dateNum = 0, dateMonth = 0, year = 0;
            string dateNumberStr = "0", dateMonthStr = "0";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[2].Contains("-го"))
                {
                    var wordNum1 = word[2].Split("-го");
                    year = int.Parse(wordNum1[0]);
                }
                else if (word[3].Contains("-го"))
                {
                    var wordNum1 = word[3].Split("-го");
                    year = int.Parse(wordNum1[0]);
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (word[0].Contains(num[i]) || (word[0] + " " + word[1]).Contains(num[i]))
                    dateNum = i + 1;

                if (dateNum < 10)
                    dateNumberStr = "0" + dateNum;
                else
                    dateNumberStr = dateNum.ToString();

            }
            for (int i = 0; i < month.Length; i++)
            {
                if (word[^3].Contains(month[i]))
                    dateMonth = i + 1;
                if (dateMonth < 10)
                    dateMonthStr = "0" + dateMonth;
                else
                    dateMonthStr = dateMonth.ToString();
            }
            Console.WriteLine($"{dateNumberStr}.{dateMonthStr}.{year}");
            Program.goToMenu();
        }
        public static void textWithTranslite()
        {
            Console.WriteLine("Введите строку: ");
            var str = Console.ReadLine();
            str = Translite(str);
            str = BigLetter(str);
            Console.WriteLine(str);
            Program.goToMenu();
        }
        public static string Translite(string text)
        {
            var newText = "";
            var wordsArray = text.Split(" ");

            for (int i = 0; i < wordsArray.Length; i++)
            {
                var isRussianLettersExisted = false;
                for (int j = 0; j < wordsArray[i].Length; j++)
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(wordsArray[i][j].ToString(), @"[a-zA-Z]"))
                    {
                        isRussianLettersExisted = true;
                        newText += wordsArray[i][j];
                    }
                }
                if (isRussianLettersExisted)
                    newText += " ";
            }

            return newText.Trim();
        }
        public static string BigLetter(string text)
        {
            var newText = "";
            var wordsArray = text.Split(" ");
            for (int i = 0; i < wordsArray.Length; i++)
            {
                var isBigLetter = Char.IsUpper(wordsArray[i][0]);
                var isLast = wordsArray[wordsArray.Length - 1];

                if (isBigLetter && i != 0)
                    newText += ",";
                newText += wordsArray[i][0];
                for (int j = 1; j < wordsArray[i].Length; j++)
                {
                    var letter = wordsArray[i][j];
                    newText += Char.ToLower(letter);
                }
                if (isBigLetter && !(wordsArray[i] == isLast))
                    newText += ", ";
                else
                    newText += " ";

            }
            newText = newText.Replace(", ,", ", ");
            return newText;
        }

    }
}
