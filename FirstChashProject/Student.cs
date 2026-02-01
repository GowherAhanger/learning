namespace FirstChashProject;
//Child class and the parrent class is Person ......
public class Student:Person
{
    public  int Marks;
    public void DisplayMarks(int Marks)
    {
        Console.Write($" The number of Marks: {Marks}");
    }
}