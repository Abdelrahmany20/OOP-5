using OOP_5.Classes;
using System.Security.Cryptography.X509Certificates;

namespace OOP_5
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            #region First Project

            #region Q01

            //_3D_Point Test = new _3D_Point(3,5,7);
            //Console.WriteLine(Test.point1);


            //_3D_Point Test2 = new _3D_Point();
            //Console.WriteLine(Test2.point2);

            #endregion


            #region Q02

            //_3D_Point Test3 = new _3D_Point(10, 10, 10);

            //Console.WriteLine(Test3.ToString());

            #endregion


            #region Q03
            //-----------------------TryParse -------------------------//


            //double checkCoordinate(string coordinate)
            //{
            //double value;
            //bool isValid;

            //do
            //{

            //Console.Write($"Enter {coordinate}: ");
            //string input = Console.ReadLine();

            //isValid = double.TryParse(input, out value);

            //if (!isValid)
            //{
            //Console.WriteLine("Invalid input !");
            //}
            //} while (!isValid);

            //return value;
            //}


            //-----------------------convert-------------------------//


            //static double checkCoordinate(string coordinateName)
            //{
            //while (true)
            //{
            //try
            //{
            //Console.Write($"Enter {coordinateName}: ");
            //return Convert.ToDouble(Console.ReadLine());
            //}
            //catch
            //{
            //Console.WriteLine("Invalid input");
            //}
            //}

            //}


            //Console.WriteLine("Enter coordinates for Point P1:");
            //double x1 = checkCoordinate("X1");
            //double y1 = checkCoordinate("Y1");
            //double z1 = checkCoordinate("Z1");

            //Console.WriteLine("\nEnter coordinates for Point P2:");
            //double x2 = checkCoordinate("X2");
            //double y2 = checkCoordinate("Y2");
            //double z2 = checkCoordinate("Z2");

            //Console.WriteLine("\nPoints you entered:");
            //Console.WriteLine($"P1: ({x1}, {y1}, {z1})");
            //Console.WriteLine($"P2: ({x2}, {y2}, {z2})");



            #endregion


            #region Q04

            //_3D_Point P1 = new _3D_Point(1, 2, 3);
            //_3D_Point P2 = new _3D_Point(1, 2, 3);


            //if (P1 == P2)
            //Console.WriteLine("P1 and P2 are equal.");
            //else
            //Console.WriteLine("P1 and P2 are not equal.");


            // it doesn't work correctly because == doesn't compare the values put compare the references



            #endregion

            #region Q05
            //_3D_Point[] points =
            //{

            //new _3D_Point (4,5,6) ,
            //new _3D_Point (1,2,3),
            //new _3D_Point (7,8,9)


            //};

            //int result = points[1] .CompareTo (points[2]);
            //Console.WriteLine(result);



            //------------------------------------------------//



            //Array.Sort(points);

            //foreach (_3D_Point point in points)
            //{
            //Console.WriteLine(point);

            //}





            //------------------------------------------------//



            //for (int i = 0; i < points?.Length; i++)


            //{
            //for (int j = 0; j < points?.Length - i - 1; j++)

            //{
            //if (points[j].CompareTo(points[j + 1])==1)
            //{
            //Swap(points[j], points[j + 1])


            //}
            //}

            //}


            //public int CompareTo(Program? other)
            //{
            //throw new NotImplementedException();
            //}

            #endregion


            #region Q06

            //public class _3D_Point : IComparable, ICloneable
            //{


                   //public object Clone()
                  //{
                 //throw new NotImplementedException();
                  //}
            //}

            #endregion

            #endregion
        }


    }
}

