using System;

namespace PS2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix Operations");

            int rows = 2;
            int columns = 2;

            Matrix<double> matrixOperations = new Matrix<double>();

            double[,] matrix1 = matrixOperations.GetMatrixInput("Matrix 1", rows, columns);
            double[,] matrix2 = matrixOperations.GetMatrixInput("Matrix 2", rows, columns);

            Console.WriteLine("Matrix 1 : ");
            matrixOperations.DisplayMatrix(matrix1);

            Console.WriteLine("\n");

            Console.WriteLine("Matrix 2 : ");
            matrixOperations.DisplayMatrix(matrix2);

            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("3. Division");

            int c = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case 1:
                    double[,] addition = Operation<double>.AdditionOfMatrixs(matrix1, matrix2);
                    Console.WriteLine("Addition of matrix is : ");
                    matrixOperations.DisplayMatrix(addition);
                    break;

                case 2:
                    double[,] subtraction = Operation<double>.SubtractionOfMatrix(matrix1, matrix2);
                    Console.WriteLine("Subtraction of matrix : ");
                    matrixOperations.DisplayMatrix(subtraction);
                    break;

                case 3:
                    double[,] multiplication = Operation<double>.MultiplicationOfMatrix(matrix1, matrix2);
                    Console.WriteLine("Multiplication Of Matrix : ");
                    matrixOperations.DisplayMatrix(multiplication);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
