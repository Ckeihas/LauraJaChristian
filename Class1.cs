using System;

namespace LauraJaChristianHarkka
{
    public class Class1
    {
        public static void Paivamaara()
        {
            bool tulevaisuudessa = true;

            Console.WriteLine("Kirjoita pvm: ");
            DateTime vastaus = Convert.ToDateTime(Console.ReadLine());

            if (vastaus > DateTime.Now)
            {
                tulevaisuudessa = true;
            }
            else
            {
                tulevaisuudessa = false;
            }

        }
    }
}
