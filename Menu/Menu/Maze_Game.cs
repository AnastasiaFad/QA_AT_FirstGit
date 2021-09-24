using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Menu
{
    class Maze_Game
    {
        private Maze_World MyWorld;
        private Maze_Player CurrentPlayer;

        public void Start()
        {
            Title = "Welcome to the Maze";
            CursorVisible = false;

            string[,] myGrid = Maze_Arrays.Arr();
            MyWorld = new Maze_World(myGrid);

            CurrentPlayer = new Maze_Player(0, 0);
            RunGameLoop();
        }

        private void DidplayIntro()
        {
            WriteLine("Добро пожаловать в лабиринт!");
            WriteLine("\nИнструкция");
            WriteLine("> Используйте клавиши со стрелками для перемещения");
            WriteLine("> Цель выглядит так:");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("X");
            ResetColor();
            WriteLine("> Нажмите любую клавишу, чтобы начать");
            ReadKey(true);
        }
        private void DisplayOutro()
        {
            Clear();
            WriteLine("Ты сбежал!");
            WriteLine("Спасибо за игру)");
            WriteLine("Нажмите любую клавишу, чтобы выйти...");
            ReadKey(true);
        }
        private void DrawFrame()
        {
            Clear();
            MyWorld.Draw();
            CurrentPlayer.Draw();
        }
        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y - 1))
                    {
                        CurrentPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {
                        CurrentPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X += 1;
                    }
                    break;
                default:
                    break;
            }

        }
        private void RunGameLoop()
        {
            DidplayIntro();
            while (true)
            {
                //Draw everything.
                DrawFrame();

                //Check for player input from the keyboard  and move the player.
                HandlePlayerInput();

                //Check if the player has reached the exit and end the game  if so.
                string elementAtPlayerPos = MyWorld.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y);
                if (elementAtPlayerPos == "X")
                {
                    break;
                }

                //Give the Console a chance to render.
                System.Threading.Thread.Sleep(3);
            }
            DisplayOutro();
        }

    }
}
