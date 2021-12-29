using Flying.Objects;
using System;

namespace Flying
{
    public class Bird : FlyingObject
    {
        private double _speed;
        private const double MaxDistance = 3000;

        public double Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Speed can't be negative");
                }
                _speed = value;
            }
        }

        public Bird(Coordinate coordinate) : base(coordinate)
        {
            Speed = new Random().Next(0, 20);
        }

        /// <summary>
        /// Change coordinate to the new
        /// </summary>
        /// <param New coordinate="coordinate"></param>
        public override void FlyTo(Coordinate coordinate)
        {
            if (CheckPossibilityToFly(coordinate))
            {
                CurrentPosition = coordinate;
            }
            else
            {
                throw new Exception("Unreachable conditions");
            }
        }

        /// <summary>
        /// Get fly time in hours
        /// </summary>
        /// <param New coordinate="coordinate"></param>
        /// <returns></returns>
        public override double GetFlyTime(Coordinate coordinate)
        {
            if (!CheckPossibilityToFly(coordinate))
            {
                throw new Exception("Unreachable conditions");
            }

            double distance = CurrentPosition.GetDistance(coordinate);

            if (distance > MaxDistance)
            {
                throw new Exception("Too far distance for Bird");
            }

            return distance / Speed;
        }

        /// <summary>
        /// Check possibility to change coordinate
        /// </summary>
        /// <param New coordinate="coordinate"></param>
        /// <returns></returns>
        public bool CheckPossibilityToFly(Coordinate coordinate)
        {
            if (Speed > 0)
            {
                return CurrentPosition.GetDistance(coordinate) <= MaxDistance;
            }

            return false;
        }
    }
}