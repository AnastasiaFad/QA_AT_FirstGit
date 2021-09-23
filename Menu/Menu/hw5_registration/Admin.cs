using System;
using System.Collections.Generic;
using System.Text;

namespace hw5_registration
{
    class Admin
    {
        public const string nameAdmin = "admin";
        public const string passwordAdmin = "000";

        public static void loginAdmin(Dictionary<string, string> persons)
        {
            Console.Write(" Enter your admin name: ");
            var name = Console.ReadLine();

            if (name != nameAdmin)
            {
                Console.WriteLine(" You are not an administrator\n");
                Start5.Menu1(persons);
            }
            else
            {
                link:
                Console.Write(" Enter admin password: ");
                var passrord = Console.ReadLine();
                if (passrord != passwordAdmin)
                {
                    Console.WriteLine("\n Wrong password...\n Try again");
                    goto link;
                }
                else
                    cabinetAdmin(persons);
            }
        }
        public static void cabinetAdmin(Dictionary<string, string> persons)
        {
            Console.WriteLine("\n I am the admin and I am in my office\n");
            Start5.StartAdmin(persons);
        }
    }
}
