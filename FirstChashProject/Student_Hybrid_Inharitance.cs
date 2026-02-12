using System;

namespace FirstChashProject
{
    public class Student_Hybrid_Inharitance
    {
        public int Student_Id;
        public string Student_Name;
        public int Student_Age;
        public string Student_Class;

        public Student_Hybrid_Inharitance(int student_Id, string student_Name, int student_Age, string student_Class)
        {
            this.Student_Id = student_Id;
            this.Student_Name = student_Name;
            this.Student_Age = student_Age;
            this.Student_Class = student_Class;
        }

        public void Display_Student()
        {
            Console.WriteLine($"Student_Id: {Student_Id}");
            Console.WriteLine($"Student_Name: {Student_Name}");
            Console.WriteLine($"Student_Age: {Student_Age}");
            Console.WriteLine($"Student_Class: {Student_Class}");
        }
    }

    public class Subject_Information : Student_Hybrid_Inharitance
    {
        public int BookId;
        public string Book_One_Name;
        public string Book_Two_Name;

        public Subject_Information(
            int student_Id, string student_Name,
            int student_Age, string student_Class,
            int bookId, string bookOneName,
            string bookTwoName) : base(student_Id, student_Name, student_Age, student_Class)
        {
            this.BookId = bookId;
            this.Book_One_Name = bookOneName;
            this.Book_Two_Name = bookTwoName;
        }

        public void Display_Subject_Information()
        {
            Console.WriteLine($"Book_ID: {BookId}");
            Console.WriteLine($"Book_One_Name: {Book_One_Name}");
            Console.WriteLine($"Book_Two_Name: {Book_Two_Name}");
        }
    }

    public class Library : Subject_Information
    {
        public string Library_Book_Name;
        public DateTime Issued_on;
        public DateTime Returned_on;
        public DateTime Expires_on;

        public Library(
            int student_Id, string student_Name,
            int student_Age, string student_Class,
            int bookId, string bookOneName, string bookTwoName,
            string libraryBookName, DateTime issued_on,
            DateTime returned_on, DateTime expires_on
        ) : base(student_Id, student_Name, student_Age, student_Class, bookId, bookOneName, bookTwoName)
        {
            this.Library_Book_Name = libraryBookName;
            this.Issued_on = issued_on;
            this.Returned_on = returned_on;
            this.Expires_on = expires_on;
        }

        public void Display_Library_Info()
        {
            Console.WriteLine($"Library Book Name: {Library_Book_Name}");
            Console.WriteLine($"Issued On: {Issued_on.ToShortDateString()}");
            Console.WriteLine($"Returned On: {Returned_on.ToShortDateString()}");
            Console.WriteLine($"Expires On: {Expires_on.ToShortDateString()}");
        }
    }
   

    
}