namespace FirstChashProject;

public class Nullcoalesing
{
   public void print()
    {
        int? age = null;

        int result = age ?? 18;

        Console.WriteLine(result);
    }

  

}