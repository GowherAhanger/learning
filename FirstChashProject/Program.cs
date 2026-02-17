using School;
using System.Collections.Generic;
namespace FirstChashProject;
using System;

class Program
{
    
    static void Main(string[] args)
    {
        // Console.WriteLine("Enter Value ");
       // string value = Console.ReadLine();
       // Console.WriteLine("Entered  " + value);
       //  DataTypes data = new DataTypes();
       //  data.PrintDataTypes();
       //  //obj of implecit TypeCasting........
       //  
       //  TypeCasting obj = new TypeCasting();
        //obj for Explicit Casting
        //ExplicitCasting  obj2 = new ExplicitCasting();
       // obj2.ExpCasting();
        //Implicit Casting methods Call in main ..........
        // obj.display();
        // obj.print();
        // Nullcoalesing   obj3 = new Nullcoalesing();
        // obj3.print();
        // int x = 2;
        // string s = "you";
        // Console.WriteLine(x+s);
        // MyOpreators my = new MyOpreators();
        // AgeCalculator ac = new AgeCalculator();
        // ac.CheckNumber();
        // SwitchExample secondExample = new SwitchExample();
        // secondExample.SimpleSwitch();
        //BasicLoopExamples ble = new BasicLoopExamples();
        // BreadAndContinue bc = new BreadAndContinue();
        // bc.BandC();
        //PrimeProgram pp = new PrimeProgram();
        //Swap sp = new  Swap();
        //WholeNumbers wn =  new WholeNumbers();
        //FindOddEven fe = new FindOddEven();
        //OddNumbers od = new OddNumbers();
        //EvenNumbers ens = new EvenNumbers();
        //PrimeNumbers pn = new PrimeNumbers();
        //ReverseString rs = new ReverseString();
        //Triverse_And_Print_2dArray tp = new Triverse_And_Print_2dArray();
        //MatrixMultipulcation mm = new MatrixMultipulcation();
          // Student std = new Student();
          // std.DisplayName("GowherAhanger");
          // std.DisplayMarks(72);
          // Hierarchical inheritance objs........  
          //objs of Dog.......
          // Dog dog = new Dog();
          // dog.Eat(); // base class obj..........
          // dog.Bark();// derived class obj.........
          // Console.WriteLine();
          //objs for cat.................
          // Cat  cat = new Cat();
          // cat.Eat();  // parent/animal class obj ...........
          // cat.Meow(); // child/ cat  class obj................
          //oerloading ..............
          // ExampleOverload eo = new ExampleOverload();
          // eo.add();
          // eo.add(1, 2);
          // eo.add(3, 4);
          // eo.add(1, 4, 6);
          // Method OverRideing...................
          // Human h = new Employee();
          // h.Print();
          // Employee e = new Employee();
          // e.mySalery();
          // e.work();
         // Golden golden = new Golden();
         // golden.color();
         // golden.isDelicious();
         // golden.price();
         //static and notStatic emample................
         // Department department = new Department();
         // department.display("Finance",22,"Codestrix");
         // Console.WriteLine("Original Constructor");
         // Copy_Constructor cc = new Copy_Constructor("adil",33);
         // cc.display();
         // Console.WriteLine("Copy  Constructor");
         // Copy_Constructor obj = new Copy_Constructor(cc);
         // obj.display();
        // ValueTypes valueTypes = new ValueTypes();
        //
        // valueTypes.age = 20;
        // valueTypes.salary = 2000;
        //
        // ValueTypes valueTypes2 = valueTypes;
        // ValueTypes valueTypes3 = valueTypes2;
        // valueTypes.age = 25;
        // Console.WriteLine();
        // Console.Write("valuetype 3rd");
        // valueTypes3.Display();
        // Console.WriteLine();
        // Console.Write("valude type 2nd");
        // valueTypes2.Display();
        // Console.WriteLine();
        // Console.Write("valuetype ist...");
        // valueTypes.Display();
        
        
            //Pass by value example method called using class because it is static.....
        //    int value = 5;
        // Pass_by_value__Pass_By_Ref.pass_By_value(value);
        // Console.WriteLine("value of main class variable is " + value);
        // //Pass by refrence example method call ...............
        // int value12 = 5;
        // Console.WriteLine("Printing Refrence method.......\n");
        // Pass_by_value__Pass_By_Ref.Pass_by_Ref( ref value12);
        // Console.Write("Printing ref value_12 \n");
        // Console.Write(value12);
        //Out keyword example..............
        // int valueOfOut;
        // Pass_By_Out po = new Pass_By_Out();
        // Console.WriteLine("Value of out Method:=>");
        // po.Out_Method(out valueOfOut);
        // Console.WriteLine(" variable Out Value:\n {0}", valueOfOut);
        // po.Out_Method( sum, sub);
// student management system H/w objs................................
    //     Console.Write("Enter number of students: ");
    //     int totalStudents = int.Parse(Console.ReadLine());
    //     
    //     Student_Info [] students = new Student_Info[totalStudents];
    //     Subject_Info [] subjects = new Subject_Info[totalStudents];
    //     Registration_Info [] registrations = new Registration_Info[totalStudents];
    //     Library_Info [] libraries = new Library_Info[totalStudents];
    //     // entering details ....................
    //     for (int i = 0; i < totalStudents; i++)
    //     {
    //         //student details..........
    //         
    //         Console.WriteLine($"\n Enter Details of student:=> {i + 1}");
    //         Console.WriteLine("Enter Student ID");
    //        int  Student_Id = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter Student Name:");
    //         string Student_Name = Console.ReadLine();
    //         Console.WriteLine("Enter Student_Age");
    //         int Student_Age = int.Parse(Console.ReadLine());
    //         Console.WriteLine("Student Class Name");
    //         string Student_class = Console.ReadLine();
    //         
    //         students[i] = new Student_Info(Student_Id, Student_Name, Student_Age,Student_class);
    //         
    //         //subject details................
    //         
    //         Console.WriteLine("\n Enter Subjects.......");
    //         Console.WriteLine("Enter First Subject:");
    //         string First_Subject_Name = Console.ReadLine();
    //         Console.WriteLine("Enter Second Subject:");
    //         string Second_Subject_Name = Console.ReadLine();
    //         Console.WriteLine("Enter third Subject:");
    //         string Third_Subject_Name = Console.ReadLine();
    //         Console.WriteLine("Enter First Subject Marks");
    //         int First_Subject_Marks = int.Parse(Console.ReadLine());
    //         Console.WriteLine("Enter Second Subject Marks");
    //         int Second_Subject_Marks = int.Parse(Console.ReadLine());
    //         Console.WriteLine("Enter Third Subject Marks");
    //         int Third_Subject_Marks = int.Parse(Console.ReadLine());
    //        //total marks ...................
    //         subjects[i] = new Subject_Info(First_Subject_Name,Second_Subject_Name,Third_Subject_Name
    //         ,First_Subject_Marks,Second_Subject_Marks,Third_Subject_Marks);
    //         //Printing total marks.......
    //         Console.WriteLine("\nTotal Marks for this student: " + subjects[i].Total_Marks);
    //
    //         //registaration Details.....................
    //         Console.WriteLine("\n Enter Registration Details");
    //         Console.WriteLine("Enter Student ID");
    //         int student_Id = int.Parse(Console.ReadLine());
    //         Console.WriteLine("Enter Registration ID");
    //         string Reg_ID = Console.ReadLine();
    //         Console.WriteLine("Enter Registration Amount");
    //         int Reg_Amount = int.Parse(Console.ReadLine());
    //         
    //         registrations[i] = new Registration_Info(Student_Id, Reg_ID, Reg_Amount);
    //         //libarary Details....................
    //         
    //         Console.WriteLine("\n Enter Libarary Details");
    //         Console.WriteLine("Enter Student ID");
    //         int Student_ID = int.Parse(Console.ReadLine());
    //         Console.WriteLine("Enter BookName");
    //         string BookName = Console.ReadLine();
    //         Console.WriteLine("Book Issued On (yyyy-MM-dd): ");
    //         DateTime issuedOn = DateTime.Parse(Console.ReadLine());
    //         Console.WriteLine("Book Returned On (yyyy-MM-dd): ");
    //         DateTime returnedOn = DateTime.Parse(Console.ReadLine());
    //         Console.WriteLine("Book Expires On (yyyy-MM-dd): ");
    //         DateTime expiresOn = DateTime.Parse(Console.ReadLine());
    //         libraries[i] = new Library_Info(student_Id,BookName,issuedOn,returnedOn,expiresOn);
    //         // printing all details ........................
    //         Console.WriteLine("\n Student Management System ..........");
    //
    //         for (int s = 0; s < totalStudents; s++)
    //         {
    //             if (students[s] != null)
    //             {
    //                 Console.WriteLine($"\nStudent {i + 1}");
    //                 students[s].PrintStudentInfo();
    //                 subjects[s].PrintSubjectInfo();
    //                 registrations[s].PrintRegistrationInfo();
    //                 libraries[s].PrintLibraryInfo();
    //                 Console.WriteLine("--------------------------------------");
    //             }
    //         }
    //         
    //     }
            // Oprator_OverLoading opl1 = new Oprator_OverLoading();
            // opl1.Str = "Gowher";
            // opl1.Num = 1995;
            // Oprator_OverLoading opl2 = new Oprator_OverLoading();
            // opl2.Str = "Ahanger";
            // opl2.Num = 1995;
            // Oprator_OverLoading opl3 = new Oprator_OverLoading();
            // opl3 = opl1 + opl2;
            // Console.WriteLine(opl3.Str);
            // Console.WriteLine(opl3.Num);
           //  Sdudents_Data sd = new Sdudents_Data();
           // Console.WriteLine(sd.getAge()); 
           // Console.WriteLine(sd.setAge(23));
          // Teacher.print();
          // Admenistration.AdmissonSection.print();
          // Can_Inherit_Be_Called2 c2 = new Can_Inherit_Be_Called2();
          //   c2.Print();
         // Def def = new Def();
         // def.m1(20);
         // tbc tb = new tbc();
         // tb.m1();
         
         //Hyprid Inheritance.................
         // Library studentLibrary = new Library(
         //  101, "gowher", 20, "12th Grade",
         //  501, "Mathematics", "Physics",
         //  "Physics", DateTime.Now.AddDays(-5),
         //  DateTime.Now.AddDays(5), DateTime.Now.AddDays(10)
         // );
         // Console.WriteLine("Student Information:");
         // studentLibrary.Display_Student();
         //
         // Console.WriteLine("\nSubject Information:");
         // studentLibrary.Display_Subject_Information();
         //
         // Console.WriteLine("\nLibrary Information:");
         // studentLibrary.Display_Library_Info();
         
         //Multipule Inhritance using interfaces
         // SmartPhone SP = new SmartPhone();
         // SP.Call();
         // SP.playMusic();
         // SP.takePicture();
         
         // CommandLine
         // double number1= double.Parse(args[0]); 
         // string oprator = args[1];
         // double number2 = double.Parse(args[2]);
         // if (oprator == "+")
         // {
         //  Console.WriteLine(number1 + number2);
         // }
         // else if (oprator == "-")
         // {
         //  Console.WriteLine(number1 - number2);
         // }
         // else if (oprator == "*")
         // {
         //  Console.WriteLine(number1 * number2);
         // }
         // else
         // {
         //  Console.WriteLine(number2 / number1);
         // }
         //Displaying ..............
         // Jagged_Array_Example jaggedArray = new Jagged_Array_Example();
         // jaggedArray.Display_jaggedArray();
         // jaggedArray.Display_jaggedArray2();
         // Array_List_Example ALE = new Array_List_Example();
         // ALE.arrayList(); 
         //Printing HashTable ...............................
         //HashTable_Example ht = new HashTable_Example();
         //Stack Example Program..................................
         // StackExample  stack = new StackExample();
         // stack.StackOperations();
         // stack.Push(22);
         // stack.Peek();
         // stack.Pop();
         //Sortted_List program ......................
         Sorted_LIst_Example st = new Sorted_LIst_Example();
         st.sortedList_Opreations();
         
    }
    
}

