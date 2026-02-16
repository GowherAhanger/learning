namespace FirstChashProject;
using System.Collections;

public class HashTable_Example
{
    public HashTable_Example()
    {
        Hashtable Employee = new Hashtable();
        Employee.Add(1, "John Doe");
        Employee.Add(2, "Alice Ford");
        Employee.Add(3, "Sam Jones");
        Employee.Add(4, "Jacob Jones");
        Employee.Add(5, "Dane Jones");
        Employee.Add(6, "Jack Jones");
        Console.WriteLine("Printing hash table ........");
        Console.WriteLine(Employee);
        Console.WriteLine("using Foreach");
        foreach (DictionaryEntry entry in Employee)
        {
            Console.WriteLine(entry.Key + " : " + entry.Value);
        }
        Console.WriteLine("Printing keys");
        foreach (var key  in Employee.Keys)
        {
            Console.WriteLine(key + " : " + Employee[key]);
        }
        Console.WriteLine("Printing values");
        foreach (var value in Employee.Values)
        {
            Console.WriteLine(value + " : " + Employee[value]);
        }
    }
}