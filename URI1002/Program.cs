using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    using System;

    namespace URI
    {
        class Program
        {
            static void Main(string[] args)
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                double R, A, pi = 3.14159;

                R = double.Parse(Console.ReadLine(), CI);

                A = pi * R * R;

                Console.WriteLine("A=" + A.ToString("F4", CI));
            }
        }
    }
}