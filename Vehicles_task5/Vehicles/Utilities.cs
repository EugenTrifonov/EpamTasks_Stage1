using System;
using System.Collections.Generic;
using System.Linq;
using Vehicles.Vehicles;
using System.Xml.Serialization;
using System.IO;
using Vehicles.Components;

namespace Vehicles
{
    class Utilities
    {
        /// <summary>
        /// Serialize Vehicle full info  to xml if engine capacity>value
        /// </summary>
        /// <param Vehicles list="list"></param>
        /// <param Value="value"></param>
        public static void SerializeVehiclesFullInfoWithVolumeMoreThen(List<Vehicle> list, double value)
        {
            List<string> result = (from i in list
                                   where i.Engine.Capacity > value
                                   select i.GetFullInfo()).ToList();

            XmlSerializer formatter = new XmlSerializer(typeof(List<string>));
            using (FileStream fs = new FileStream("GetVehiclesWithVolumeMoreThen.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, result);
            }
        }

        /// <summary>
        /// Serialize Engine serial number,type,capacity to xml
        /// </summary>
        /// <param Vehicles list="list"></param>
        public static void SerializeEngineTypeNumberCapacityForTruckBus(List<Vehicle> list)
        {
                List<Helper> result = (from i in list
                         where i.GetType() == typeof(Bus) || i.GetType() == typeof(Truck)
                         select new Helper{ Type = i.Engine.Type, SerialNumber = i.Engine.SerialNumber, Capacity = i.Engine.Capacity }).ToList();
            XmlSerializer formatter = new XmlSerializer(typeof(List<Helper>));
            using (FileStream fs = new FileStream("GetEngineTypeNumberCapacityForTruckBus.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, result);
            }

        }
        
        /// <summary>
        /// Serialize Vehicles to xml and group by transmission type
        /// </summary>
        /// <param Vehicles list="list"></param>
        public static void SerializeVehiclesFullInfoGroupByTransmissionType(List<Vehicle> list)
        {
            List<string> result = (from i in list
                                   group i by i.Transmission.Type into groups
                                   from j in groups.ToList()
                                   select j.GetFullInfo()).ToList();
            XmlSerializer formatter = new XmlSerializer(typeof(List <string>));
            using (FileStream fs = new FileStream("GetVehiclesGroupByTransmissionType.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, result);
            }
        }
    }
}