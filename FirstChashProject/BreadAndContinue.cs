namespace FirstChashProject;

public class BreadAndContinue
{
    //Jump statements...............
    public void BandC()
    {
        
        //Example of C# continue in loop..............
        for (int i = 0; i <= 10; i+=2)
        {
            if (i == 4)
            {
                continue;
            }

            Console.WriteLine(i);
        }
        // Example of break statement in C#.......
        
        for (int j = 0; j < 10; j++)
        {
            if (j == 4)
            {
                Console.Write(j);
            }

            break;
        }
        

    }
}