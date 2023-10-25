﻿namespace Övning_2023_10_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Leopold", 6, false, "Indien");
            Hund hund = new Hund();
            Drake drake = new Drake("Barban", 1000, true, 9001);

            Djur[] djur = { tiger, hund, drake };
            foreach (Djur item in djur)
            {
                item.AnimalInfo();
                item.Ljud();
            }


            Console.ReadKey();
        }
    }
}