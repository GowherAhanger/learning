namespace FirstChashProject;

public class MyOpreators
{
        public MyOpreators()
    {
        //Arthematic Opreators
        int a = 4, b = 5;
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        
        //Assingment Opreators
        int d = 34;
        d += 34;
        int e = 55;
        e += 55;
        int f = 77;
        f += 77;
        int g = 99;
        g += 99;
        Console.WriteLine("{0},{0},{0},{0},{0}",g,f,e,d);
        //conditional Oprattors.....
        Console.WriteLine("Conditional Operators:");
        Console.WriteLine(a > b ? true : false);
        Console.WriteLine(a < b ? "a is smaller" : "b is smaller");
        Console.WriteLine(a == b ? "equal" : "not equal");
       //logical Opreator.....................
    

    }
}