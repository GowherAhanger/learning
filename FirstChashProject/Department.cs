namespace FirstChashProject;
//Simple program on Static and nonStatic/instance fields and methods....................  
public class Department
{
    public static string DepartmentName;
    public string  DepartmentSection;
    public int DepartmentSectionNumber;

    public void display(string DepartmentSection, int  DepartmentSectionNumber, string DepartmentName)
    {
        Console.WriteLine(
                          $"Department section number is :{DepartmentSectionNumber}: \n " +
                          $"And the section is : {DepartmentSection} \n" +
                          $"And name is : {DepartmentName}");
    }
    
    
}