using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР8
{
    public partial class Form2 : Form
    {
        public Color colorResult, clr;
        Form1 main;
        public Form2()
        {
            InitializeComponent();

            Scroll_Red.Tag = numeric_Red;
            Scroll_Green.Tag = numeric_Green;
            Scroll_Blue.Tag = numeric_Blue;

            numeric_Red.Tag = Scroll_Red;
            numeric_Green.Tag = Scroll_Green;
            numeric_Blue.Tag = Scroll_Blue;
        }

        private void Scroll_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }

        private void UpdateColor()
        {
            colorResult = Color.FromArgb(Scroll_Red.Value, Scroll_Green.Value, Scroll_Blue.Value);
            picResultColor.BackColor = colorResult;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Scroll_Red.Value = colorDialog.Color.R;
                Scroll_Green.Value = colorDialog.Color.G;
                Scroll_Blue.Value = colorDialog.Color.B;
                UpdateColor();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.currentPen.Color = colorResult;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            main = Owner as Form1;

            clr = colorResult;

            Scroll_Red.Value = clr.R;
            Scroll_Green.Value = clr.G;
            Scroll_Blue.Value = clr.B;

            UpdateColor();
        }
    }
}
