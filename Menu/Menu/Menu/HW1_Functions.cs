using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class HW1_Functions
    {
        public static string DayOfTheWeek(int num)
        {
            string result = "error";
            switch (num)
            {
                case 1: result = "MONDAY"; break;
                case 2: result = "TUESDAY"; break;
                case 3: result = "WEDNESDAY"; break;
                case 4: result = "THURSDAY"; break;
                case 5: result = "FRIDAY"; break;
                case 6: result = "SATURDAY"; break;
                case 7: result = "SUNDAY"; break;
                default: result = "Такого дня недели не существует "; break;
            }
            
            return result;
        }
        public static double Distance(int x1, int x2, int y1, int y2)
        {
            double AC = 0, BC = 0, AB = 0;
            AC = (x2 - x1); 
            BC = (y2 - y1); 
            AB = Math.Sqrt((AC * AC) + (BC * BC));
            
            return AB;
        }
        public static void NumberToString(int num) 
        {
            if (num > 999 || num < 0)
            {
                Console.WriteLine("Число не входит в диапазон...");
            }
            int[] x = new int[4]; 
            int div = 100; 
            int var = num; 
            int rest; 
            for (int i = 0; i < 3; i++)
            {
                rest = (int)(var / div); 
                x[i] = rest; 
                var = var - (rest * div); 
                div = div / 10; 
            }
            switch (x[0])
            {
                case 1: Console.Write("сто "); break;
                case 2: Console.Write("двести "); break;
                case 3: Console.Write("триста "); break;
                case 4: Console.Write("четыреста "); break;
                case 5: Console.Write("пятьсот "); break;
                case 6: Console.Write("шестьсот "); break;
                case 7: Console.Write("семьсот "); break;
                case 8: Console.Write("восемьсот "); break;
                case 9: Console.Write("девятьсот "); break;
                default: break;
            }
            switch (x[1])
            {
                case 1:
                    switch (x[2])
                    {
                        case 0: Console.Write("десять "); break;
                        case 1: Console.Write("одиннадцать "); break;
                        case 2: Console.Write("двенадцать "); break;
                        case 3: Console.Write("тринадцать "); break;
                        case 4: Console.Write("четырнадцать "); break;
                        case 5: Console.Write("пятнадцать "); break;
                        case 6: Console.Write("шестнадцать "); break;
                        case 7: Console.Write("семнадцать "); break;
                        case 8: Console.Write("восемнадцать "); break;
                        case 9: Console.Write("девятнадцать "); break;
                    }
                    x[2] = 0;
                    break;
                case 2: Console.Write("двадцать "); break;
                case 3: Console.Write("тридцать "); break;
                case 4: Console.Write("сорок "); break;
                case 5: Console.Write("пятьдесят "); break;
                case 6: Console.Write("шестьдесят "); break;
                case 7: Console.Write("семьдесят "); break;
                case 8: Console.Write("восемьдесят "); break;
                case 9: Console.Write("девяносто "); break;
                default: break;
            }           
            switch (x[2])
            {
                case 1: Console.Write("один "); break;
                case 2: Console.Write("два "); break;
                case 3: Console.Write("три "); break;
                case 4: Console.Write("четыре "); break;
                case 5: Console.Write("пять "); break;
                case 6: Console.Write("шесть "); break;
                case 7: Console.Write("семь "); break;
                case 8: Console.Write("восемь "); break;
                case 9: Console.Write("девять "); break;
                default: break;
            }
           
        }
        public static string StringToNumber(string num)
        {
            string[] dig1 = new[] { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] dig10 = new[] { "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] dig100 = new[] { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] words = num.Split(" ");
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < dig1.Length; j++)
                {
                    if (words[i].Equals(dig1[j]))
                        result += j;
                }
                for (int j = 0; j < dig10.Length; j++)
                {
                    if (words[i].Equals(dig10[j]))
                        result += j + 2;
                }
                for (int j = 0; j < dig100.Length; j++)
                {
                    if (words[i].Equals(dig100[j]))
                        result += j + 1;

                }
            }
            return result;
        }
    }
}
