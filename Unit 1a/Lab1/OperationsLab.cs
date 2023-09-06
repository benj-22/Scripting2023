using System;

namespace OperationsLab
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int x = 13 + 7; //+ adds two numbers together
      Console.WriteLine("x-blade: " + x);
      
      int m = 3; //all whole numbers are held in int
      Console.WriteLine("# of 'main games': " + m);
      
      int s = 10;
      Console.WriteLine("# of 'side games': " + s);
      
      int dark = s + m; //it can also add two variables together
      int light = m + 4; //or a variable and a number
      int lightVar = s - m; //- subtracts
      
      Console.WriteLine("Dark needed: " + dark);
      Console.WriteLine("Light needed: " + lightVar);
      
      int kh = dark * light; //* multiplies
      Console.WriteLine("Kingdom Hearts: " + kh);
      
      int dtd = dark / light; // "/" divides
      Console.WriteLine("Door to Darkness: " + dtd);
      
      int wnw = dark % light; //% holds the reminder when the two are divided
      Console.WriteLine("The World that Never Was: " + wnw);// 13/7 = 1 with remainder 6
      
      string orgX = "Organization XIII";
      int org = 13;
      Console.WriteLine(orgX + " before no. I: " + org);
      
      org++; //++ adds 1
      Console.WriteLine(orgX + " after no. I: " + org);
      
      org--;//--subtracts 1
      org--;
      Console.WriteLine(orgX + " after Sora recompleted: " + org);
     }
  }
}
