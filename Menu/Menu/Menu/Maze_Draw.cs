using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Maze_Draw
    {
        public class Set
        {
            // The cells that are in that set. Ячейки в этом наборе.
            public List<Cell> Cells = new List<Cell>();// List<Cell> куча ячеек
        }
        public class Cell
        {
            public Set Set;                                     // The set the cell is in. (Can be null if the cell has no set, yet.)
            public bool HasRightWall;                           // Has the cell a wall on the right?
            public bool HasBottomWall;                          // Has the cell a wall on the bottom? 
        }

        private int width;                                  // The width of the maze.
        private int height;                                 // The height of the maze.

        private const int MaxBias = 80;
        private const int Bias = 30;

        private List<Set> sets;                             // A list of the sets in the current row.
        private List<Cell> row;                             // The current row. (NOTE: The Eller's only needs to load one row in the memory to generate a maze!)

        private readonly Random random = new Random();        // Used to generate random values.

        private Cell[,] maze;

        private void InitSets()
        {
            foreach (Cell cell in row)
            {
                if (cell.Set == null)
                {
                    Set set = new Set();        // Create a new set...
                    cell.Set = set;             // ...and assign it to the cell

                    set.Cells.Add(cell);        // Add the cell to the set.
                    sets.Add(set);              // Add the set into the list of sets.
                }
            }
        }
        private void WriteRowIntoMaze(int h)
        {
            for (int i = 0; i < row.Count; i++)
            {
                // You need to store a new object into the arrays cell, because otherwise it will only store 
                // the reference to the rows cell and it will be overridden after the next step in the loop
                Cell cell = new Cell
                {
                    HasBottomWall = row[i].HasBottomWall,
                    HasRightWall = row[i].HasRightWall
                };

                maze[i, h] = cell;
            }
        }
        public void GenerateMaze(int width, int height)
        {
            this.width = width;                             // Sets the width of the maze.
            this.height = height;                           // Sets the height of the maze.

            maze = new Cell[width, height];                 // Initalizes an empty two dimensional array to store the maze into it.
            sets = new List<Set>();                         // Initialize new list of sets.
            row = new List<Cell>();                         // Initialize new row.

            // Fill the first row with new empty cells
            for (int i = 0; i < this.width; i++)
            {
                row.Add(new Cell());
            }

            // This is the section where the algorithm finally executes after all the preperations.
            for (int x = 0; x < this.height; x++)
            {

                // Handles the last row which is a special case.
                if (x == this.height - 1)
                {
                    // Every cell that has no set, will have its own unique set.
                    InitSets();

                    // In the last row every cell will have a bottom wall
                    foreach (Cell cell in row)
                    {
                        cell.HasBottomWall = true;
                    }

                    // Create right walls
                    for (int i = 0; i < row.Count - 1; i++)
                    {
                        // Delete all rows that divide different sets
                        if (row[i].Set != row[i + 1].Set)
                        {
                            row[i].HasRightWall = false;
                        }
                        else
                        {
                            row[i].HasRightWall = true;
                        }

                    }

                    // The last cell in a row always has to have a right wall because that's where the border of the maze is.
                    row[row.Count - 1].HasRightWall = true;

                    // Stores the row in the maze.
                    WriteRowIntoMaze(x);

                    // End the loop because the last row has already been done.
                    continue;
                }

                // Every cell that has no set, will have its own unique set.
                InitSets();

                // If there are multiple cells with the same set place a wall between them. 
                // Otherwise you will get "holes" in your maze. Just remove this code-segment and generate some mazes to see it!
                for (int i = 0; i < row.Count - 1; i++)
                {
                    if (row[i].Set == row[i + 1].Set)
                    {
                        row[i].HasRightWall = true;
                    }
                }

                // Create the right walls. 
                CreateRightWalls();

                // Create bottom walls. (NOTE: Each set need at least one cell without a bottom wall.)
                CreateDownWalls();

                // Stores the row in the maze.
                WriteRowIntoMaze(x);

                // Prepare the next row.
                PrepareNextRow();
            }
        }
        private void CreateRightWalls()
        {
            // i is the left cell(lc) and i + 1 is the right cell(rc) => | lc | rc |
            for (int i = 0; i < row.Count - 1; i++)
            {

                // Randomly create a wall.
                if (CreateWall)
                {
                    row[i].HasRightWall = true;
                }
                else if (row[i].Set == row[i + 1].Set)
                {
                    // If the left and the right cell have the same set there needs to be a right wall to not create loops in the maze.
                    row[i].HasRightWall = true;
                }
                else
                {
                    // Merge cells to the same set.
                    row[i + 1].Set.Cells.Remove(row[i + 1]);
                    row[i].Set.Cells.Add(row[i + 1]);
                    row[i + 1].Set = row[i].Set;
                }
            }

            // The last cell in a row always has to have a right wall because that's where the border of the maze is.
            row[row.Count - 1].HasRightWall = true;
        }
        /// <summary>
        /// Returns a random bool and is used to define if a right wall should be created or not.
        /// </summary>
        private bool CreateWall
        {
            get
            {
                int x = random.Next(0, MaxBias + 1);

                if (x > Bias)
                {
                    return true;
                }

                return false;
            }
        }
        private void CreateDownWalls()
        {
            // NOTE: Every set needs to have at least one path downwards.
            foreach (Set set in sets.ToArray())
            {
                // Check if the set is used by any cells. (NOTE: There can be sets without any cells due to merging the sets of different cells.)
                if (set.Cells.Count > 0)
                {
                    // The cellIndices store the information which cells of a set should NOT have bottom walls.
                    List<int> cellIndices = new List<int>();

                    // If a set only has one cell it must not have a bottom wall!
                    if (set.Cells.Count == 1)
                    {
                        cellIndices.Add(0);
                    }
                    else
                    {
                        // Randomly choose how many paths you want to have downwards. (NOTE: Each set needs at least one path downwards!)
                        int downPaths = random.Next(1, set.Cells.Count + 1);

                        // Randomly choose which cells of the set should have the downPaths.
                        for (int i = 0; i < downPaths; i++)
                        {
                            int index;

                            // Make sure that an index won't be added multiple times!
                            do
                            {
                                index = random.Next(0, set.Cells.Count);

                            } while (cellIndices.Contains(index));

                            cellIndices.Add(index);
                        }
                    }

                    // Add bottom walls.
                    for (int k = 0; k < set.Cells.Count; k++)
                    {
                        if (!cellIndices.Contains(k))
                        {
                            set.Cells[k].HasBottomWall = true;
                        }
                        else
                        {
                            set.Cells[k].HasBottomWall = false;
                        }
                    }
                }
                else
                {
                    // Remove empty sets to clean up a little bit.
                    sets.Remove(set);
                }
            }
        }

        private void PrepareNextRow()
        {
            foreach (Cell cell in row)
            {
                // Remove all right walls for the next row.
                cell.HasRightWall = false;

                // If a cell in the previous row had a down wall the cell beneathe must not have a down wall nor a set. 
                if (cell.HasBottomWall)
                {
                    cell.Set.Cells.Remove(cell);
                    cell.Set = null;
                    cell.HasBottomWall = false;
                }
            }
        }

        public void PrintMaze()
        {
            Console.Write("_");

            for (int i = 0; i < width; i++)
            {
                Console.Write("___");
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                Console.Write("|");

                for (int j = 0; j < width; j++)
                {
                    if (maze[j, i].HasRightWall && maze[j, i].HasBottomWall)
                    {
                        Console.Write($"__|");
                    }
                    else if (maze[j, i].HasRightWall && !maze[j, i].HasBottomWall)
                    {
                        Console.Write($"  |");
                    }
                    else if (maze[j, i].HasBottomWall && !maze[j, i].HasRightWall)
                    {
                        Console.Write($"___");
                    }
                    else
                    {
                        Console.Write($"   ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}

