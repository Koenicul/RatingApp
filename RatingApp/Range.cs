using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingApp
{
    public class Range
    {
        public int Lower;
        public int Upper;

        public Range(int lower, int upper)
        {
            Lower = lower;
            Upper = upper;
        }

        public bool Contains(int number)
        {
            if (number >= Lower && number <= Upper)
            {
                return true;
            }

            return false;
        }
    }
}
