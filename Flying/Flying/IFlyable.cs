namespace Flying
{
     public interface IFlyable
    {
        public void FlyTo(Coordinate coordinate);
        public double GetFlyTime(Coordinate coordinate);
    }
}