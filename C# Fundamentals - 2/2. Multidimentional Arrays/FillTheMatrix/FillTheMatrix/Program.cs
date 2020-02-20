﻿using System;

class FillTheMatrix
{
    static void Main()
    {
        // Read the matrix dimensions
        int rows = int.Parse(Console.ReadLine());
        int cols = rows;
        // Input character
        char character = char.Parse(Console.ReadLine());

        // Create (Allocate) the matrix
        int[,] matrix = new int[rows, cols];

        switch (character)
        {
            case 'a': VerticalFillMatrixA(matrix); break;
            case 'b': SnakeFillMatrixB(matrix); break;
            case 'c': DiagonalFillMatrixC(matrix); break;
            case 'd': SpiralFillMatrixD(matrix); break;
        }

        PrintingMatrix(matrix);
    }

    // A => Vertical Set (Fill) the matrix elements
    private static void VerticalFillMatrixA(int[,] matrix)
    {
        for (int col = 0, index = 1; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++, index++)
            {
                matrix[row, col] = index;
            }
        }
    }

    // B => Snake Set (Fill) the matrix elements
    private static void SnakeFillMatrixB(int[,] matrix)
    {
        bool isDirDown = true;

        for (int col = 0, row = 0, index = 1; col < matrix.GetLength(1); col++)
        {
            while (row >= 0 && row < matrix.GetLength(0))
            {
                matrix[row, col] = index++;
                row += isDirDown ? +1 : -1; // Change 'row' value
            }

            // Change direction and change 'row' value
            isDirDown = !isDirDown;
            row += isDirDown ? +1 : -1;
        }
    }

    // C => Diagonal Set (Fill) the matrix elements
    private static void DiagonalFillMatrixC(int[,] matrix)
    {
        for (int row = matrix.GetLength(0) - 1, index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); row--)
        {
            for (int currCol = (row >= 0 ? 0 : -row), currRow = (row >= 0 ? row : 0);
            currCol < (matrix.GetLength(1) - (row >= 0 ? row : 0));)
            {
                matrix[currRow++, currCol++] = index++;
            }
        }
    }

    // D => Spiral Set (Fill) the matrix elements - First Way
    private static void SpiralFillMatrixD(int[,] matrix)
    {
        string direction = "down";
        int row = -1, col = 0;

        for (int index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); index++)
        {
            if (direction == "down")
            {
                if (matrix[++row, col] == 0)
                {
                    matrix[row, col] = index;
                }

                if (!InRangeAndUnfilled(matrix, row + 1, col)) // if is out of range or filled => change the direction
                {
                    direction = "right";
                }
            }
            else if (direction == "right")
            {
                if (matrix[row, ++col] == 0)
                {
                    matrix[row, col] = index;
                }

                if (!InRangeAndUnfilled(matrix, row, col + 1)) // if is out of range or filled
                {
                    direction = "up"; // change the direction
                }
            }
            else if (direction == "up")
            {
                if (matrix[--row, col] == 0)
                {
                    matrix[row, col] = index;
                }

                if (!InRangeAndUnfilled(matrix, row - 1, col)) // if is out of range or filled
                {
                    direction = "left"; // change the direction
                }
            }
            else if (direction == "left")
            {
                if (matrix[row, --col] == 0)
                {
                    matrix[row, col] = index;
                }

                if (!InRangeAndUnfilled(matrix, row, col - 1)) // if is out of range or filled
                {
                    direction = "down"; // change the direction
                }
            }

        }
    }

    static bool InRangeAndUnfilled(int[,] matrix, int row, int col) // needed for Spiral Filling the matrix D
    {
        return row >= 0 && row < matrix.GetLongLength(0) // in the range of rows
            && col >= 0 && col < matrix.GetLongLength(1) // in the range of cols
            && matrix[row, col] == 0; // current element is unfilled
    }

    // Print the matrix on the console
    private static void PrintingMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)       // rows = matrix.GetLength(0)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)   // cols = matrix.GetLength(1)
            {
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0}", matrix[row, col]);
                }
            }
            Console.WriteLine();
        }
    }

}