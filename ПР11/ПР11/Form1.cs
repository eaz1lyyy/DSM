using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР11
{
    public partial class Form1 : Form
    {
        private Bitmap[] Frames;
        private int FrameNum = 0;

        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = timer1.Interval;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frames = new Bitmap[18];
            for (int i = 0; i < 18; i++)
            {
                Frames[i] = new Bitmap("Frame" + i + ".png");
            }
            picFrame.Image = Frames[FrameNum];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrameNum = ++FrameNum % Frames.Length;
            picFrame.Image = Frames[FrameNum];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled) button1.Text = "Stop";
            else button1.Text = "Start";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }
    }      
}   
