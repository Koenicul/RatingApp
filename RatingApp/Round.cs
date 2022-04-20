using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingApp
{
    public class Round
    {
        public List<Match> Matches;
        public int Index;

        public Round(int index)
        {
            Matches = new List<Match>();
            Index = index;
        }
    }
}
