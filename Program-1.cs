using System;

  namespace Homework2{
    class Program{

    static void Main(string[] arg){

      Console.Write("Please Input Number: ");
      int row = Convert.ToInt32(Console.ReadLine());

         if (row < 0){
              Console.WriteLine("Invalid Pascal's triangle row number");
            } 
      PrintPascalTriangle(row);
    }
    static void PrintPascalTriangle(int row)
    {
        for (int x = 0; x < row; x++)
        {
            int number = 1;
            Console.Write(new string(' ', (row - x) * 2));

            for (int y = 0; y <= x; y++)
            {
                Console.Write($"{number,4} ");
                number = number * (x - y) / (y + 1);
            }

            Console.WriteLine();
        }
    }
}
}