using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302210113
{
    public class HaloGeneric
    {
        public static void sapaUser<T>(T X)
        {
            Console.WriteLine("Hallo user " + X);
        }

    }
}
