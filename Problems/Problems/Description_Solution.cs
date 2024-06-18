using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Description_Solution
    {

        // Problem input
        //{9, 4}
        //{6, 3}
        //{5, 8}

        //Output
        // # 9 4 6 3 5 8
        // 9 0 1 1 0 0 0
        // 4 1 0 0 1 0 0
        // 6 1 0 0 1 1 0
        // 3 0 1 1 0 0 1
        // 5 0 0 1 0 0 1
        // 8 0 0 0 1 1 0


        public void AdjacentMatrix()
        {
            int[,] grid =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
            };

            int rowSize = grid.GetLength(0);
            int columnSize = grid.GetLength(1);
            int currentRow = 0;
            int[] column_rowName= new int[rowSize * columnSize];
            int k = 0;


            int[,] matrix = new int[rowSize * columnSize, rowSize * columnSize];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {

                    column_rowName[k++] = grid[i,j]; // set Column and Row Name
                    SetValues(matrix, grid, i-1, j, currentRow); //Top= grid[i-1,j]
                    SetValues(matrix, grid, i+1, j, currentRow); //Down = grid[i+1,j]
                    SetValues(matrix, grid, i, j-1, currentRow); //Left = grid[i,j-1]
                    SetValues(matrix, grid, i, j+1, currentRow); //Right = grid[i,j+1]
                    currentRow++;
                }
            }

            PrintMatrix(column_rowName, matrix);
            
        }

        public void SetValues(int[,] matrix, int[,] grid, int i, int j, int currentRow)
        {
            if (i < 0 || i > grid.GetLength(0)-1) return;
            if (j < 0 || j > grid.GetLength(1)-1) return;


            matrix[currentRow, i * grid.GetLength(1) + j] = 1;

        }

        public void PrintMatrix(int[] column_rowName, int[, ] matrix)
        {
            Console.Write("# ");
            for (int i = 0; i < column_rowName.Length; i++)
            {
                Console.Write(column_rowName[i] + " ");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("\n" + column_rowName[i] + " ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }
    }

}
