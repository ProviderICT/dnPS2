using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2Q1
{
     class Matrix<T>
    {
        public T[,] GetMatrixInput(string matrixName, int rows, int columns)
        {
            Console.WriteLine($"Enter values for {matrixName}:");

            T[,] matrix = new T[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter value for element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                }
            }

            return matrix;
        }


        public void DisplayMatrix(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
