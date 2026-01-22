namespace FirstChashProject;

public class OddNumbers
{
   public OddNumbers()
    {
        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}