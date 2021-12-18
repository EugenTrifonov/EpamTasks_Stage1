using Flying.Objects;
using System;
using System.Collections.Generic;

namespace Flying
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Coordinate A = new Coordinate(2, 4, 3);
                Coordinate B = new Coordinate(2, 4, 2003);
                IFlyable dron = new Drone(A, 100);
                IFlyable airplane = new AirPlane(A);
                IFlyable bird = new Bird(A);
                List<IFlyable> ObjList = new List<IFlyable> { bird, dron, airplane };

                foreach (IFlyable i in ObjList)
                {
                    Console.WriteLine(i.GetFlyTime(B));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }
    }
}
