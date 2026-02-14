namespace FirstChashProject;

public class Jagged_Array_Example
{
    int[][] jaggedArray = new int[3][];

    public Jagged_Array_Example()
    {
        jaggedArray[0] = new int[2] { 1, 2 };
        jaggedArray[1] = new int[3] { 3, 4, 5 };
        jaggedArray[2] = new int[1] { 6 };
    }

    public void Display_jaggedArray()
    {
        for (int i = 0; i < jaggedArray.GetLength(0); i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j]);
            }
            Console.WriteLine();
        }
    }
//using foreach loop.................
    public void Display_jaggedArray2()
    {
        foreach (int[] item in jaggedArray)
        {
            foreach (var i in item)
            {
                Console.Write(i + " ");
            }
            
        }
    }
}