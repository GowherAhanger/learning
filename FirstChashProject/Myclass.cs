
namespace FirstChashProject;
using System;
   
    public abstract class Myclass
    {
        public int x;
        public abstract void m1(int x);

    }

    public class Abc : Myclass
    {
        int y;

        public void Set()
        {
            y = 10;
        }

        public override void m1(int x)
        {
            y = x;
            Console.WriteLine("Abc m1 called  y = " + y);
        }

    }

    public class Def : Abc
        {
            private int z;
            public override void m1(int y)
            {
                z = y;
                Console.WriteLine("Def m1 called  z = " + z);
            }
          
        }
    

    



 