using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingApp
{
    public static class SchemaFactory
    {
        public static Schema TwoPlayers = new Schema()
        {
            Rounds = new List<Round>()
            {
                new Round(0)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,2)
                    }
                }
            }
        };

        public static Schema ThreePlayers = new Schema()
        {
            Rounds = new List<Round>()
            {
                new Round(0)
                {
                    Matches = new List<Match>()
                    {
                        new Match(2,3),
                    }
                },
                new Round(1)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,3),
                    }
                },
                new Round(2)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,2),
                    }
                }
            }
            
        };

        public static Schema FourPlayers = new Schema()
        {
            Rounds = new List<Round>()
            {
                new Round(0)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,4),
                        new Match(2,3)
                    }
                },
                new Round(1)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,3),
                        new Match(2,4)
                    }
                },
                new Round(2)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,2),
                        new Match(3,4)
                    }
                }
            }
        };

        public static Schema FivePlayers = new Schema()
        {
            Rounds = new List<Round>()
            {
                new Round(0)
                {
                    Matches = new List<Match>()
                    {
                        new Match(2,5),
                        new Match(3,4)
                    }
                },
                new Round(1)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,5),
                        new Match(2,4)
                    }
                },
                new Round(2)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,4),
                        new Match(2,3)
                    }
                },
                new Round(3)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,3),
                        new Match(4,5)
                    }
                },
                new Round(4)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,2),
                        new Match(3,5)
                    }
                }
            }
        };

        public static Schema SixPlayers = new Schema()
        {
            Rounds = new List<Round>()
            {
                new Round(0)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,6),
                        new Match(2,5),
                        new Match(3,4)
                    }
                },
                new Round(1)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,5),
                        new Match(2,4),
                        new Match(3,6)
                    }
                },
                new Round(2)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,4),
                        new Match(2,3),
                        new Match(5,6)
                    }
                },
                new Round(3)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,3),
                        new Match(2,6),
                        new Match(4,5)
                    }
                },
                new Round(4)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,2),
                        new Match(3,5),
                        new Match(4,6)
                    }
                }
            }
        };

        public static Schema SevenPlayers = new Schema()
        {
            Rounds = new List<Round>()
            {
                new Round(0)
                {
                    Matches = new List<Match>()
                    {
                        new Match(2,7),
                        new Match(3,6),
                        new Match(4,5)
                    }
                },
                new Round(1)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,7),
                        new Match(3,5),
                        new Match(4,6)
                    }
                },
                new Round(2)
                {
                    Matches = new List<Match>()
                    {
                        new Match(2,5),
                        new Match(1,6),
                        new Match(4,7)
                    }
                },
                new Round(3)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,5),
                        new Match(2,6),
                        new Match(3,7)
                    }
                },
                new Round(4)
                {
                    Matches = new List<Match>()
                    {
                        new Match(1,4),
                        new Match(6,7),
                        new Match(2,3)
                    }
                },
                new Round(5)
                {
                    Matches = new List<Match>()
                    {
                        new Match(5,7),
                        new Match(2,4),
                        new Match(1,3)
                    }
                },
                new Round(6)
                {
                    Matches = new List<Match>()
                    {
                        new Match(5,6),
                        new Match(3,4),
                        new Match(1,2)
                    }
                }
            }
        };
    }
}
