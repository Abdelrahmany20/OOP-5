using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5.Classes
{
    public class _3D_Point : IComparable ,ICloneable
    {

        public double point1 { get; set; }
        public double point2 { get; set; }
        public double point3 { get; set; }




        public _3D_Point (double x=0, double y=0, double z=0)
        {
            point1 = x;
            point2 = y;
            point3 = z;


        }



        public override string ToString()
        {
            return $"Point Coordinates: ({point1}, {point2}, {point3})";
        }

        public int CompareTo(object? obj)
        {

            _3D_Point passedpoint = (_3D_Point)obj;
            if(this.point1 > passedpoint.point1)
                return 1;
            else if(this.point2 > passedpoint.point2)
                return -1;
            else return 0;
            
        }


        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
} 
