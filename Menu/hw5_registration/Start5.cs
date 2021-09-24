using System;
using System.Collections.Generic;

namespace hw5_registration
{
    public class Start5
    {
        static void Main(string[] args)
        {
        }
        public static void Menu()
        {
            Dictionary<string, string> persons = new Dictionary<string, string>();
            Menu1(persons);

        }

        public static void Menu1(Dictionary<string, string> persons)
        {
            Console.Clear();
            Console.WriteLine(" If you are a user press -> 1 " + "\n If you are a admin press -> 2 \n Close all -> 3");
            int status = int.Parse(Console.ReadLine());

            switch (status)
            {
                case 1:
                    Console.Clear();
                    StartUser(persons);
                    break;
                case 2:
                    Console.Clear();
                    Admin.loginAdmin(persons);
                    break;
                case 3:
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Menu1(persons);
                    break;
            }

        }

        static void StartUser(Dictionary<string, string> persons)
        {
            Console.WriteLine(" Register -> 1");
            Console.WriteLine(" Authorization -> 2");
            int startUser = int.Parse(Console.ReadLine());

            switch (startUser)
            {
                case 1:
                    Console.Clear();
                    Registration.AddNewUserToTheDictionary(persons);
                    break;
                case 2:
                    Console.Clear();
                    Autorization.loginUser(persons);
                    break;
                default:
                    Console.Clear();
                    StartUser(persons);
                    break;
            }
        }
        public static void StartAdmin(Dictionary<string, string> persons)
        {
            Console.WriteLine(" Edit user data -> 1\n Come back -> 2");
            int startAdmin = int.Parse(Console.ReadLine());

            switch (startAdmin)
            {
                case 1:
                    Console.Clear();
                    EditUserData.SearchNameForEdit(persons);
                    break;
                case 2:
                    Console.Clear();
                    Menu1(persons);
                    break;
                default:
                    Console.Clear();
                    StartAdmin(persons);
                    break;
            }
        }
    }
}
