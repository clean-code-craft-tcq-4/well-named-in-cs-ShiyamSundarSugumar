using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
  public class Get_Color
  {
     /// <summary>
     /// The function supports only 1 based index. Pair numbers valid are from 1 to 25
     /// </summary>
     internal static Program.ColorPair GetColorFromPairNumber(int pairNumber)
        {           
            int minorSize = Program.MinorColorList.Length;
            int majorSize = Program.MajorColorList.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            
            Program.ColorPair pair = new Program.ColorPair()
            {
                majorColor = Program.MajorColorList[majorIndex],
                minorColor = Program.MinorColorList[minorIndex]
            };

            
            return pair;
        }
        
    }
     
 }
