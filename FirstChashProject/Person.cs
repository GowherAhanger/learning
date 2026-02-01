namespace FirstChashProject;
//Single inhertance class person which is parent class and another class student is child classs wiich inherts form person ...............
public class Person
{
    private string Name;

    public void DisplayName(string Name)
    {
         Console.WriteLine($"Name : {Name}");
    }
}