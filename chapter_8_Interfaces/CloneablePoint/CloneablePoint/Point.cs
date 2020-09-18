using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point() { }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }

        public override string ToString() 
            => $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}\n";

        // return a copy of the current object
        //public object Clone() => new Point(this.X, this.Y);
        //or..

        // now to adjust for PointDescription petname member
        public object Clone()
        {
            // first get that shallow copy
            Point newPoint = (Point)this.MemberwiseClone();

            // then fill in the gaps, deepening this shallow clone
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }

    // this class describes a point
    class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }

        public PointDescription() { PetName = "No-Name"; PointID = Guid.NewGuid(); }
    }
}
