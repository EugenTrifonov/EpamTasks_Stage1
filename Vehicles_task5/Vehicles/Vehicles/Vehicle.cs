using System;
using System.Xml.Serialization;
using Vehicles.Components;

namespace Vehicles.Vehicles
{
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Scooter))]
    [XmlInclude(typeof(Truck))]
    [Serializable]
    public abstract class Vehicle
    {
        public Engine Engine { get; set; }

        public Transmission Transmission { get; set; }

        public Chassis Chassis { get; set; }

        public Vehicle() { }

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine ?? throw new Exception("The vehicle needs an engine");
            Chassis = chassis ?? throw new Exception("The vehicle needs a chassis"); ;
            Transmission = transmission ?? throw new Exception("The vehicle needs a transmission"); ;
        }

        /// <summary>
        /// Get full info about the Vehicle
        /// </summary>
        /// <returns></returns>
        public virtual string GetFullInfo()
        {
            return $"{Engine.GetFullInfo()}\n {Chassis.GetFullInfo()}\n {Transmission.GetFullInfo()}";
        }

    }
}
