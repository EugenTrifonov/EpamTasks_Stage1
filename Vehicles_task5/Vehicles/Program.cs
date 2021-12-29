using System;
using System.Collections.Generic;
using Vehicles.Components;
using Vehicles.Enums;
using Vehicles.Vehicles;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Vehicle NewCar = new Car(
                    new Engine(EngineType.Petrol, 500, 1.7, "5BSDR"),
                    new Chassis(4, 4, 50),
                    new Transmission(TransmissionType.Automatic, 7, "KGD43"),
                    1500);
                Vehicle NewBus = new Bus(
                    new Engine(EngineType.Diesel, 300, 2.5, "A1C83"),
                    new Chassis(4, 4, 50),
                    new Transmission(TransmissionType.Mechanic, 7, "FDBGF4"),
                    60);
                Vehicle NewScooter = new Scooter(
                    new Engine(EngineType.Gas, 200, 1, "H6T23"),
                    new Chassis(4, 4, 50),
                    new Transmission(TransmissionType.Automatic, 7, "GEED4"),
                    150);
                Vehicle NewTruck = new Truck(
                    new Engine(EngineType.Diesel, 350, 2.8, "DS423"),
                    new Chassis(4, 4, 50),
                    new Transmission(TransmissionType.Mechanic, 7, "AXC3"),
                    250);
                List<Vehicle> Vehicles = new List<Vehicle> { NewCar, NewBus, NewScooter, NewTruck };

                Utilities.SerializeVehiclesFullInfoWithVolumeMoreThen(Vehicles, 1.5);
                Utilities.SerializeVehiclesFullInfoGroupByTransmissionType(Vehicles);
                Utilities.SerializeEngineTypeNumberCapacityForTruckBus(Vehicles);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}