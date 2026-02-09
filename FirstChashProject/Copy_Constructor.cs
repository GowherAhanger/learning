namespace FirstChashProject;
//Basic example of copy constructor................
public class Copy_Constructor
{
    public string name;
    public int age;
    //Orginal constructor name  of ctor is not reasonable .........
    public Copy_Constructor(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
//copy constructor...................
    public Copy_Constructor(Copy_Constructor c)
    {
        if (c == null)
        {
            Console.WriteLine("null");
        }
            else
        {
            name = c.name;
            age = c.age;
        }
    }

    public void display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine();
    }
    
}