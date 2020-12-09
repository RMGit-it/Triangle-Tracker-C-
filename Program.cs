using System;
using TriangleTracker;

namespace TriangleUI
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Give me the length of the first side of the triangle");
      int A = int.Parse(Console.ReadLine());

      Console.WriteLine("Give me the length of the second side of the triangle");
      int B = int.Parse(Console.ReadLine());

      Console.WriteLine("Give me the length of the third side of the triangle");
      int C = int.Parse(Console.ReadLine());

      Triangle triangle1 = new Triangle(A, B, C);

      Console.WriteLine(triangle1.CheckType());
    }
  }
}