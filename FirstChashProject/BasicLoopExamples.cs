namespace FirstChashProject;

public class BasicLoopExamples
{
    
     public BasicLoopExamples()
    {
        // for loop
        int num = 20;
        Console.WriteLine($"incrementing  num using for loop , {num}");
        for (int i = 1; i < num; i++)
        {
            Console.WriteLine(i);
        }
        //Wile loop...............
        int num2 = 0;
        while (num2 < 10)
        {
            num2=num2+2;
            Console.WriteLine(num2);
        }
        //do while ............
        int l = 1;
        do
        {
            Console.WriteLine($"Value of num 2: => {l}");
            l += 3;
        } while (l < 10);
        //For eachLoop  is in collection we can use it in arrays ................
        //will complete working when we work on arrays..........
       
    }
       
}