using System;
using System.Text;

namespace NumberSystems
{
    public class Numbers
    {
        private const int LeftEdge = 2;
        private const int RightEdge = 20;
        private static int Value;
        private static int BaseOfNumberSystem;

        /// <summary>
        /// Convert number to the new number system
        /// </summary>
        /// <param Input arguments="args"></param>
        /// <returns></returns>
        public static string ConvertNumber(string[] args)
        {
            StringBuilder ConvertedNumber = new StringBuilder(String.Empty);

            if (CheckInput(args))
            {
                if (Value == 0)
                {
                    return ("0");
                }

                int result;
                int number = Value;
                while (number != 0)
                {
                    result = number % BaseOfNumberSystem;
                    number = number / BaseOfNumberSystem;

                    if (result > 9)
                    {
                        ConvertedNumber.Insert(0, (char)(result + 55));
                    }
                    else
                    {
                        ConvertedNumber.Insert(0, result);
                    }
                }
            }

            return ConvertedNumber.ToString();
        }

        /// <summary>
        /// Check input arguments
        /// </summary>
        /// <param Input arguments="args"></param>
        /// <returns></returns>
        private static bool CheckInput(string[] args)
        {
            bool result = true;

            if (args.Length < 2)
            {
                throw new Exception("Not enough arguments");
            }

            Value = Convert.ToInt32(args[0]);
            BaseOfNumberSystem = Convert.ToInt32(args[1]);

            if (args.Length > 2)
            {
                throw new Exception("Too much arguments");
            }

            if (BaseOfNumberSystem < LeftEdge || BaseOfNumberSystem > RightEdge)
            {
                throw new Exception($"Base of new number system should be in range {LeftEdge}-{RightEdge}");
            }

            if (Value < 0)
            {
                throw new Exception("The number should be positive");
            }

            return result;
        }
    }
}