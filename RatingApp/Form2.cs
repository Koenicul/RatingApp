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
    public partial class Form2 : Form
    {
        public int rating_p1;
        public int rating_p2;
        public int rating_p3;
        public Dictionary<Range, int> rating_lookup = new Dictionary<Range, int>()
        {
            { new Range(300, 10000), 0 },
            { new Range(270, 299), 1 },
            { new Range(240, 269), 2 },
            { new Range(210, 239), 2 },
            { new Range(180, 209), 3 },
            { new Range(150, 179), 3 },
            { new Range(120, 149), 4 },
            { new Range(90, 119), 5 },
            { new Range(60, 89), 6 },
            { new Range(30, 59), 7 },
            { new Range(15, 29), 7 },
            { new Range(0, 14), 8 },
            { new Range(-14, 0), 8 },
            { new Range(-29, -15), 9 },
            { new Range(-59, -30), 10 },
            { new Range(-89, -60), 13 },
            { new Range(-119, -90), 17 },
            { new Range(-149, -120), 21 },
            { new Range(-179, -150), 26 },
            { new Range(-209, -180), 32 },
            { new Range(-239, -210), 39 },
            { new Range(-269, -240), 46 },
            { new Range(-299, -270), 55 },
            { new Range(-10000, -300), 63 }
        };

        public Form2()
        {
            InitializeComponent();
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //var l = new Label();
            //l.Text = "hallo";
            //l.Location = new Point(50, 50);

            //this.Controls.Add(l);
            // Getting the rating from textbox
            rating_p1 = Int32.Parse(text_p1.Text);
            rating_p2 = Int32.Parse(text_p2.Text);
            rating_p3 = Int32.Parse(text_p3.Text);

            int game1_rating_diff;
            int game2_rating_diff;
            int game3_rating_diff;

            var game1_diff_score = Game1_P1.Value - Game1_P2.Value;

            if (game1_diff_score > 0)
            {
                game1_rating_diff = rating_p1 - rating_p2;
            }
            else
            {
                game1_rating_diff = rating_p2 - rating_p1;
            }

            var game1_riff_var = rating_lookup.First(x => x.Key.Contains(game1_rating_diff));
          
            // check who is the winner
            if (game1_diff_score > 0)
            {
                rating_p1 += game1_riff_var.Value;
                rating_p2 -= game1_riff_var.Value;
            }

            else
            {
                rating_p1 -= game1_riff_var.Value;
                rating_p2 += game1_riff_var.Value;
            }

            var game2_diff_score = Game2_P2.Value - Game2_P3.Value;

            if (game2_diff_score > 0)
            {
                game2_rating_diff = rating_p2 - rating_p3;
            }
            else
            {
                game2_rating_diff = rating_p3 - rating_p2;
            }

            var game2_riff_var = rating_lookup.First(x => x.Key.Contains(game2_rating_diff));

            // check who is the winner
            if (game2_diff_score > 0)
            {
                rating_p2 += game2_riff_var.Value;
                rating_p3 -= game2_riff_var.Value;
            }

            else
            {
                rating_p2 -= game2_riff_var.Value;
                rating_p3 += game2_riff_var.Value;
            }

            var game3_diff_score = Game3_P1.Value - Game3_P3.Value;

            if (game2_diff_score > 0)
            {
                game3_rating_diff = rating_p1 - rating_p3;
            }
            else
            {
                game3_rating_diff = rating_p3 - rating_p1;
            }

            var game3_riff_var = rating_lookup.First(x => x.Key.Contains(game3_rating_diff));

            // check who is the winner
            if (game3_diff_score > 0)
            {
                rating_p1 += game3_riff_var.Value;
                rating_p3 -= game3_riff_var.Value;
            }

            else
            {
                rating_p1 -= game3_riff_var.Value;
                rating_p3 += game3_riff_var.Value;
            }

            new_p1_rating.Text = rating_p1.ToString();
            new_p2_rating.Text = rating_p2.ToString();
            new_p3_rating.Text = rating_p3.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
