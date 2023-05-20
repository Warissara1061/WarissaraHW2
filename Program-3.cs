using System;

namespace HW2{
class Program
{
    static void Main()
    {
        int[,] matrix = null;
        char operation;

        while (true)
        {
            Console.Write("Enter operation (+/-) or any other character to exit: ");
            operation = char.Parse(Console.ReadLine());

            if (operation == '+' || operation == '-')
            {
                Console.Write("Enter matrix size: ");
                int size = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter matrix elements:");

                matrix = new int[size, size];

                for (int i = 0; i < size; i++)
                {
                    string[] elements = Console.ReadLine().Split(' ');

                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = int.Parse(elements[j]);
                    }
                }

                int result = CalculateMatrixOperation(matrix, operation);

                Console.WriteLine("Result: " + result);
            }
            else
            {
                break;
            }
        }
    }

    static int CalculateMatrixOperation(int[,] matrix, char operation)
    {
        int result = 0;
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (operation == '+')
                {
                    result += matrix[i, j];
                }
                else if (operation == '-')
                {
                    result -= matrix[i, j];
                }
            }
        }

        return result;
    }
}
}
