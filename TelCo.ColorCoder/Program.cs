﻿using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair wiring for telecommunications.
    /// This class provides the color coding and mapping of pair number to color and color to pair number.
    /// </summary>
    public class Program
    {
        internal static Color[] MajorColorList;
        internal static Color[] MinorColorList;
        /// <summary>
        /// data type defined to hold the two colors of clor pair
        /// </summary>
        internal class ColorPair
        {
            internal Color majorColor,minorColor;
            public override string ToString()
            {
                return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            }
        }
        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static Program()
        {
            MajorColorList = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            MinorColorList = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Print_Manual.Table();
            Main_Test_case.Test_case();
        }
    }
}
