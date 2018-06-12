using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiczbaPi
{
    public partial class Okno : Form
    {
        public Okno()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kwadrat = e.Graphics;
            Pen kp = new Pen(Color.Green, 5);
            kwadrat.DrawRectangle(kp, 0, 0, 1000, 1000);

            Graphics kolo = e.Graphics;
            Pen op = new Pen(Color.Blue, 5);
            Program.DrawCircle(kolo, op, 500, 500, 500);
            float n = 10000000;
            Random rd = new Random();
            int xx = 0;
            int yy = 0;
            float x = 0;
            float y = 0;
            float tmpx = 0;
            float tmpy = 0;
            int punktow_w_kole = 0;
            Brush aBrush = (Brush)Brushes.Black;
            Graphics g = this.CreateGraphics();
            for (int i = 1; i <= n; i++)
            {
                
                xx = rd.Next(0, 1000);
                yy = rd.Next(0, 1000);
                g.FillRectangle(aBrush, xx, yy, 1, 1);

                x = xx;
                tmpx = (x - 500) / 500;
                
                y = yy;
                tmpy = (y - 500) / 500;
                //MessageBox.Show("xx" + xx);
                //MessageBox.Show("tmpx" + tmpx);
                //MessageBox.Show("yy" + yy);
                //MessageBox.Show("tmpy" + tmpy);
                if (tmpx * tmpx + tmpy * tmpy <= 1)
                {
                    ++punktow_w_kole;
                }
            }
            double licz_kwad = n;
            double cztery = 4;
            MessageBox.Show("" + punktow_w_kole);
            double PI = cztery * punktow_w_kole / licz_kwad;
            MessageBox.Show("Szukana liczba pi =" + PI);
        }
        private void DajPixele(PaintEventArgs e)
        {

        }
    }
}
