using System;

namespace NumberSystems
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Numbers.ConvertNumber(args));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}