namespace Övning_2023_10_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Leopold", 6, false, "Indien");
            Hund hund = new Hund("Ozzy", 12, false, "köttbullar");
            Drake drake = new Drake();

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