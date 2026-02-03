namespace FirstChashProject;

public abstract class Human
{
    public virtual void Print()
    {
        Console.WriteLine("I am  a human");
    }
}

public interface Iwork
{
    void work();
     void Print();
}

public interface Isalery
{
    void mySalery();
}

 class Employee : Human,Iwork,Isalery
{
    public override void Print()
    {
        Console.WriteLine("I am a employee");
    }
    
    public void mySalery()
    {
        Console.WriteLine("my Salery is 2000");
    }

    public void work()
    {
        Console.WriteLine("I am working as teacher");
    }
}
