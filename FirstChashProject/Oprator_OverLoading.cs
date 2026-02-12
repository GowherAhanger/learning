namespace FirstChashProject;

public class Oprator_OverLoading
{
    public string Str;
    public int Num;
     
    public static Oprator_OverLoading operator +(Oprator_OverLoading opl1, Oprator_OverLoading opl2)
    {
        Oprator_OverLoading opl3 = new Oprator_OverLoading();
        opl3.Str = opl1.Str + " " + opl2.Str;
        opl3.Num = opl1.Num + opl2.Num;
        return opl3;
    }
    

}