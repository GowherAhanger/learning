namespace FirstChashProject;

public class FindOddEven
{
    public FindOddEven()
    {
        int num;

        do
        {
            Console.WriteLine("Enter Number to Find Odd or Even (0 or less to exit)");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                if (num % 2 == 0)
                    Console.WriteLine($"{num} is Even");
                else
                    Console.WriteLine($"{num} is Odd");
            }

        } while (num > 0);
    }
}