using System.Collections;

namespace FirstChashProject;

using static System.Collections.DictionaryEntry;

public class Sorted_LIst_Example
{
    public  SortedList<int, String> st;
    public Sorted_LIst_Example()
    {
        st = new SortedList<int, string>();
        st.Add(1,"Gowher Ahanger");
        st.Add(2," Muzammil Shakeel");
        st.Add(3,"Asim Mushtaq");
        st.Add(4,"Owais Ashraf");
        st.Add(5, "Firdos Ahmad");
        st.Add(6,"Saqib Mir");
         int count = st.Count();
         
         Console.WriteLine("count of sortedLIst : = >" + " "+count);
         // Triversing sorted List ................
         foreach (var i in st)
         {
             Console.WriteLine(i.Key + " : " + i.Value);
         }
         //triversing only keys...................
         foreach (var i in st.Keys)
         {
             Console.WriteLine(i + " : " + st[i]);
         }
         //triversing only values...............
         foreach (var i in st.Values)
         {
             Console.WriteLine(i);
         }
        Console.WriteLine("using key value pair");
         foreach (KeyValuePair<int, string> de in st)
         {
             Console.WriteLine(de.Key + " : " + de.Value);
         }
        
    }

    public void sortedList_Opreations()
    { 
        Console.WriteLine("\n Contains Key Method.........\n");
       Console.Write( st.ContainsKey(3));
        Console.WriteLine("\nContains Value Method...........\n");
       Console.WriteLine( st.ContainsValue("Gowher"));
       Console.WriteLine("\nValue at Index Method...........\n");
        Console.WriteLine(st.GetValueAtIndex(4));
        Console.WriteLine("\n key at Index Method...........\n");
       Console.WriteLine( st.GetKeyAtIndex(4));
       Console.WriteLine("\n getting TYype Method...........\n");
        Console.WriteLine(st.GetType());
        Console.WriteLine("\nGetting count Method...........\n");
        Console.WriteLine(st.Count());
        Console.WriteLine(" \nMethod...........\n");
        st.RemoveAt(2);
        
        
    }
}