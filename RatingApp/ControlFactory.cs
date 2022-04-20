using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingApp
{
    public static class ControlFactory
    {
        public static TextBox CreateTextBox(string name, Point point, int width, bool isreadonly = false, string defaultText = "")
        {
            var textBox = new TextBox();
            textBox.Name = name;
            textBox.Location = point;
            textBox.Width = width;
            textBox.ReadOnly = isreadonly;
            textBox.Text = defaultText;
            return textBox;
        }

        public static Label CreateLabel(string text, Point point, int width)
        {
            var label = new Label();
            label.Text = text;
            label.Location = point;
            label.Width = width;
            return label;
        }

        public static NumericUpDown CreateNumericUpDown(string name, Point point, int width, int max)
        {
            var numericUpDown = new NumericUpDown();
            numericUpDown.Name = name;
            numericUpDown.Location = point;
            numericUpDown.Width = width;
            numericUpDown.Maximum = max;
            return numericUpDown;
        }

        public static Panel CreatePanel(string name, Point point, int height)
        {
            Panel panel = new Panel();
            panel.Name = name;
            panel.Location = point;
            panel.Height = height;
            return panel;
        }
    }
}
