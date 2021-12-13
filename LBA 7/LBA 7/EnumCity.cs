using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBA_7
{
    class EnumCity
    {
        static void Main()
        {
            var values = Enum.GetValues(typeof(PinCodes));
            foreach (var value in values)
            {
                Console.WriteLine($"{value}={value.GetHashCode()}");
            }
            Console.ReadLine();
        }
    }

    enum PinCodes
    {
        Kolkata = 700027, Delhi = 700024, Mumbai = 700029, Noida = 700037, Madurai = 700012, Pune = 700028
    }
}
