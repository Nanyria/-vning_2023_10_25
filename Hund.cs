using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2023_10_25
{
    internal class Hund : Djur
    {
        public override void Ljud()
        {
            Console.WriteLine("Hunden skäller.");
        }
    }
}
