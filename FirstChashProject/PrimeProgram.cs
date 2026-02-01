class PrimeProgram
{
   
    public PrimeProgram()
    {
        int num;
            bool Prime = true;
            Console.WriteLine("Enter any Number");
            num = int.Parse(Console.ReadLine());
            if (num <= 1)
            {
                Prime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Prime = false;
                    }
                }
            }

            if (Prime == true)
            {
                Console.Write($"This is prime No :=>{num} \n");
            }
            else
            {
                Console.Write($"this is Not a prime No:=> {num} \n");
            }
    } 
    }
