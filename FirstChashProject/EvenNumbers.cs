namespace FirstChashProject;

public class EvenNumbers
{
    
    public EvenNumbers()
    {
        Console.WriteLine("Even Numbers from 5000 to 2000");
        
        for (int j = 5000; j >= 2000; j--)
        {
            if (j % 2 == 0)
            {
                Console.Write(j + " ");
            }
        }
    }
}