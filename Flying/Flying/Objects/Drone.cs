using System;

namespace Flying.Objects
{
    public class Drone : FlyingObject
    {
        private const double StopTime = (double)1 / 60;
        private const double StopPeriod = (double)1 / 6;
        private const double MaxDistance = 2000;
        private int _speed;

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Speed can't be less then 0");
                }
                _speed = value;
            }
        }

        public Drone(Coordinate coordinate, int speed) : base(coordinate)
        {
            Speed = speed;
        }

        /// <summary>
        /// Change current coordinate to the new
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
                throw new Exception("Too far for drone");
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
                throw new Exception("Too far for drone");
            }

            double distance = CurrentPosition.GetDistance(coordinate);
            double time = 0;

            while (distance > 0)
            {
                distance -= StopPeriod * Speed;
                time += StopPeriod + StopTime;
            }

            return time;
        }

        /// <summary>
        /// Check possibility to fly
        /// </summary>
        /// <param New coordinate="coordinate"></param>
        /// <returns></returns>
        public bool CheckPossibilityToFly(Coordinate coordinate)
        {
            return CurrentPosition.GetDistance(coordinate) <= MaxDistance;
        }
    }
}