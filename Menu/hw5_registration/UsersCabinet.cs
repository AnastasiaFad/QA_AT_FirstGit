using System;
using System.Collections.Generic;
using System.Text;

namespace hw5_registration
{
    class UsersCabinet
    {
        public static void cabinet(Dictionary<string, string> persons)
        {
            Console.WriteLine("\n  You are in the office \n  Congratulations!!!\n\n");
            link:
            Console.WriteLine(" You can choose the next action: \n Log out of account -> 1\n Close all -> 2");
            var nextStep = int.Parse(Console.ReadLine());
            switch (nextStep)
            {
                case 1:
                    Start5.Menu1(persons);
                    break;
                case 2: break;
                default: goto link;
            }
            Console.Clear();
        }
    }
}
