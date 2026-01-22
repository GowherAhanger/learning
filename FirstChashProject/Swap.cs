using System.Net.ServerSentEvents;

namespace FirstChashProject;

public class Swap
{
     public Swap()
     {
          int x = 100;

          int y = 5;
          int z = x;
          x = y;
          y=z;
          Console.Write($"x and y are : {x}, {y}, {z}");
}


}