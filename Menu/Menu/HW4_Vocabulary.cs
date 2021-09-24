using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Menu
{
    public class HW4_Vocabulary
    {
        public static void CallVocabulary()
        {
            string[] array = { "Anna", "Katya", "Nastya", "Petya", "Max", "Petya", "Федя" };
            userInteraction(array);
            Program.goToMenu();
        }
        static void userInteraction(string[] array)
        {
            WriteLine("\n Выберите действие:\n \n Если хочешь добавить имя, введи: 1" +
                "\n Если хочешь добавить имя, если хочешь удалить имя, введи: 2" +
                "\n Если хочешь вывести весь список имен: 3" +
                "\n Если хочешь выйти: 4 \n");
            int act = int.Parse(ReadLine());
            switch (act)
            {
                case 1:
                    WriteLine("Введите, пожалуйста, имена, разделяя запятой ',': ");
                    string namesText = ReadLine();
                    array = Start(ref array, namesText);
                    break;
                case 2:
                    WriteLine("Введите имя, которое хотите удалить: ");
                    string nameDelete = ReadLine();
                    array = DeleteFromArray(ref array, nameDelete);
                    break;
                case 3:
                    PrintNames(ref array);
                    break;
                case 4:
                    return;
            }
            userInteraction(array);
        }
        public static string[] Start(ref string[] array, string namesText)
        {
            string[] names = namesText.Split(",");
            string[] newArr = AddToArray(ref array, names);
            return newArr;
        }

        public static string[] AddToArray(ref string[] array, string[] Newarray)
        {
            string[] newArray = new string[array.Length + Newarray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] += array[i].Trim();
            }
            for (int i = array.Length; i < newArray.Length;)
            {
                for (int j = 0; j < Newarray.Length; j++)
                {
                    newArray[i] += Newarray[j].Trim();
                    i++;
                }
            }
            return newArray;
        }

        static void PrintNames(ref string[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Write(array[i] + " ");
            WriteLine();
        }

        public static string[] DeleteFromArray(ref string[] array, string nameDelete)
        {
            int j = 0;
            int count = 0;
            int lenght = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains(nameDelete))
                {
                    count++;
                    continue;
                }
                else
                {
                    if (i == array.Length && count == 0)
                        return array;
                    else
                        lenght++;
                }
            }
            string[] newArray = new string[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains(nameDelete)) 
                {
                    count++;
                    continue; 
                }
                else
                {
                    if (i == newArray.Length && count == 0)
                        return array;
                    else
                    {
                        newArray[j] = array[i].Trim();
                        j++;
                    } 
                }

            }
            return newArray;
        }
    }
}
