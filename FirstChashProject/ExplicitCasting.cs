namespace FirstChashProject;

public class ExplicitCasting
{
    public void ExpCasting()
    {
        Console.WriteLine("ExplicitCasting");
        //Integer explicit casting..........
        Console.Write("Enter an integer: ");
        int intVal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You entered integer: {intVal}\n");
        //Double explicit Casting.........
        Console.Write("Enter an Double: ");
        double doubleVal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"You entered Double: {doubleVal}\n");
        //Float Casting...........
        Console.Write("Enter a float: ");
        float floatVal = float.Parse(Console.ReadLine());
        Console.WriteLine($"You entered float: {floatVal}\n");
        //Results............
        Console.WriteLine("--- Casting Results ---\n");
        Console.WriteLine($"double to int: {(int)doubleVal}");
        Console.WriteLine($"float to int: {(int)floatVal}");

        double d = intVal;  
        Console.WriteLine(d);
        //String to int .........
        string str = "123";
        int num = Convert.ToInt32(str);
        Console.WriteLine(num);

    }
}