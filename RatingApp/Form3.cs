using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingApp
{
    public partial class Form3 : Form
    {
        public List<Control> ToBeRemoved = new List<Control>();
        public Dictionary<Range, RatingWeight> rating_lookup = new Dictionary<Range, RatingWeight>()
        {
            { new Range(300, 10000), new RatingWeight(0) },
            { new Range(270, 299), new RatingWeight(1) },
            { new Range(240, 269), new RatingWeight(2) },
            { new Range(210, 239), new RatingWeight(2) },
            { new Range(180, 209), new RatingWeight(3) },
            { new Range(150, 179), new RatingWeight(3) },
            { new Range(120, 149), new RatingWeight(4) },
            { new Range(90, 119), new RatingWeight(5) },
            { new Range(60, 89), new RatingWeight(6) },
            { new Range(30, 59), new RatingWeight(7) },
            { new Range(15, 29), new RatingWeight(7) },
            { new Range(0, 14), new RatingWeight(8) },
            { new Range(-14, 0), new RatingWeight(8) },
            { new Range(-29, -15), new RatingWeight(9) },
            { new Range(-59, -30), new RatingWeight(10) },
            { new Range(-89, -60), new RatingWeight(13) },
            { new Range(-119, -90), new RatingWeight(17) },
            { new Range(-149, -120), new RatingWeight(21) },
            { new Range(-179, -150), new RatingWeight(26) },
            { new Range(-209, -180), new RatingWeight(32) },
            { new Range(-239, -210), new RatingWeight(39) },
            { new Range(-269, -240), new RatingWeight(46) },
            { new Range(-299, -270), new RatingWeight(55) },
            { new Range(-10000, -300), new RatingWeight(63) }
        };

        public Form3()
        {
            InitializeComponent();
            Start();
            UpdatePlayers();
        }

        private void Start()
        {
            var l = ControlFactory.CreateLabel("Players:", new Point(20, 10), 50);
            this.Controls.Add(l);

            var p = ControlFactory.CreateNumericUpDown("players", new Point(70, 10), 30, 7);
            p.Minimum = 2;
            p.ValueChanged += players_ValueChanged;
            this.Controls.Add(p);

            var r = ControlFactory.CreateLabel("R:", new Point(110, 10), 20);
            this.Controls.Add(r);

            var n = ControlFactory.CreateNumericUpDown("r", new Point(130, 10), 30, 5);
            n.ValueChanged += players_ValueChanged;
            this.Controls.Add(n);
        }

        private void players_ValueChanged(object sender, EventArgs e)
        {
            UpdatePlayers();
        }

        public MatchResult check_winner(decimal player_1, decimal player_2)
        {
            decimal result = player_1 - player_2;
            if (result > 0 && player_1 == 3)
            {
                return MatchResult.PlayerOneWin;
            }
            else if (result < 0 && player_2 == 3)
            {
                return MatchResult.PlayerTwoWin;
            }
            return MatchResult.NoResult;          
        }

        private void UpdatePlayers()
        {
            foreach (var control in ToBeRemoved)
            {
                this.Controls.Remove(control);
            }

            Panel matches = ControlFactory.CreatePanel("matches", new Point(200, 40), 350);
            matches.Width = 250;
            matches.BorderStyle = BorderStyle.FixedSingle;
            matches.AutoScroll = true;

            var players = (NumericUpDown)this.Controls.Find("players", true).First();

            for (int i = 0; i < players.Value; i++)
            {
                var l = ControlFactory.CreateLabel($"Player {i + 1}:", new Point(20, i * 30 + 50), 50);
                
                var t = ControlFactory.CreateTextBox("tb_player_" + (i + 1), new Point(80, i * 30 + 50), 35, defaultText: "0");
                t.TextChanged += T_TextChanged;
                t.KeyPress += T_KeyPressed;
                t.LostFocus += delegate(object sender, EventArgs e)
                {
                    var control = (TextBox)sender;
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        control.Text = "0";
                    }
                };

                var r = ControlFactory.CreateTextBox("r_player_" + (i + 1), new Point(120, i * 30 + 50), 35, true, "0");

                ToBeRemoved.Add(l);
                ToBeRemoved.Add(t);
                ToBeRemoved.Add(r);

                this.Controls.Add(l);
                this.Controls.Add(t);
                this.Controls.Add(r);
            }

            var schema = new Schema();

            switch (players.Value)
            {
                case 2:
                    schema = SchemaFactory.TwoPlayers;
                    break;
                case 3:
                    schema = SchemaFactory.ThreePlayers;
                    break;
                case 4:
                    schema = SchemaFactory.FourPlayers;
                    break;
                case 5:
                    schema = SchemaFactory.FivePlayers;
                    break;
                case 6:
                    schema = SchemaFactory.SixPlayers;
                    break;
                case 7:
                    schema = SchemaFactory.SevenPlayers;
                    break;
                default:
                    break;
            }

            var index = 0;

            foreach (var round in schema.Rounds)
            {
                var l2 = ControlFactory.CreateLabel((round.Index + 1).ToString() + ":", new Point(10, index * 30 + 25 * round.Index + 10), 20);
                matches.Controls.Add(l2);

                foreach (var match in round.Matches)
                {
                    var l = ControlFactory.CreateLabel((index + 1) + ": " + match.player_1_index + "-" + match.player_2_index, new Point(50, index * 30 + 25 * round.Index + 10), 50);


                    var n1 = ControlFactory.CreateNumericUpDown("player_" + match.player_1_index + "_match_" + (index + 1), new Point(0, 0), 40, 3);
                    n1.ValueChanged += N_ValueChanged;

                    var n2 = ControlFactory.CreateNumericUpDown("player_" + match.player_2_index + "_match_" + (index + 1), new Point(50, 0), 40, 3);
                    n2.ValueChanged += N_ValueChanged;

                    Panel g = ControlFactory.CreatePanel("group_" + (index + 1), new Point(100, index * 30 + 25 * round.Index + 10), 20);
                    g.Width = 100;

                    g.Controls.Add(n1);
                    g.Controls.Add(n2);

                    ToBeRemoved.Add(l);
                    ToBeRemoved.Add(g);

                    matches.Controls.Add(g);
                    matches.Controls.Add(l);

                    index++;
                }
            }

            ToBeRemoved.Add(matches);
            this.Controls.Add(matches);
        }

        private void T_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void T_TextChanged(object sender, EventArgs e)
        {
            var control = (TextBox)sender;
            var splits = control.Name.Split('_');

            var player_1 = (TextBox)this.Controls.Find("r_player_" + splits[2], true).FirstOrDefault();
            if(player_1 != null)
                player_1.Text = control.Text;  
        }

        private void ResetResults()
        {
            var i = 1;
            var result = (TextBox)this.Controls.Find("r_player_" + i, true).FirstOrDefault();

            while(result != null)
            {
                result.Text = this.Controls.Find("tb_player_" + i, true).First().Text;
                i++;
                result = (TextBox)this.Controls.Find("r_player_" + i, true).FirstOrDefault();
            }
        }

        private void N_ValueChanged(object sender, EventArgs e)
        {
            ResetResults();

            var parent = this.Controls.OfType<Panel>().First();
            var groups = parent.Controls.OfType<Panel>();
            foreach (var group in groups)
            {
                var match_results_1 = (NumericUpDown)group.Controls[0];
                var match_results_2 = (NumericUpDown)group.Controls[1];
                var result = check_winner(match_results_1.Value, match_results_2.Value);
                var player_1_index = match_results_1.Name.Split('_')[1];
                var player_2_index = match_results_2.Name.Split('_')[1];

                var player_1 = (TextBox)this.Controls.Find("r_player_" + player_1_index, true).First();
                var player_2 = (TextBox)this.Controls.Find("r_player_" + player_2_index, true).First();

                if (result == MatchResult.PlayerOneWin)
                {
                    ProcessWinner(player_1, player_2);
                }
                if (result == MatchResult.PlayerTwoWin)
                {
                    ProcessWinner(player_2, player_1);
                }
            }
        }

        private void ProcessWinner(TextBox winner, TextBox loser)
        {
            var r = (NumericUpDown)this.Controls.Find("r", true).First();
            var winnerInt = Int32.Parse(winner.Text);
            var loserInt = Int32.Parse(loser.Text);
            var change = CalculateRatingChange(winnerInt, loserInt);
            var winner_change = change.R1;
            switch (r.Value)
            {
                case 0:
                    winner_change = change.R0;
                    break;
                case 1:
                    winner_change = change.R1;
                    break;
                case 2:
                    winner_change = change.R2;
                    break;
                case 3:
                    winner_change = change.R3;
                    break;
                case 4:
                    winner_change = change.R4;
                    break;
                case 5:
                    winner_change = change.R5;
                    break;
                default:
                    winner_change = change.R1;
                    break;
            }
            var new_rating_player_1 = winnerInt + winner_change;
            winner.Text = new_rating_player_1.ToString();
            var new_rating_player_2 = loserInt - change.R1;
            loser.Text = new_rating_player_2.ToString();
        }

        private RatingWeight CalculateRatingChange(int winner, int loser)
        {
            var diff = winner - loser;
            return rating_lookup.First(x => x.Key.Contains(diff)).Value;
        }
    }
}