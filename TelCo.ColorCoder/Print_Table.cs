using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
  internal class Print_Table
  {
      internal void Table(Color[] colorMapMajor, Color[] colorMapMinor)
      {
          int MajorLength = 0, MinorLength = 0,index = 1;
          MajorLength = colorMapMajor.Length;
          MinorLength = colorMapMinor.Length;
          Console.WriteLine("{0}   {1}",MajorLength, MinorLength);
          Console.WriteLine("| Index \t  | MajorColor\t\t\t  | MinorColor\t\t\t  |");
          for (int i = 0,j = 0; i < MajorLength; i++)
          {
              for (; j < MinorLength; j++)
              {
                  Console.WriteLine("| {0}\t  | {1} \t\t  | {2} \t\t  |", index, colorMapMajor[i], colorMapMinor[j]);
                  index++;
              }
          }
      }
  }

}
