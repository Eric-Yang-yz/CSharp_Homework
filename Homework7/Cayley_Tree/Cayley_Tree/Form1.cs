using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cayley_Tree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int n = 10;
        double leng = 100;
        Pen pen = Pens.Blue;
        Pen[] Colours = {Pens.Red,Pens.Orange,Pens.Yellow,Pens.Green,Pens.Cyan,Pens.Blue,Pens.Purple };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = pnlDraw.CreateGraphics();
            graphics.Clear(Color.White);
            int.TryParse(lblDepthShow.Text, out n);
            double.TryParse(lblLengShow.Text, out leng);
            double.TryParse(lblPer1Show.Text, out per1);
            double.TryParse(lblPer2Show.Text, out per2);
            double.TryParse(lblTh1Show.Text, out th1); th1 *= Math.PI / 180;
            double.TryParse(lblTh2Show.Text, out th2); th2 *= Math.PI / 180;

            int index = cmbColour.SelectedIndex;
            if (index != -1) pen = Colours[index];
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
        }

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void trbDepth_Scroll(object sender, EventArgs e)
        {
            lblDepthShow.Text = trbDepth.Value.ToString();
        }

        private void trbLeng_Scroll(object sender, EventArgs e)
        {
            lblLengShow.Text = trbLeng.Value.ToString();
        }

        private void trbPer1_Scroll(object sender, EventArgs e)
        {
            lblPer1Show.Text = ((double)trbPer1.Value / (double)100).ToString();
        }

        private void trbPer2_Scroll(object sender, EventArgs e)
        {
            lblPer2Show.Text = ((double)trbPer2.Value / (double)100).ToString();
        }

        private void trbTh1_Scroll(object sender, EventArgs e)
        {
            lblTh1Show.Text = trbTh1.Value.ToString();
        }

        private void trbTh2_Scroll(object sender, EventArgs e)
        {
            lblTh2Show.Text = trbTh2.Value.ToString();
        }
    }
}
