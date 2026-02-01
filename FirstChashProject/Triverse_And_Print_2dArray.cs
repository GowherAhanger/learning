namespace FirstChashProject;

public class Triverse_And_Print_2dArray
{
    public Triverse_And_Print_2dArray()
    {
        int rows, cols;
        Console.WriteLine("Enter rows of  the array:");
        rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter cols of the array:");
        cols = int.Parse(Console.ReadLine());
        int[,] arr = new int[rows, cols];
        //scanning elements...........................
        Console.WriteLine("Enter elements for rows and cols to scan:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //Displaying Elments..............
        Console.WriteLine("Displaying Elements......................");
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < rows; k++)
            {
                Console.Write(arr[j, k] + "   ");
            }
            Console.WriteLine();
        }
    }
}