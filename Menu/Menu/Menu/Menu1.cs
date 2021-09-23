using System;
using static System.Console;
namespace Menu
{
    class Menu1
    {
        public static string Menu2_1 = (" 1. Написать программу, которая спрашивает какая погода на улице.\n" 
            + " 2. Программа запрашивает год (4-х значное число) и выводит к какому веку относится этот год.\n" + 
            " 3. Программа запрашивает 3 числа и выводит наибольший из них.\n" + 
            " 4. Получить название дня недели исходя из введенной даты (11.12.2012)\n" + 
            " 5. Программа запрашивает 2 числа. Выводит на экран их частное.\n" + 
            " 6. Магазин делает скидку от основной цены 50$, если стоимость покупки больше 500$, и 100$, если стоимость покупки больше 1000$.\n" + 
            " 7*. Программа запрашивает значение, после его ввода, она выводит результат, какой предполагаемый тип данных был введен\n" + 
            " 8*. Написать программу, которая будет спрашивать имя и возраст двух человек, после чего спросит, человек с каким именем старше?\n" +
            " 9*. Oрел или решка\n" +
            " 10. Вернуться назад\n");
        public static void StartMenu1()
        {
            WriteLine(" Какой номер решения вывести на экран? \n");
            WriteLine("\n" + Menu2_1);
            int todo2_1 = int.Parse(ReadLine());
            Clear();
            switch (todo2_1)
            {
                case 1:
                    Console.Write("Пожалуйста, введите какая погода на улице? ");
                    int temperature = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(HW1_1Week.HotOrCold(temperature));
                    Program.goToMenu();
                    break;
                case 2:
                    Console.Write("Пожалуйста, введите год: ");
                    int date = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(HW1_1Week.TheCentury(date)); 
                    Program.goToMenu();
                    break;
                case 3:
                    Console.Write("Пожалуйста, введите 3 числа: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    HW1_1Week._3Numbers(number1, number2, number3);
                    Program.goToMenu();
                    break;
                case 4:
                    Console.WriteLine("Пожалуйста, введите день.месяц.год : ");
                    string date1 = Console.ReadLine();
                    Console.WriteLine(HW1_1Week.newDayOfTheWeek(date1)); 
                    Program.goToMenu();
                    break;
                case 5:
                    Console.Write("Пожалуйста, введите делитель: ");
                    double numb1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Пожалуйста, введите делимое: ");
                    double numb2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(HW1_1Week.quotientOfNumber(numb1, numb2)); 
                    Program.goToMenu();
                    break;
                case 6:
                    Console.Write("Пожалуйста, введите стоимость покупки: ");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(HW1_1Week.salesOfBuy(price)); 
                    Program.goToMenu();
                    break;
                case 7:
                    Console.WriteLine("Введите, пожалуйста значение, тип данных которого необходимо выяснить...");
                    string str = Console.ReadLine();
                    Console.WriteLine(HW1_1Week.TypeOfData(str)); 
                    Program.goToMenu();
                    break;
                case 8:
                    Console.WriteLine("Сейчас нужно будет ввести имена, а затем возраст: ");
                    Console.Write("Пожалуйста, введите 1-е имя : ");
                    string name1 = (Console.ReadLine());
                    Console.Write($"Пожалуйста, введите возраст {name1}: ");
                    int age1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Пожалуйста, введите 2-е имя : ");
                    string name2 = (Console.ReadLine());
                    Console.Write($"Пожалуйста, введите возраст {name2}: ");
                    int age2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Человек с каким именем старше? ");
                    string newName = (Console.ReadLine());
                    Console.WriteLine(HW1_1Week.howOldAreYou(name1, age1, name2, age2, newName)); 
                    Program.goToMenu();
                    break;
                case 9:
                    bool tOrF = true;
                    while (tOrF)
                    {
                        Console.Write("Пожалуйста, введите значение ОРЕЛ или РЕШКА : ");
                        string value = (Console.ReadLine()).ToLower();
                        Random random = new Random();
                        int numRND = random.Next(0, 1);
                        Console.WriteLine(HW1_1Week.crossOrPile(value, numRND)); 
                        Console.WriteLine("Желаете продолжить игру? ");
                        string massage = (Console.ReadLine()).ToLower();
                        if (massage == "да")
                            tOrF = true;
                        else
                            tOrF = false;
                    }
                    Program.goToMenu();
                    break;
                case 10:
                    Program.Start();
                    break;
            }
        }
    }
}
