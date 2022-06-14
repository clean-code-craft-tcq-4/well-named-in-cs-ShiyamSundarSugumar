using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
  internal class Print_Manual
  {
      internal static void Table(Color[] colorMapMajor, Color[] colorMapMinor)
      {
          int MajorLength = 0, MinorLength = 0,index = 1;
          MajorLength = colorMapMajor.Length;
          MinorLength = colorMapMinor.Length;
          
          Console.WriteLine("|   Index\t  |   MajorColor\t\t\t  |   MinorColor\t\t\t  |");
          Console.WriteLine("------------------------------------------------------------------------");
          for (int i = 0; i < MajorLength; i++)
          {
              for (int j = 0; j < MinorLength; j++)
              {
                  Console.WriteLine("|   {0}\t  |   {1} \t\t  |   {2} \t\t  |", index, colorMapMajor[i], colorMapMinor[j]);
                  index++;
              }
          }
      }
  }

}
