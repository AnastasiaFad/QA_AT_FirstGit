using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Maze_Start
    {
        const int Height = 10;
        const int Width = 10;

        public static void MainStart()
        {
            Maze_Game currentGame = new Maze_Game(); 
            currentGame.Start();
            Program.goToMenu();
        }
        public static void PaintMaze()
        {
            Maze_Draw maze = new Maze_Draw(); 
            maze.GenerateMaze(Width, Height);
            maze.PrintMaze();
            Program.goToMenu();
        }


    }
}
