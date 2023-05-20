using System;

namespace Homework2{
    class Program{

  public static void Main (string[] args) {
   
    string[] inputs = Console.ReadLine().Split(' ');
    int N = int.Parse(inputs[0]);
    int K = int.Parse(inputs[1]);

    
    inputs = Console.ReadLine().Split(' ');
    int[] population = new int[N];
    for (int i = 0; i < N; i++) {
      population[i] = int.Parse(inputs[i]);
    }

  
    int maxCustomers = 0;

    
    for (int i = 0; i <= N - K; i++) {
     
      int customers = 0;
      for (int j = i; j < i + K; j++) {
        customers += population[j];
      }

     
      if (customers > maxCustomers) {
        maxCustomers = customers;
      }
    }

    
    Console.WriteLine(maxCustomers);
  }
}

    }


