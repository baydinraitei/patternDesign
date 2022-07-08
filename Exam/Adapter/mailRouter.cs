using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class mailRouter
    {
        public void send(string email, string corps)
        {
            Console.WriteLine($"--------------------------------------------------------------------------------");
            Console.WriteLine($" | email :  {email} | corps :'{corps}' |");
            Console.WriteLine($"--------------------------------------------------------------------------------");

        }
    }
}
