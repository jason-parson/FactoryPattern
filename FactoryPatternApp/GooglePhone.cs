using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternApp
{
    class GooglePhone : ICallable
    {
        public void Build()
        {
            ConsoleLogging.PhoneBuildDialogue();
            Console.WriteLine("Building an Google phone!");
            Console.WriteLine("Congatulations! Your phone has been completed");
        }
    }
}
