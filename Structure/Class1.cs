using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    struct UInt128  /*IComparable*/ 
    {
        private UInt64 h;
        private UInt64 l;
        
        private void _Add(UInt128 rhs)
        {
            var tl = l;
            l += rhs.l;
            if (l < tl && l < rhs.l)
            {
                h += 1 + rhs.h;
            }
            else
            {
                h += rhs.h;
            }

        }
        private void _Sub(UInt128 rhs)
        {
            var tmp = l;
            l -= rhs.l;
            
            
        }

        public static UInt128 operator +(UInt128 lhs, UInt128 rhs)
        {
            lhs._Add(rhs);
            return lhs;
        }
        public UInt128(ulong value)
        {
            h = 0;
            l = value;
        }
        public UInt128(ulong hP, ulong lP)
        {
            h = hP;
            l = lP;
        }
        public static implicit operator UInt128(ulong value) => new UInt128(value);
        public static explicit operator ulong(UInt128 value) => value.l;
        //public UInt128 CompareTo(object obj)
        //{
        //    UInt128 b = (UInt128) obj;
        //    if(h > b.h)

        //}
    }
}
