using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2023_10_25
{
    internal class Djur
    {
        public string _Name;
        public int _Age;
        public bool _IfMagical;

        public Djur(string Name, int Age, bool IfMagical)
        {
            _Name = Name;
            _Age = Age;
            _IfMagical = IfMagical;
        }
        public virtual void Ljud()
        {

        }
        public virtual void AnimalInfo()
        {
            if (_IfMagical)
            {
                Console.WriteLine("Djuret är magiskt! Woooh!\n");
            }
            else
            {
                Console.WriteLine("Djuret är inte magiskt.\n");
            }

        }
    }
}
