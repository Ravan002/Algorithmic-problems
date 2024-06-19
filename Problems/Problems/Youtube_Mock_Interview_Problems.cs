using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Youtube_Mock_Interview_Problems
    {
        // Problem  1
        // input
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




        // Probblem 2

        // Shift Array
        // input 
        //    var arr = new char[,]
        //    {
        //      { '1','0','1','0','1','0','0','0' },
        //      { '1','1','0','0','1','0','1','0' },
        //      { '1','1','0','0','0','1','1','0' },
        //      { '1','1','0','1','0','0','0','0' },
        //      { '1','0','0','0','0','1','0','0' },
        //      { '1','1','1','0','1','0','1','0' },
        //      { '1','1','0','0','1','0','0','0' },
        //      { '1','1','0','0','1','0','0','0' },
        //      { '1','1','1','1','0','0','1','0' }
        //    };


        // output - shift 1 
        // 01010100
        // 01100101
        // 01100011
        // 01101000
        // 01000010
        // 01110101
        // 01100100
        // 01100100
        // 01111001



        public void PrintShiftedArray()
        {
            var arr = new char[,]
            {
                {'1','0','1','0','1','0','0','0' },
                {'1','1','0','0','1','0','1','0' },
                {'1','1','0','0','0','1','1','0' },
                {'1','1','0','1','0','0','0','0' },
                {'1','0','0','0','0','1','0','0' },
                {'1','1','1','0','1','0','1','0' },
                {'1','1','0','0','1','0','0','0' },
                {'1','1','0','0','1','0','0','0' },
                {'1','1','1','1','0','0','1','0' }
            };

            var result = ShiftArray(arr, 1);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for(int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public char[, ] ShiftArray(char[,] input, int shiftAmount)
        {

            shiftAmount %= input.GetLength(1);

            for(int i=0;i<input.GetLength(0); i++)
            {
                for(int k = 0; k < shiftAmount; k++)
                {
                    char lastChar = input[i, input.GetUpperBound(1)];
                    for (int j = input.GetLength(1) - 2; j >= 0; j--)
                    {
                        input[i, j + 1] = input[i, j];
                    }
                    input[i, input.GetLowerBound(1)] = lastChar;
                }
            }

            return input;
        }
    }


}
