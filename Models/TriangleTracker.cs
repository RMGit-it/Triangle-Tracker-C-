namespace TriangleTracker
{
  public class Triangle
  {
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    public Triangle(int side1, int side2, int side3)
    {
      A = side1;
      B = side2;
      C = side3;
    }
  
  
    public string CheckType() 
    {
      if ((A > (B + C)) || (B > (A + C)) || (C > (A + B)))
      {
        return "not a triangle";
      } else if ((A != B) && ((A != C)) && ((B != C)))
      {
        return "scalene triangle";
      } else if ((A == B) && (A == C)) 
      {
        return "equilateral triangle";
      } else 
      {
        return "isosceles triangle";
      }
    }
  }
}
