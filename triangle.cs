using System;
using System.Collections.Generic;

class Triangle{
  private int _sideOne;
  private int _sideTwo;
  private int _sideThree;

  public void SetSideOne(int newSideOne)
  {
      _sideOne = newSideOne;
  }
  public  int GetSideOne()
  {
    return _sideOne;
  }

  public void SetSideTwo(int newSideTwo)
  {
      _sideTwo = newSideTwo;
  }
  public  int GetSideTwo()
  {
    return _sideTwo;
  }
  public void SetSideThree(int newSideThree)
  {
      _sideThree = newSideThree;
  }
  public  int GetSideThree()
  {
    return _sideThree;
  }


}



public class Program{
  public static void GetTriangle(int sideOne, int sideTwo, int sideThree){

    if (sideOne == sideTwo && sideOne == sideThree && sideTwo == sideThree){
      Console.WriteLine("This is an equilateral, all sides are equal.");
    }else if( sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree){
      Console.WriteLine("This is an isosceles, exactly 2 sides are equal.");
    }else if( sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo|| sideTwo + sideThree <= sideOne)
    {
      Console.WriteLine("This is not a Triangle!!!");
    }else{
    Console.WriteLine("This is a scalene,no sides are equal.");
    }
  }

  public static void Main()
  {
    Triangle NewTriangle = new Triangle();
    Console.WriteLine("Enter a number for side one: ");

     string stringTriangleOne = Console.ReadLine();
     int _sideOne=int.Parse(stringTriangleOne);

     string stringTriangleTwo = Console.ReadLine();
     int _sideTwo=int.Parse(stringTriangleTwo);

     string stringTriangleThree = Console.ReadLine();
     int _sideThree=int.Parse(stringTriangleThree);

    NewTriangle.SetSideOne(_sideOne);
    NewTriangle.SetSideTwo(_sideTwo);
    NewTriangle.SetSideThree(_sideThree);


    GetTriangle(NewTriangle.GetSideOne(),NewTriangle.GetSideTwo(),NewTriangle.GetSideThree());
  //  Console.WriteLine();


    // Console.WriteLine("Enter a number for side one: ");
    //   string stringTriangleOne = Console.ReadLine();
    //   int  sideOne1= int.Parse(stringTriangleOne);
    //
    // Console.WriteLine("Enter a number for side two: ");
    //   string stringTriangleTwo = Console.ReadLine();
    //   int  sideTwo1= int.Parse(stringTriangleTwo);
    //
    // Console.WriteLine("Enter a number for side three: ");
    //   string stringTriangleThree = Console.ReadLine();
    //   int  sideThree1= int.Parse(stringTriangleThree);

    //  Console.WriteLine(GetTriangle(sideOne1,sideTwo1,sideThree1));
    }

}
