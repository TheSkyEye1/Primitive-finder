using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.CV.Structure;


namespace lab4
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> sourceImage;
        Image<Bgr, byte> notresizedImage;
        Filter_c fil = new Filter_c();
        int[] kf1 = new int[3] { 1, 3, 5 };
        int mode = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            notresizedImage = fil.loadfunction(notresizedImage);
            if (notresizedImage != null)
            {
                sourceImage = notresizedImage.Resize(640, 480, Inter.Linear);
                IMG1.Image = sourceImage;
                IMG2.Image = sourceImage;
            }
        }

        private void blurb_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.blur(sourceImage, kf1[trb1.Value], trb2.Value);
        }

        private void trb1_ValueChanged(object sender, EventArgs e)
        {
            lb1.Text = Convert.ToString(kf1[trb1.Value]);
        }

        private void trb2_ValueChanged(object sender, EventArgs e)
        {
            lb2.Text = Convert.ToString(trb2.Value);
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.findedges(sourceImage, kf1[trb1.Value], trb2.Value, trb3.Value);
        }

        private void trb3_ValueChanged(object sender, EventArgs e)
        {
            lb3.Text = Convert.ToString(trb3.Value);
        }

        private void finderbutton_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                IMG2.Image = fil.findtriangles(sourceImage, kf1[trb1.Value], trb2.Value, trb3.Value, trb4.Value * 10);
            }
            if (mode == 1)
            {
                IMG2.Image = fil.findrectangles(sourceImage, kf1[trb1.Value], trb2.Value, trb3.Value, trb4.Value * 10, trb5.Value);
            }
            if (mode == 2)
            {
                IMG2.Image = fil.findcircles(notresizedImage, circle1.Value * 10, circle2.Value, circle3.Value, circle4.Value * 10);
            }
        }

        private void trb4_ValueChanged(object sender, EventArgs e)
        {
            lb4.Text = Convert.ToString(trb4.Value * 10);
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void trb5_ValueChanged(object sender, EventArgs e)
        {
            lb5.Text = Convert.ToString(trb5.Value);
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void circle1_ValueChanged(object sender, EventArgs e)
        {
            cb1.Text = Convert.ToString(circle1.Value * 10);
        }

        private void circle2_ValueChanged(object sender, EventArgs e)
        {
            cb2.Text = Convert.ToString(circle2.Value);
        }

        private void circle3_ValueChanged(object sender, EventArgs e)
        {
            cb3.Text = Convert.ToString(circle3.Value);
        }

        private void circle4_ValueChanged(object sender, EventArgs e)
        {
            cb4.Text = Convert.ToString(circle4.Value * 10);
        }

        private void colorb_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.colorfind(sourceImage, (byte)colortrb1.Value, (byte)colortrb2.Value);
        }

        private void colortrb1_ValueChanged(object sender, EventArgs e)
        {
            clb1.Text = Convert.ToString(colortrb1.Value);
        }

        private void colortrb2_ValueChanged(object sender, EventArgs e)
        {
            clb2.Text = Convert.ToString(colortrb2.Value);
        }
    }
}
