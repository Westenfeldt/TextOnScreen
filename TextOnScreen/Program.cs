using System;

namespace TextOnScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            int alder = 16;
            double penge = 2345.35;
            DateTime dt = new DateTime(2020, 7, 20, 9,0,0);

            Console.Write("Jeg er {0} år og har {1} kr. i banken. Jeg går i 9 klasse og er starte på Tec Ballerup den {2}", alder, penge, dt);


        }
    }
}
