namespace FirstChashProject;

using System;
public class AgeCalculator
{
    public void CheckNumber()
    {
        // Console.WriteLine("Age Calculator");
        // String phoneNumber;
        // //string num="10";
        // Console.WriteLine("Enter your PhoneNumber");
        //  phoneNumber = Console.ReadLine();
        // //verify phone no..................
        //  if (phoneNumber != null && phoneNumber.Length==10 )
        //  {
        //      Console.WriteLine("Number is True");
        //  }
        //  else
        //  {
        //      Console.WriteLine("Number is False");
        //  }
        Console.Write("Enter phone: ");
        string phoneNumber = Console.ReadLine();
        bool perfect = true;

        if (phoneNumber.Length != 10 || phoneNumber[0] == '0')
            perfect = false;
        else
            for (int i = 0; i < phoneNumber.Length; i++)
                if (phoneNumber[i] < '0' || phoneNumber[i] > '9')
                {
                    perfect = false;
                    break;
                }

        Console.WriteLine(perfect ? "Valid phone number" : "Invalid phone number");
         //Determine age .........
         Console.Write("Enter your Date of Birth (dd/MM/yyyy): \n");
         string dobInput = Console.ReadLine();
         DateTime dob = DateTime.ParseExact(dobInput, "dd/MM/yyyy", null);
         Console.WriteLine("current Date and time :\n");
         DateTime currentDate = DateTime.Now;
         Console.WriteLine(currentDate);
         //validating age...............
         int age = currentDate.Year - dob.Year;
         if (age <= 0 || age > 120)
         {
             Console.WriteLine("Invalid age");
             return;
         }
        
         Console.WriteLine("Please wait... displaying age after 2 seconds");

         for (long i = 0; i < 2000000000; i++)
         {
             // do nothing (delay)
         }
         //for delay we can also use this.........and also stopwatch obj  
         // DateTime start = DateTime.Now;
         // while ((DateTime.Now - start).TotalSeconds < 2)
         // { }
        
        Console.WriteLine("Your age is :=>{0}",age);
    }
}