using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }

        decimal dt;
        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;
        int counter = 0;
        DateTime start;
        decimal cosa, sina;
        decimal height, speed, angle, m, S, step;
        decimal t, x, y, k, vx, vy, v0;
        decimal maxHeightGlobal;

        private void btStart_Click(object sender, EventArgs e)
        {
            if (counter == 5) Clear();
            if (!timer1.Enabled)
            {
                t = 0;
                x = 0;
                dt = boxStep.Value;
                y = boxHeight.Value;
                v0 = boxSpeed.Value;
                double a = (double)boxAngle.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = boxSize.Value;
                m = boxWeight.Value;
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                maxHeightGlobal = y;
                chart1.Series[counter].Points.AddXY(x, y);
                chart1.Series[counter].Name = "[" + (counter + 1).ToString() + "] Step:" + boxStep.Value.ToString();
                start = DateTime.Now;
                timer1.Start();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Clear();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TextBox[] timeStepText = { TimeStep1, TimeStep2, TimeStep3, TimeStep4, TimeStep5 };
            TextBox[] distanceText = { Distance1, Distance2, Distance3, Distance4, Distance5 };
            TextBox[] maxHeightText = { MH1, MH2, MH3, MH4, MH5 };
            TextBox[] endSpeedText = { EndSpeed1, EndSpeed2, EndSpeed3, EndSpeed4, EndSpeed5 };
            t += dt;
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            if (y > maxHeightGlobal) maxHeightGlobal = y;
            chart1.Series[counter].Points.AddXY(x, y);
            if (y <= 0)
            {
                distanceText[counter].Text = x.ToString();
                timeStepText[counter].Text = t.ToString();
                maxHeightText[counter].Text = maxHeightGlobal.ToString();
                decimal endSpeed = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
                endSpeedText[counter].Text = endSpeed.ToString();
                counter++;
                timer1.Stop();
            }
        }

        private void Clear()
        {
            TextBox[] timeStepText = { TimeStep1, TimeStep2, TimeStep3, TimeStep4, TimeStep5 };
            TextBox[] distanceText = { Distance1, Distance2, Distance3, Distance4, Distance5 };
            TextBox[] maxHeightText = { MH1, MH2, MH3, MH4, MH5 };
            TextBox[] endSpeedText = { EndSpeed1, EndSpeed2, EndSpeed3, EndSpeed4, EndSpeed5 };
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[i].Points.Clear();
                timeStepText[i].Text = "";
                distanceText[i].Text = "";
                maxHeightText[i].Text = "";
                endSpeedText[i].Text = "";
                chart1.Series[i].Name = (i + 1).ToString();
            }
            counter = 0;
        }
    }
}
