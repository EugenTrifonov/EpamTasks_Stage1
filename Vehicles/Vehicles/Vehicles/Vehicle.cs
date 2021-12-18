using System;
using Vehicles.Components;

namespace Vehicles.Vehicles
{
    public abstract class Vehicle
    {
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Chassis Chassis { get; set; }

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine ?? throw new Exception("The vehicle needs an engine");
            Chassis = chassis ?? throw new Exception("The vehicle needs a chassis"); ;
            Transmission = transmission ?? throw new Exception("The vehicle needs a transmission"); ;
        }

        public virtual string GetFullInfo()
        {
            return $"{Engine.GetFullInfo()}\n {Chassis.GetFullInfo()}\n {Transmission.GetFullInfo()}";
        }
    }
}