namespace Flying.Objects
{
    public class AirPlane : FlyingObject
    {
        private const int StartSpeed = 200;
        private const int Acceleration = 10;
        private const int AccelerationDistance = 10;

        public AirPlane(Coordinate coordinate) : base(coordinate) { }

        /// <summary>
        /// Change current coordinate to the new
        /// </summary>
        /// <param New coordinate="coordinate"></param>
        public override void FlyTo(Coordinate coordinate)
        {
            CurrentPosition = coordinate;
        }

        /// <summary>
        /// Get fly time of airplane in hours
        /// </summary>
        /// <param New coordinate="coordinate"></param>
        /// <returns></returns>
        public override double GetFlyTime(Coordinate coordinate)
        {
            int currentSpeed = StartSpeed;
            double distance = CurrentPosition.GetDistance(coordinate);
            double time = 0;

            while (distance >= 10)
            {
                distance -= AccelerationDistance;
                time += (double)AccelerationDistance / currentSpeed;
                currentSpeed += Acceleration;
            }

            time += distance / currentSpeed;
            
            return time;
        }
    }
}