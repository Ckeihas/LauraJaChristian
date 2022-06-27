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
    }
}
