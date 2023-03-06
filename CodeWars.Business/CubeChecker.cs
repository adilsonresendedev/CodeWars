using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Business
{
    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            int powValue = 3;
            bool result;

            if (volume <= 0 || side <= 0)
            {
                result = false;
                return result;
            }

            double expectedVolume = Math.Pow(side, powValue);
            result = volume == expectedVolume;

            return result;
        }
    }
}
