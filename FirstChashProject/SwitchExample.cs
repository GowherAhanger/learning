namespace FirstChashProject;

public class SwitchExample
 {
     public void SimpleSwitch()
     {
         
        Console.Write("Enter Day No: ");
         int day  = int.Parse(Console.ReadLine());
         switch (day)
         {
             case 1:
             {
                 Console.Write(" day is  Monday: ");
                 break;
             }
             case 2:
             {
                 Console.WriteLine(" day is  Tuesday: ");
                 break;
             }
             case 3:
             {
                 Console.WriteLine(" day is Wednesday: ");
                 break;
             }
             case 4:
             {
                 Console.WriteLine(" day is Thursday: ");
                 break;
             }
             case 5:
             {
                 Console.WriteLine(" day is  Friday: ");
                 break;
             }
             case 6:
             {
                 Console.WriteLine("day is  Saturday: ");
                 break;
             }
             case 7:
             {
                 Console.WriteLine("Enter 7 for Sunday: ");
                 break;
             }
             default:
             {
                 Console.WriteLine("Enter valid No");
                 break;
             }
         }
    }
}