using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class HW1_Loops
    {
        public static void SumEvenNum()
        {
            int sum = 0;
            int count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                }
            }
            Console.WriteLine("Sum of even numbers from 1 to 99 = " + sum);
            Console.WriteLine("The number of even numbers from 1 to 99 = " + count);
            Program.goToMenu();
        }
        public static bool IsSimpleNumber(int num)
        {
            bool simple = true;
            if (num < 1 || num % 1 != 0)            
                simple = false;
            else
            {
                for (var i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        simple = false;
                }
            }
            Program.goToMenu();
            return simple;
        }
        public static int GetFindTheRoot(int num)
        {
            int result = 404;
            for (int i = 0; i <= num; i++)
            {
                if (i * i == num)
                    result = i; 
                else if (i * i > num)
                    result = i - 1;
            }
            Program.goToMenu();
            return result;
        }
        public static int GetFindTheRootBinary(int numb)
        {
            int min = 0;
            int max = numb / 2;
            int mid = max;
            for (int i = 0; ; i++)
            {
                if (mid * mid == numb) break;
                if (mid * mid > numb) max = mid;
                if (mid * mid < numb) min = mid;

                mid = (min + max) / 2;
                if (max - min == 1)
                {
                    mid = max;  // округлить к большему
                    //mid = min; // округлить к меньшему
                    break;
                }
            }
            Program.goToMenu();
            return mid;
        }

        public static int SearchFactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Program.goToMenu();
            return factorial;
        }
        public static int GetSumOfDigits(int num)
        {
            int count = 0;
            while (num != 0)
            {
                count += num % 10;
                num /= 10;
            }
            Program.goToMenu();
            return count;
        }
        public static void MirrorNumber(int number)
        {
            Console.WriteLine("Наше изначальное число:" + number);
            Console.Write("Перевернутое число:");
            int count;
            while (number % 10 != 0)
            {
                count = number % 10;
                Console.Write(count);
                number /= 10;
            }
            Console.Write("\n");
            Program.goToMenu();
        }
    }
}
