using System;
using System.Collections.Generic;
using System.Text;

namespace cccsharp
{
    public struct Wheel : /*IComparable*/ IDisposable
    {
        public double radius;
        public double diametr { get => radius * 2; set => radius = value / 2; }
        public Wheel(double radiusP) { radius = radiusP; }
        public void Print() { }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        //public int CompareTo(object obj)
        //{
        //    Wheel b = (Wheel)obj;
        //    //if (b == null) { throw new Exception("object cannot be compare to Wheel"); };
        //    return (int)(radius - b.radius);
        //}
    }
}
