using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Business
{
    public class BetterThanAverageBusiness
    {
        public bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            decimal median = 0;
            int scoreCount = ClassPoints.Count();

            foreach (int i in ClassPoints)
            {
                median += i;
            }

            if (scoreCount == 0)
            {
                median = 0;
            }
            else
            {
                median = median / scoreCount;
            }

            return YourPoints > median;
        }
    }
}
