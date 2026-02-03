namespace FirstChashProject;
// simple/Basic  interface program..............
// class golden implements interface............
public interface IApple
{
    void color();
    void isDelicious();
}

public interface IPrice
{
    void price();
}

public class Golden : IApple,IPrice
{
    public void color()
    {
        Console.WriteLine("is of golden color");
    }

    public void isDelicious()
    {
       Console.WriteLine("it  delicious ");
    }

    public void price()
    {
        Console.WriteLine(" price= 200 per unit ");
    }
    
}