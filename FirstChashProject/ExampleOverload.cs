using System.Numerics;

namespace FirstChashProject;
//Method overloading..........................................
public class ExampleOverload
{
    
    public void add()
    {
        Console.WriteLine("adding");
    }

    public int add(int x , int y)
    {
        Console.WriteLine(x+y);
        return 0;
    }

    public int add(int x , float z)
    {
        Console.WriteLine(x - z);
        return 0;
    }

    public void add(int x, int y, int z)
    {
        Console.WriteLine(x + y);
    }
}