using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5.Classes
{
    public class Duration
    {


        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }



        public Duration(int hours = 0, int minutes = 0, int seconds = 0) //constructor1
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            return $"Hours : {Hours} , Minutes : {Minutes} , Seconds : {Seconds}  ";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //1-
        public static Duration operator +(Duration left, Duration right)
        {

            return new Duration
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds

            };

        }





        //2-
        public static Duration operator +(Duration d1, int seconds)
        {


            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + seconds;

            return new Duration(totalSeconds);


        }



        //3-

        public static Duration operator +(int seconds, Duration d1)
        {


            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + seconds;

            return new Duration(totalSeconds);

        }



        //4-    

        public static Duration operator ++(Duration dd)
        {
            return new Duration
            {
                Hours = dd.Hours,
                Minutes = dd.Minutes + 1,
                Seconds = dd.Seconds


            };


        }


        //5-
        public static Duration operator --(Duration dd)
        {
            return new Duration
            {
                Hours = dd.Hours,
                Minutes = dd.Minutes - 1, 
                Seconds = dd.Seconds


            };


        }

        //6-
        public static Duration operator -(Duration left, Duration right)
        {

            return new Duration
            {
                Hours = left.Hours - right.Hours,
                Minutes = left.Minutes - right.Minutes,
                Seconds = left.Seconds - right.Seconds

            };

        }



        //7 & 8-

        public static bool operator >(Duration Left, Duration Right)
        {
            if (Left?.Hours == Right?.Hours)
                return (Left?.Seconds > Right?.Seconds);
            else
                return (Left?.Hours > Right?.Hours);
        }

        public static bool operator <(Duration Left, Duration Right)
        {
            if (Left?.Hours == Right?.Hours)
                return (Left?.Seconds > Right?.Seconds);
            else
                return (Left?.Hours < Right?.Hours);
        }

        //9-
        public static  explicit operator DateTime (Duration D)

        {

            return new DateTime( D.Hours  , D.Minutes , D.Seconds);
        }

    }
}

