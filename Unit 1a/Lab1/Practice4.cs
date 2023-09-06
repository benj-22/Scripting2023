using System;

namespace MyApplication
{
  public class Program
  {
  	public static void Main(string[] args)
    {
      string name = "Spider-Man";
      Console.WriteLine(name + ":");
   
      int legNum = 2;
      Console.WriteLine("# of legs: " + legNum);
      
      int armNum;
      armNum = 2;
      Console.WriteLine("# of arms: " + armNum);
      
      armNum = 6; //armNum is now 6
      Console.WriteLine("# of arms after serum: " + armNum);
     }
  }
}
