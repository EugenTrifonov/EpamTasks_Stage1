namespace Flying.Objects
{
    public abstract class FlyingObject : IFlyable
    {
        public Coordinate CurrentPosition;

        public FlyingObject(Coordinate coordinate)
        {
            CurrentPosition = coordinate;
        }

        public abstract void FlyTo(Coordinate coordinate);
        public abstract double GetFlyTime(Coordinate coordinate);
    }
}