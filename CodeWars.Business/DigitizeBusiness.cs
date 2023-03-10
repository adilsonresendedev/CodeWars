using System;
using System.Collections.Generic;

namespace CodeWars.Business
{
    public class DigitizeBusiness
    {
        public long[] Digitize(long n)
        {
            string numberString = n.ToString();
            List<long> result = new List<long>();
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                result.Add(Convert.ToInt64(numberString[i].ToString()));
            }

            return result.ToArray();
        }
    }
}
