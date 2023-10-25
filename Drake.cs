using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2023_10_25
{
    internal class Drake : Djur
    {
        int _powerLevel;
        public Drake(string Name, int Age, bool IfMagical, int PowerLevel) : base(Name, Age, IfMagical)
        {
            this._powerLevel = PowerLevel;
        }
        public override void Ljud()
        {
            Console.WriteLine("BRRRRRRRR\n");
        }
        public override void AnimalInfo()
        {
            Console.WriteLine($"Draken heter {_Name} och är {_Age} år gammal.\nPowerlevel: {_powerLevel}.");
            base.AnimalInfo();
        }
    }
}
