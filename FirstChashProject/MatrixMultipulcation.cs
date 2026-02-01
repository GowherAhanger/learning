namespace FirstChashProject;

public class MatrixMultipulcation
{
    public MatrixMultipulcation()
    {
        int rows, cols, i, j, k;
        Console.Write("Enter the number of rows: ");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: "); 
        cols = int.Parse(Console.ReadLine());
        int [,] First=  new int[rows, cols];
        int [,] Second = new int[rows, cols]; 
        int [,] Result = new int[rows, cols];
        //scanning elements for rows and cols for First[] also namely First....
        Console.WriteLine("Enter elements for first 2d array");
        for (i = 0; i < rows; i++)
        {
            for (j = 0; j < cols; j++)
            {
                First[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //scanning elements for rows and cols for Second[] aka Secnd....
        Console.WriteLine("Enter elements for first 2d array");
        for (i = 0; i < rows; i++)
        {
            for (j = 0; j < cols; j++)
            {
                Second[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        //Multiplication of First And second............
        //Console.WriteLine("Multplication of First and Second");
        for (i = 0; i < rows; i++)
        {
            for (j = 0; j < rows; j++)
            {
                int sum = 0; 
                for (k = 0; k < cols; k++)
                {
                    Result[i, j] = First[i, k] * Second[k, j];
                }
            }
        }
        //Displaying Result[i,j];  .........................
        Console.WriteLine("Multplication of First and Second");
        for(i=0;i<rows;i++)
        {
            for (j = 0; j < rows; j++)
            {
                Console.Write(Result[i, j] + "   ");
            }
            Console.WriteLine();
        }

    }
}