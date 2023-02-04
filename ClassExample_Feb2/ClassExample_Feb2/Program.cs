using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Feb2
{
    internal class Program
    {
        string vehicleName = "Benz";
        string vehicleColor = "Black";
        string vehicleNo = "KA03676";

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.vehicleName);
            Console.WriteLine(program.vehicleColor);
            Console.WriteLine(program.vehicleNo);

        }
    }
}
