using System;

namespace Numbersystems
{
    class Program
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
