namespace FirstChashProject;

public class ReverseString
{
    private string  str  = "Gowher";
    
    public ReverseString()
    {
        for (int i = str.Length-1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
    }
}