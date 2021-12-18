using System;
using Vehicles.Enums;

namespace Vehicles.Components
{
    [Serializable]
    public class Transmission
    {
        private int _numberOfGears;
        private string _manufacturer;

        public TransmissionType Type { get; set; }

        public int NumberOfGears
        {
            get
            {
                return _numberOfGears;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception(" The number of gears can't be less then 1");
                }
                else
                {
                    _numberOfGears = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("MaxLoad can't be less or equals 0");
                }
                else
                {
                    _manufacturer = value;
                }
            }
        }

        public Transmission() { }

        public Transmission(TransmissionType type, int numberOfGears, string manufacturer)
        {
            Type = type;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        public string GetFullInfo()
        {
            return $"Transmisssion: Type:{Type} Number of gears:{NumberOfGears} Manufacturer:{Manufacturer}";
        }
    }
}