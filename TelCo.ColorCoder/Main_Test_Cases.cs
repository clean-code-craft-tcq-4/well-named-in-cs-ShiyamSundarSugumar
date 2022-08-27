using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
  public class Main_Test_case
  {
    public static void Test_case()
    {
      int pairNumber = 4;
      /*
      Program.ColorPair testPair1 = Get_Color.GetColorFromPairNumber(pairNumber);
      Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
      Debug.Assert(testPair1.majorColor == Color.White);
      Debug.Assert(testPair1.minorColor == Color.Brown);
      */
      GetColorFromPairNumberTestCase(pairNumber,Color.White,Color.Brown);
      
      pairNumber = 5;
      /*
      testPair1 = Get_Color.GetColorFromPairNumber(pairNumber);
      Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
      Debug.Assert(testPair1.majorColor == Color.White);
      Debug.Assert(testPair1.minorColor == Color.SlateGray); */
      GetColorFromPairNumberTestCase(pairNumber,Color.White,Color.SlateGray);
      
      pairNumber = 23;   // Color = Violet & Green
      GetColorFromPairNumberTestCase(pairNumber,Color.Violet,Color.Green);

      Program.ColorPair testPair2 = new Program.ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
      pairNumber = Get_PairNumber.GetPairNumberFromColor(testPair2);
      Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
      Debug.Assert(pairNumber == 18);

      testPair2 = new Program.ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
      pairNumber = Get_PairNumber.GetPairNumberFromColor(testPair2);
      Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
      Debug.Assert(pairNumber == 6);

    }
    public static void GetColorFromPairNumberTestCase(int pairNumber, Color First_Color, Color Second_Color)
    {
      Program.ColorPair testPair1 = Get_Color.GetColorFromPairNumber(pairNumber);
      String PrintData = ("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
      PrintFunction(PrintData);
      Debug.Assert(testPair1.majorColor == First_Color);
      Debug.Assert(testPair1.minorColor == Second_Color);
    }
    
    public static void PrintFunction(String PrintData)
    {
      Console.WriteLine(PrintData);
    }
  }

}
