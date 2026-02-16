using System.Collections;

namespace FirstChashProject;

public class Array_List_Example
{
     public void arrayList()
    {
        ArrayList std = new ArrayList();
        std.Add(12);
        std.Add("Gowher");
        std.Add("rakib");
        Console.WriteLine(std.Count);
        Console.WriteLine(std.Capacity);
        foreach (var students  in std)
        {
            Console.WriteLine(students);
        }
    }
}