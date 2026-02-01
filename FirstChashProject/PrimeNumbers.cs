using System.Runtime.InteropServices.JavaScript;

class PrimeNumbers
{
     public PrimeNumbers()
     {
         int i, j, Number, sum=0;
      
        Console.WriteLine("Enter any to get primeNumbers from 2 to N ");
          Number=int.Parse(Console.ReadLine());
         for ( i = 2; i < Number; i++)
         {
             bool  Prime = true;
             for ( j = 2; j < Number; j++)
             {
                 if (Number / i == 0)
                 {
                     Prime = false;
                     break;
                 }
             }

             if (Prime)
             {
                 Console.Write(i + " ");
                 sum = sum + i;
             }
         }
         Console.WriteLine();
         Console.WriteLine($"Sum of prime numbers from 2 to {Number}:==> {sum}");
    }
}