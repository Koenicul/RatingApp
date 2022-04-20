using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingApp
{
    public class Match
    {
        public int player_1_index;
        public int player_2_index;
        public MatchResult result;
        public Match(int PlayerOne, int PlayerTwo)
        {
            player_1_index = PlayerOne;
            player_2_index = PlayerTwo;
            result = MatchResult.NoResult;
        }
    }
}
