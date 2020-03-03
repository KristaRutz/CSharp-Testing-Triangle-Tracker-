using System;
using System.Collections.Generic;


namespace TriangleTracker
{
  public class Triangle
  {
    public int Side1;
    public int Side2;
    public int Side3;

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
    public bool IsTriangle()
    {
      if((Side1>=(Side2+Side3)) || (Side2>=(Side1+Side3)) || (Side3>=(Side1+Side2)))
      {
        Console.WriteLine("Not a triangle");
        return false;
      }
      else if( Side1 == Side2 && Side1 == Side3)
      {
        Console.WriteLine("Equilateral Triangle");
        return true;
      }
      else if(Side1 == Side2 || Side1 == Side3 || Side2 ==Side3 )
      {
        Console.WriteLine("Isosceles Triangle");
        return true;
      }
      else // (Side1!=Side2 && Side1!=Side3 && Side2!=Side3)
      {
        Console.WriteLine("Scalene Triangle");
        return true;
      }
    }
  }
  public class Program
  {
    public static void Main()
    {
      Triangle myTriangle = new Triangle(0,0,0);
      Console.WriteLine("Enter side one of triangle");
      myTriangle.Side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side two of triangle");
      myTriangle.Side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side three of triangle");
      myTriangle.Side3 = int.Parse(Console.ReadLine());
      int side1 = myTriangle.Side1;
      int side2 = myTriangle.Side2;
      int side3 = myTriangle.Side3;

      myTriangle.IsTriangle();

      // if((side1>=(side2+side3)) || (side2>=(side1+side3)) || (side3>=(side1+side2)))
      // {
      //   Console.WriteLine("Not a triangle");
      // }
      // else if( side1 == side2 && side1 == side3)
      // {
      //   Console.WriteLine("Equilateral Triangle");
      // }
      // else if(side1 == side2 || side1 == side3 || side2 ==side3 )
      // {
      //   Console.WriteLine("Isosceles Triangle");
      // }
      // else if(side1!=side2 && side1!=side3 && side2!=side3)
      // {
      //   Console.WriteLine("Scalene Triangle");
      //}
    }
  }
}
