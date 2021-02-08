using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.MobileApp.Helpers
{
    public class GenerateOrderNumber
    {
        public static string GenerateNumber(int currentNumber)
        {
            string newNumber = "N";

            if(currentNumber < 10)
            {
                newNumber += "00" + currentNumber;
            }
            else if (currentNumber<100 && currentNumber > 9)
            {
                newNumber += "0" + currentNumber;
            }
            else
            {
                newNumber += currentNumber;
            }

            return newNumber;
        }
    }
}
