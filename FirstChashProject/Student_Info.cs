namespace FirstChashProject;

public class Student_Info
{
    //Student information .....................................
    public int Student_Id;
    public string Student_Name;
    public int Student_Age;
    public string Student_Class;

    public Student_Info(int Student_Id, string Student_Name, int Student_Age, string StudentClass)
    {
        this.Student_Id = Student_Id;
        this.Student_Name = Student_Name;
        this.Student_Age = Student_Age;
        this.Student_Class = StudentClass;
    }
    public void PrintStudentInfo()
    {
        Console.WriteLine("Student_ID: "+ Student_Id);
        Console.WriteLine("Student_Name: " + Student_Name);
        Console.WriteLine("Student_Age: " + Student_Age);
    }
}
        //Subject information..............
class Subject_Info
{
    
    public  string First_Subject_Name;
    public string Second_Subject_Name;
    public string Third_Subject_Name;
    public int FirstSub_marks;
    public int SecondSub_marks;
    public int Third_Sub_marks;
    public int Total_Marks;

    public Subject_Info(string First_Subject_Name,
        string Second_Subject_Name, 
        string Third_Subject_Name ,
        int firstSubMarks,
        int secondSubMarks,
        int thirdSubMarks)
    {
        this.First_Subject_Name = First_Subject_Name;
        this.Second_Subject_Name = Second_Subject_Name;
        this.Third_Subject_Name = Third_Subject_Name;
        this.FirstSub_marks = firstSubMarks;
        this.SecondSub_marks = secondSubMarks;
        this.Third_Sub_marks = thirdSubMarks;
        this.Total_Marks = Total_Marks = FirstSub_marks+ SecondSub_marks+Third_Sub_marks;
    }

    public void PrintSubjectInfo()
    {
        Console.WriteLine("First Subject_Name: " + First_Subject_Name+ "First Subject Marks: " + FirstSub_marks);
        Console.WriteLine("Second Subject_Name: " + Second_Subject_Name+ "Second Subject Marks: " + SecondSub_marks);
        Console.WriteLine("Third Subject_Name: " + Third_Subject_Name+ "Third Subject Marks: " + Third_Sub_marks);
        Console.WriteLine("Total_Marks: " + Total_Marks);
    }
}
// Registration information ....................
class Registration_Info
{
    public  int Student_Id;
    public string Reg_Id;
    public int Reg_Amount;
    public Registration_Info(int Student_Id, string Reg_Id, int Reg_Amount)
    {
        this.Student_Id = Student_Id;
        this.Reg_Id = Reg_Id;
        this.Reg_Amount = Reg_Amount;
    }

    public void PrintRegistrationInfo()
    {
        Console.WriteLine("Student_ID: " + Student_Id);
        Console.WriteLine("Reg_Id: " + Reg_Id);
        Console.WriteLine("Reg_Amount: " + Reg_Amount);
        
    }
    
}
//libarary information...........................
class Library_Info
{
    public int Student_Id;
    public string Book_Name;
    public DateTime Issuied_on;
    public DateTime Returned_on;
    public DateTime Expires_on;

    public Library_Info(int studentId, string Book_Name, DateTime Issuied_on, DateTime Returned_on, DateTime Expires_on)
    {
        this.Student_Id = studentId;
        this.Book_Name = Book_Name;
        this.Issuied_on = Issuied_on;
        this.Returned_on = Returned_on;
        this.Expires_on = Expires_on;
    }

    public void PrintLibraryInfo()
    {
        Console.WriteLine("Student_Id: " + Student_Id);
        Console.WriteLine("Book_Name: " + Book_Name);
        Console.WriteLine("Issuied_on: " + Issuied_on.ToShortDateString());
        Console.WriteLine("Returned on: " + Returned_on.ToShortDateString());
        Console.WriteLine("Expires_on: " + Expires_on.ToShortDateString());
    }
}   