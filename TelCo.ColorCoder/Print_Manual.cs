using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
  internal class Print_Manual
  {
      internal static void Table()
      {
          int MajorLength = 0, MinorLength = 0,index = 1;
          MajorLength = Program.MajorColorList.Length;
          MinorLength = Program.MinorColorList.Length;
          
          Console.WriteLine("| Index\t  |   MajorColor\t\t   |   MinorColor\t\t   |");
          Console.WriteLine("------------------------------------------------------------------------");
          for (int i = 0; i < MajorLength; i++)
          {
              for (int j = 0; j < MinorLength; j++)
              {
                  Console.WriteLine("|   {0}\t  |   {1} \t\t   |   {2} \t\t   |", index, Program.MajorColorList[i],Program.MinorColorList[j]);
                  index++;
              }
          }
      }
  }

}
