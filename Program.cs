namespace Övning_2023_10_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Leopold", 6, false, "Indien");
            Hund hund = new Hund();
            Drake drake = new Drake();

            Djur[] djur = { tiger, hund, drake };
            foreach (Djur item in djur) 
            {
                item.Ljud();
                item.AnimalInfo();
            }


            Console.ReadKey();
        }
    }
}