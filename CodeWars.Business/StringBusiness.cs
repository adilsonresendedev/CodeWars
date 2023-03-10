using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Business
{
    public class StringBusiness
    {
        public string Remove_char(string s)
        {
            if (s.Length < 2)
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i < s.Length - 1; i++)
            {
                stringBuilder.Append(s[i].ToString());
            }

            return stringBuilder.ToString();
        }

        public static int FindSmallestInt(int[] args)
        {
            int smallest = 0;
            for (int i = 0; i < args.Count(); i++)
            {
                if (i == 0)
                {
                    smallest = args[i];
                    i++;
                    continue;
                }

                if (args[i] < smallest)
                {
                    smallest = args[i];
                }
                i++;
            }

            return smallest;
        }
    }
}
