namespace FirstChashProject;

public class Can_Inherit_Be_Called
{
    public string Name = "Gowher";
    static Can_Inherit_Be_Called()
    {
        Console.WriteLine("Can_Inherit_Be_Called");
    }

}
class  Can_Inherit_Be_Called2:Can_Inherit_Be_Called
{
    public  void Print()
    {
        Console.WriteLine(Name );
    }
}