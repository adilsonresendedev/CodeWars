using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Business
{
    public class SmallestBusiness
    {
        public int FindSmallestInt(int[] args)
        {
            int smallest = 0;
            for (int i = 0; i < args.Count(); i++)
            {
                if (i == 0)
                {
                    smallest = args[i];
                    continue;
                }

                if (args[i] < smallest)
                {
                    smallest = args[i];
                }
            }

            return smallest;
        }
    }
}
