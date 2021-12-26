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
                    new Engine(EngineType.Petrol, 500, 5, "AB123"),
                    new Chassis(4, 4, 50),
                    new Transmission(TransmissionType.Automatic, 7, "ABC"),
                    1500);
                Vehicle NewBus = new Bus(
                    new Engine(EngineType.Petrol, 500, 5, "AB483"),
                    new Chassis(4, 4, 50),
                    new Transmission(TransmissionType.Automatic, 7, "BAC"),
                    60);
                Vehicle NewScooter = new Scooter(
                    new Engine(EngineType.Petrol, 500, 5, "AB123"),
                    new Chassis(4, 4, 50),
                    new Transmission(TransmissionType.Automatic, 7, "CAB"),
                    150);
                Vehicle NewTruck = new Truck(
                    new Engine(EngineType.Diesel, 500, 5, "AB123"),
                    new Chassis(4, 4, 50),
                    new Transmission(TransmissionType.Automatic, 7, "ABC"),
                    250);

                List<Vehicle> VehicleList = new List<Vehicle> { NewCar, NewBus, NewScooter, NewTruck };

                foreach (Vehicle vehicle in VehicleList)
                {
                    Console.WriteLine(Convert.ToString(vehicle) + "\n" + vehicle.GetFullInfo());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}