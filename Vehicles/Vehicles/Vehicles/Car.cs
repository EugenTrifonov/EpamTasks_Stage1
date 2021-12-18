using System;
using Vehicles.Components;

namespace Vehicles.Vehicles
{
    public class Car : Vehicle
    {
        private int _weight;

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Weight cannot be less or equals 0");
                }
                else
                {
                    _weight = value;
                }
            }
        }

        public Car(Engine engine, Chassis chassis, Transmission transmission, int weight) : base(engine, chassis, transmission)
        {
            Weight = weight;
        }

        /// <summary>
        /// Get full info about the Car
        /// </summary>
        /// <returns></returns>
        public override string GetFullInfo()
        {
            return base.GetFullInfo() + $"\nWeight: {Weight}\n";
        }
    }
}