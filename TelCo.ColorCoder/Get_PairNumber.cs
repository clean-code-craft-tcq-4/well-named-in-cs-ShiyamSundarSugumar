using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
  public class Get_PairNumber
  {
      internal static int GetPairNumberFromColor(Program.ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < Program.MajorColorList.Length; i++)
            {
                if (Program.MajorColorList[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < Program.MinorColorList.Length; i++)
            {
                if (Program.MinorColorList[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * Program.MinorColorList.Length) + (minorIndex + 1);
        }
        
     }
     
 }

    
