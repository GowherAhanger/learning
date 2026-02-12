namespace FirstChashProject;

public class Multipule_Override
{
    public virtual void m1()
    {
        Console.WriteLine("Multipule_Override.m1()");
    }
}

public class tbc : Multipule_Override
{
    public override void m1()
    {
        Console.WriteLine("Multipule_Override.m1() in tbc ");
    }
}

public class dbc: tbc
{
    public override void m1()
    {
        Console.WriteLine("Multipule_Override.m1() in dbc ");
    }
}

public class abc:dbc
{
    

    public override void m1()
    {
        Console.WriteLine("Multipule_Override.m1() in abc ");
    }
}