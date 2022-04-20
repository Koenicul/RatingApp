using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingApp
{
    public class RatingWeight
    {
        public int R0;
        public int R1;
        public int R2;
        public int R3;
        public int R4;
        public int R5;

        public RatingWeight(int initial)
        {
            R0 = (int)Math.Round(initial * 0.5, 0, MidpointRounding.AwayFromZero);
            R1 = initial;
            R2 = initial == 0 ? 1 : (int)Math.Round(initial * 1.25, 0, MidpointRounding.AwayFromZero);
            R3 = initial == 0 ? 1 : (int)Math.Round(initial * 1.5, 0, MidpointRounding.AwayFromZero);
            R4 = initial == 0 ? 1 : (int)Math.Round(initial * 1.75, 0, MidpointRounding.AwayFromZero);
            R5 = initial == 0 ? 1 : initial * 2;
        }
    }
}
