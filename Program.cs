using System;

namespace Exercise_Metoder
{
    class Program
    {

        static bool bla = true;
        static void Main(string[] args)
        {

            while (bla)
            {
                try
                {
                    Console.Write("Skriv ett pris: ");

                    int userInput = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Skriv vad momsen ligger på i procent: ");
                    double moms = Convert.ToDouble(Console.ReadLine());
                    moms *= 0.01;
                    if (moms < 0)
                    {
                        moms = Math.Max(0, moms);
                    }

                    CountMoms(userInput, moms);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Skriv bara siffrorna!");
                }

            }

        }

        static void CountMoms(int value, double moms)
        {

            double medMoms = value * (moms + 1);
            double utanMoms = value * moms;

            Console.WriteLine("Momsen är: " + utanMoms);
            Console.WriteLine("Priset med moms blir: " + medMoms);

            bla = false;

        }
    }
}
