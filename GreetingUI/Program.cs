using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingUX ui = new GreetingUX();
            ui.Seed();
            ui.Run();

        }
    }
}
