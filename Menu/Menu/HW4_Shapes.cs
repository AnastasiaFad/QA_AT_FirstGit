using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Menu
{
    class HW4_Shapes
    {        
        public static void PrintShapes()
        {
            WriteLine("квадрат \n");
            PrintSquare(5);
            WriteLine("\n прямоугольный треугольник \n");
            PrintTriangleRectangle(10);
            WriteLine("\n перевернутый прямоугольный треугольник \n");
            PrintReversTriangleRectangle(10);
            WriteLine("\n равносторонний треугольник \n");
            PrintEquilateralTriangle1(10);
            WriteLine("\n перевернутый равносторонний  треугольник \n");
            PrintReverseEquilateralTriangle1(10);
            WriteLine("\n часы \n");
            PrintHourglass(10);
            Program.goToMenu();
        }
        static void PrintSquare(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
        static void PrintTriangleRectangle(int a)
        {
            for (int i = a; i >= 0; i--)
            {
                for (int j = i; j <= a; j++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
        static void PrintReversTriangleRectangle(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = i; j < a; j++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
        static void PrintEquilateralTriangle1(int a)
        {
            for (int i = 1; i <= a; ++i)
            {
                for (int j = a; j > i; --j)
                    Console.Write("  ");

                for (int j = 1; j < 2 * i; ++j)
                    Console.Write("0 ");

                Console.WriteLine();
            }
        }
        static void PrintEquilateralTriangle2(int a)
        {
            for (int i = 2; i <= a; ++i)
            {
                for (int j = a; j > i; --j)
                    Console.Write("  ");

                for (int j = 1; j < 2 * i; ++j)
                    Console.Write("0 ");

                Console.WriteLine();
            }
        }
        public static void PrintReverseEquilateralTriangle1(int a)
        {
            for (int i = a; i >= 1; --i)
            { 
                for (int j = a; j > i; --j)
                    Console.Write("  ");

                for (int j = 1; j < i * 2; ++j)
                    Console.Write("0 ");

                Console.WriteLine();
            }
        }
        static void PrintHourglass(int a)
        {
            PrintReverseEquilateralTriangle1(a);
            PrintEquilateralTriangle2(a);
        }
    }
}
