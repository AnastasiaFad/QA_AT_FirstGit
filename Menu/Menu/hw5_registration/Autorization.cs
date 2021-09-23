using System;
using System.Collections.Generic;
using System.Text;

namespace hw5_registration
{
    class Autorization
    {
        public static void loginUser(Dictionary<string, string> persons)
        {
            var name = ValidateLoginName(persons);
            if (name == "NoName")
                tryingToEnterTheCorrectName(persons);
            else
            {
                link:
                var password = ValidatePasswordName(persons, name);
                if (password == "NoPassword")
                    goto link;
                else
                    UsersCabinet.cabinet(persons);
            }
        }
        static string ValidatePasswordName(Dictionary<string, string> persons, string name)
        {

            Console.Write(" Enter your password: ");
            var passrord = Console.ReadLine();
            foreach (KeyValuePair<string, string> keyValue in persons)
            {
                if (keyValue.Key == name && keyValue.Value == passrord)
                    return passrord;
            }

            return "NoPassword";
        }
        static string ValidateLoginName(Dictionary<string, string> persons)
        {
            Console.Write(" Enter your name: ");
            var name = Console.ReadLine();

            foreach (string p in persons.Keys)
            {
                if (name == p)
                    return name;
            }
            return "NoName";
        }
        static void tryingToEnterTheCorrectName(Dictionary<string, string> persons)
        {
            Console.WriteLine(" There isn't this name in the list... " + "\n Try again -> 1 \n Register -> 2");
            int go = int.Parse(Console.ReadLine());
            switch (go)
            {
                case 1:
                    Console.Clear();
                    loginUser(persons);
                    break;
                case 2:
                    Console.Clear();
                    Registration.AddNewUserToTheDictionary(persons);
                    break;
                default:
                    Console.Clear();
                    tryingToEnterTheCorrectName(persons);
                    break;
            }
        }
    }
}
