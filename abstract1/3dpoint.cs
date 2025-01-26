using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ABSTRACT1.abstract1
{
    internal class D3point :IComparable<D3point>,ICloneable
    {
        int point1 {  get; set; }
        int point2 { get; set; }
        int point3 {  get; set; }


        public D3point()
        {

        }

        public D3point( int x,int y,int z)
        {
            this.point1 = z;
            this.point2= x;
            this.point3 = y;
        }
        public static bool operator==(D3point a, D3point b)
        {
            if (a.point1==b.point1&&a.point2==b.point2&&a.point3==b.point3) return true;
            return false;
        }
        public static bool operator !=(D3point a, D3point b)
        {
            if (a.point1 != b.point1 && a.point2 != b.point2 && a.point3 != b.point3) return true;
            return false;
        }
        public override string ToString()
        {
            return  $"point1={point1},point2={point2},point3={point3}";
        }

        public int CompareTo(D3point? other)
        {
            return this.point1.CompareTo(other.point1);
            return this.point2.CompareTo(other.point2);
        }

        public object Clone()
        {
            return new D3point()
            {
                point1 = this.point1,
               point2= this.point2,
               point3 = this.point3
            };
        }
    }
}
