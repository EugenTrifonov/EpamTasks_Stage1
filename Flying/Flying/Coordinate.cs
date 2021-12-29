using System;

namespace Flying
{
    public struct Coordinate
    {
        private double _x;
        private double _y;
        private double _z;

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("X can't be less then 0");
                }
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Y can't be less then 0");
                }
                _y = value;
            }
        }

        public double Z
        {
            get
            {
                return _z;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Z can't be less then 0");
                }
                _z = value;
            }
        }

        public Coordinate(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public double GetDistance(Coordinate coordinate)
        {
            int degree = 2;

            return Math.Sqrt(
                   Math.Pow(coordinate.X - X, degree) +
                   Math.Pow(coordinate.Y - Y, degree) +
                   Math.Pow(coordinate.Z - Z, degree));
        }
    }
}