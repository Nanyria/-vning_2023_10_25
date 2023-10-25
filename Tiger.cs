using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2023_10_25
{
    internal class Tiger: Djur
    {
        public string _origin;
        public Tiger(string Name, int Age, bool IfMagical, string Origin): base(Name, Age, IfMagical)
        {
            _origin = Origin;
        }
        public override void Ljud()
        {
            Console.WriteLine("Tigern låter GRRR!");
        }
    }
}
