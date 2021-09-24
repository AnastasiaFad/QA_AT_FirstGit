using System;
using System.Collections.Generic;
using System.Text;

namespace hw5_registration
{
    class Registration
    {
        public static void AddNewUserToTheDictionary(Dictionary<string, string> persons)
        {
            string name;
            string password = "";
            bool valid = ValidateName(out name);
            link:
            if (valid)
            {
                Console.Write(" Enter your password: ");
                password = Console.ReadLine();
            }
            else
            {
                valid = ValidateName(out name);
                goto link;
            }

            bool result = uniqueName(persons, ref name);
            if (result)
            {
                persons.Add(name, password); // нельзя 2 одинаковых имени
                UsersCabinet.cabinet(persons);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" Name already exists...\n try again\n");
                AddNewUserToTheDictionary(persons);
            }

        }
        static bool uniqueName(Dictionary<string, string> persons, ref string name)
        {
            foreach (KeyValuePair<string, string> keyValue in persons)
            {
                if (persons.ContainsKey(name))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidateName(out string name)
        {
            Console.Write("\n Enter your name: ");
            name = Console.ReadLine().ToLower();
            var bag = "_=+)`[]{}:;''|/.,<>*&(!@#$%?№\"\\";

            bool found = true;
            if (name.Length > 0)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i].Equals(" ") || ((name[i] >= 'а') && (name[i] <= 'я')) || ((name[i] >= 'А') && (name[i] <= 'Я')))
                    {
                        found = false;
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < bag.Length; j++)
                        {
                            if (name[i].Equals(bag[j])) //_
                            {
                                found = false;
                                break;
                            }
                        }
                    }
                    if (!found)
                        break;
                }
            }
            return found;
        }
    }
}
