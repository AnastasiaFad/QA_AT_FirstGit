using System;
using System.Collections.Generic;
using System.Text;

namespace hw5_registration
{
    class EditUserData
    {
        public static void SearchNameForEdit(Dictionary<string, string> persons)
        {
            Console.WriteLine(" Users names list: \n");
            int i = 1;
            foreach (KeyValuePair<string, string> keyValue in persons)
            {
                Console.WriteLine($"{i++}. Name: {keyValue.Key} | Password: {keyValue.Value}");
            }
            changes(persons);
        }

        static void editName(Dictionary<string, string> persons)
        {
            Console.Write("\n Press the name user you want to edit: ");
            var oldName = Console.ReadLine();
            Console.Write(" New name: ");
            var newName = Console.ReadLine();

            if (persons.ContainsKey(oldName))
            {
                var savePass = persons[oldName];//ощибка, если вместо имени ввест  паролль  при перемене имени 

                persons.Remove(oldName);
                persons.Add(newName, savePass);
            }
            else
            {
                Console.WriteLine(" Имени не существует в списке");
                editName(persons);
            }

            Start5.StartAdmin(persons);
            Console.Clear();
        }
        static void editPass(Dictionary<string, string> persons)
        {
            Console.Write("\n Press the name user you want to password edit: ");
            var oldName = Console.ReadLine();

            Console.Write(" New password: ");
            var newPassword = Console.ReadLine();
            persons[oldName] = newPassword;

            Start5.StartAdmin(persons);
            Console.Clear();
        }
        static void deleteUser(Dictionary<string, string> persons)
        {
            Console.Write("\n Press the name user you want to delete: ");
            var oldNameUser = Console.ReadLine();

            persons.Remove(oldNameUser);
            Start5.StartAdmin(persons);
            Console.Clear();
        }

        static void changes(Dictionary<string, string> persons)
        {
            Console.WriteLine("\n What do you want to change? \n" +
                " Edit name -> 1\n Edit password -> 2\n Delete User -> 3\n Come Back -> 4\n");

            var num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    editName(persons);
                    break;
                case 2:
                    editPass(persons);
                    break;
                case 3:
                    deleteUser(persons);
                    break;
                case 4:
                    Console.Clear();
                    Start5.Menu1(persons);
                    break;
                default:
                    SearchNameForEdit(persons);
                    break;
            }
        }

    }
}
