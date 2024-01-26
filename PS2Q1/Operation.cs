using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2Q1
{
    class Operation<T>
    {
        public static T[,] AdditionOfMatrixs(T[,] matrix1, T[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);

            T[,] result = new T[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dynamic val1 = matrix1[i, j];
                    dynamic val2 = matrix2[i, j];
                    result[i, j] = val1 + val2;
                }
            }

            return result;
        }

        public static T[,] SubtractionOfMatrix(T[,] matrix1, T[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);

            T[,] result = new T[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dynamic val1 = matrix1[i, j];
                    dynamic val2 = matrix2[i, j];
                    result[i, j] = val1 - val2;
                }
            }
            return result;
        }

        public static T[,] MultiplicationOfMatrix(T[,] matrix1, T[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);

            T[,] result = new T[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dynamic val1 = matrix1[i, j];
                    dynamic val2 = matrix2[i, j];
                    result[i, j] = val1 * val2;
                }
            }
            return result;
        }
    }
}
