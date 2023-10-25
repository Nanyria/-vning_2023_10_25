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
        public Tiger(string Name, int Age, bool IfMagical, string Origin) : base(Name, Age, IfMagical)
        {
            _origin = Origin;
        }

        public override void Ljud()
        {
            Console.WriteLine("Tigern låter GRRR!");
        }
        public override void AnimalInfo()
        {
            Console.WriteLine("Tigerns namn är: {0}. \n{0} är {1} år gammal.\n{0} kommer ifrån landet {2}.", _Name, _Age, _origin);
            if(IfMagical)
        }


    }
}
