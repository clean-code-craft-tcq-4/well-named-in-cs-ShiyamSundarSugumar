using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
  public class Get_Color
  {
     internal static Program.ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = Program.MinorColorList.Length;
            int majorSize = Program.MajorColorList.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            Program.ColorPair pair = new Program.ColorPair()
            {
                majorColor = Program.MajorColorList[majorIndex],
                minorColor = Program.MinorColorList[minorIndex]
            };

            // return the value
            return pair;
        }
        
    }
     
 }
