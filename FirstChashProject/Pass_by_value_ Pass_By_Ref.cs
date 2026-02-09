namespace FirstChashProject;

public class Pass_by_value__Pass_By_Ref
{
    

    public static void pass_By_value(int value)
    {
        value = value + 10;
        Console.WriteLine(" value of method");
        Console.WriteLine(value);
    }

    public static void Pass_by_Ref(ref int value2)
    {
        value2 = value2 + 2;
    }
    
}