using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInit
{
    enum PointColor
    { LightBlue, BloodRed, Gold}

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color{ get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Color = PointColor.Gold;
        }
        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }
        public Point()
            :this(PointColor.BloodRed){}

        public void DisplayStats()
        {
            Console.WriteLine($"[{X}, {Y}]");
        }
    }
}
