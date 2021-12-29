using System;
using Vehicles.Components;

namespace Vehicles.Vehicles
{
    public class Scooter : Vehicle
    {
        private int _maxSpeed;

        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("MaxSpeed can't be less or equals 0");
                }
                else
                {
                    _maxSpeed = value;
                }
            }
        }

        public Scooter(Engine engine, Chassis chassis, Transmission transmission, int maxSpeed) : base(engine, chassis, transmission)
        {
            MaxSpeed = maxSpeed;
        }

        /// <summary>
        /// Get full info about the Scooter
        /// </summary>
        /// <returns></returns>
        public override string GetFullInfo() => base.GetFullInfo() + $"\nMaxSpeed: {MaxSpeed}\n";
    }
}