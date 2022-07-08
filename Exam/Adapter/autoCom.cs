using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class autoCom
    {
        public void send(string num, string corps)
        {
              Console.WriteLine($"--------------------------------------------------------------------------------");
            Console.WriteLine($" | numéro :  {num} | corps :'{corps}' |");
            Console.WriteLine($"--------------------------------------------------------------------------------");

        }
    }
}
