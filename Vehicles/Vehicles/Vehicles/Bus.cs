using System;
using Vehicles.Components;

namespace Vehicles.Vehicles
{
    public class Bus : Vehicle
    {
        private int _numberOfSeats;

        public int NumberOfSeats
        {
            get
            {
                return _numberOfSeats;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("NumberOfSeats cannot be less or equals 0");
                }
                else
                {
                    _numberOfSeats = value;
                }
            }
        }

        public Bus(Engine engine, Chassis chassis, Transmission transmission, int numberOfSeats) : base(engine, chassis, transmission)
        {
            NumberOfSeats = numberOfSeats;
        }

        /// <summary>
        /// Get full info about the Bus
        /// </summary>
        /// <returns></returns>
        public override string GetFullInfo() => base.GetFullInfo() + $"\nNumberOfSeats: {NumberOfSeats}\n";
    }
}