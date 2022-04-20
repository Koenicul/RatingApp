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
    public partial class Form1 : Form
    {
        public int rating_p1;
        public int rating_p2;
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

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var diff_score = numericUpDown1.Value - numericUpDown2.Value;

            // Getting the rating from textbox
            rating_p1 = Int32.Parse(textBox1.Text);
            rating_p2 = Int32.Parse(textBox2.Text);

            int rating_diff;

            if (diff_score > 0)
            {
                rating_diff = rating_p1 - rating_p2;
            }
            else
            {
                rating_diff = rating_p2 - rating_p1;
            }

            
            textBox3.Text = rating_diff.ToString();

            var riff_var = rating_lookup.First(x => x.Key.Contains(rating_diff));
            textBox4.Text = riff_var.Value.ToString();

            

            // check who is the winner
            if (diff_score > 0)
            {
                rating_p1 += riff_var.Value;
                rating_p2 -= riff_var.Value;
            }

            else
            {
                rating_p1 -= riff_var.Value;
                rating_p2 += riff_var.Value;
            }

            textBox5.Text = rating_p1.ToString();
            textBox6.Text = rating_p2.ToString();
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
    }
}
