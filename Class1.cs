using System;

namespace LauraJaChristianHarkka
{
    public class Class1
    {

        public bool IsFuture(DateTime userInput)
        {
            int result = DateTime.Compare(DateTime.Now, userInput);
            if (result < 0)
                return true;
            else
                return false;
        }

        public void Start(DateTime startDate, double arvio)
        {
            var vertaus = startDate.AddHours(arvio);

            if (vertaus > DateTime.Now)
            {              
                
                Console.WriteLine("Opiskelusi on myöhässä");
            }

            else
            {
                Console.WriteLine("Opiskelusi on aikataulussa");
            }
 
        }

        public void IsLate(DateTime startD, DateTime endD, TimeSpan arvio)
        {
            TimeSpan usedTime = endD - startD;
            Console.WriteLine(usedTime);
            TimeSpan.Compare(usedTime, arvio);

            if (usedTime > arvio)
            {
                Console.WriteLine("Olet aikataulussa");
            }
            
        }
    }
}
