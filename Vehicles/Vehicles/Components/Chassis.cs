﻿using System;

namespace Vehicles.Components
{
    public class Chassis
    {
        private int _number;
        private int _numberOfWheels;
        private double _maxLoad;

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Number can't be less or equals 0");
                }
                else
                {
                    _number = value;
                }
            }
        }

        public int NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("NumberOfWheels can't be less then 1");
                }
                else
                {
                    _numberOfWheels = value;
                }
            }
        }

        public double MaxLoad
        {
            get
            {
                return _maxLoad;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("MaxLoad can't be less or equals 0");
                }
                else
                {
                    _maxLoad = value;
                }
            }
        }

        public Chassis(int number, int numberOfWheels, int maxLoad)
        {
            Number = number;
            NumberOfWheels = numberOfWheels;
            MaxLoad = maxLoad;
        }

        /// <summary>
        /// Get full info about the Chassis
        /// </summary>
        /// <returns></returns>
        public string GetFullInfo() => $"Chassis: Number of wheels:{NumberOfWheels} Number:{Number} Max load:{MaxLoad}";
    }
}