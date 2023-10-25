using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2023_10_25
{
    internal class Hund : Djur
    {
        public string _favoritmat;
        public Hund(string Name, int Age, bool IfMagical, string favoritmat) : base(Name, Age, IfMagical)
        {
            _favoritmat = favoritmat;
        }

        public override void Ljud()
        {
            Console.WriteLine("Hunden skäller.");
        }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"Hundens namn är: {_Name}\nÅlder: {_Age}\nFavoritmat: {_favoritmat}");
        }
    }
}
