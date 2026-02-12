namespace FirstChashProject;

public class Sdudents_Data
{
   public string name;
   private int age = 22;

   public int getAge()
   {
      return age;
   }

   public int setAge( int a)
   {
      this.age = a;
      return this.age;
   }
}