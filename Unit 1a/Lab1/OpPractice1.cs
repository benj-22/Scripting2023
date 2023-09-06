using System;

namespace OperationsLab
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int x = 13 + 7;
      Console.WriteLine("x-blade: " + x);
      
      int m = 3;
      Console.WriteLine("# of 'main games': " + m);
      
      int s = 10;
      Console.WriteLine("# of 'side games': " + s);
      
      int dark = s + m;
      int light = m + 4; 
      int lightVar = s - m;
      
      int kh = dark * light;
      Console.WriteLine("Kingdom Hearts: " + kh);
      
      int dtd = dark / light;
      Console.WriteLine("Door to Darkness: " + dtd);
      
      int wnw = dark % light;
      Console.WriteLine("The World that Never Was: " + wnw);
      
      string orgX = "Organization XIII";
      int org = 13;
      Console.WriteLine(orgX + " before no. I: " + org);
      
      org++;
      Console.WriteLine(orgX + " after no. I: " + org);
      
      org--;
      org--;
      Console.WriteLine(orgX + " after Sora recompleted: " + org);
     }
  }
}
