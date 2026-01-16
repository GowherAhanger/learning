namespace FirstChashProject;
using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter Value ");
       string value = Console.ReadLine();
       Console.WriteLine("Entered  " + value);
        DataTypes data = new DataTypes();
        data.PrintDataTypes();
        //obj of implecit TypeCasting........
        
        TypeCasting obj = new TypeCasting();
        obj.display();
        obj.print();
    }
}