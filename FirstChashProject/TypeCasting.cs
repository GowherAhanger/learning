namespace FirstChashProject;

public class TypeCasting
{
     public void display()
    {
        //implecit typeCasting...............
        Console.WriteLine("before  implecit typeCasting ");
        int num = 12;
        
        double num1 = num;
        Console.WriteLine("After casting num1 to double ");
        Console.WriteLine(num1);
    }

    public void print()
    {
        byte a=10;
        short b=20;
        int c=30;
        long d=4000;
        float e=54.5f;
        double f=234;
        decimal g = 2345;
        Console.WriteLine($"The numbers are {a}, {b}, {c}, {d}, {e}, {f}, {g}");
        Console.WriteLine($"After casting integer and float:\n {c + f} ");
        Console.WriteLine($"After casting byte and short:\n {a + b} ");
        Console.WriteLine($"After casting long and float:\n {d + e} ");
        Console.WriteLine($"After  explict casting decimal  and double:\n {g+(decimal)f} ");
    }
}