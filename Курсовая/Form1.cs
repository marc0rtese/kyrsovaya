using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        ColorPoint point;

        Color pointColor = Color.Navy;
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            emitter = new TopEmitter
            {
                Width = picDisplay.Width,
                GravitationY = 0.25f,
                SpeedX = 2,
                SpeedY = 2,
                fi = tbWidth.Value,
                Height = picDisplay.Height,
                R = picDisplay.Height / 2
            };
            point =  new ColorPoint
            {
                X = 0,
                Y = 0,
                color = Color.Navy
            };
            emitter.impactPoints.Add(point);
            emitters.Add(this.emitter);
            tbTick.Value = emitter.ParticlesPerTick;
            picDisplay.MouseWheel += picDisplay_MouseWheel;

            colorDialog1.FullOpen = true;
            colorDialog1.Color = Color.Navy;

            colorButton.BackColor = colorDialog1.Color;
            infoSpeed.Text = tbSpeed.Value.ToString();
            infoTick.Text = tbTick.Value.ToString();
            infoWigth.Text = tbWidth.Value.ToString();

        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            for(int i = 1; i < emitter.impactPoints.Count; i++)
            {
                var p = emitter.impactPoints[i];
                if (p is ColorPoint)
                {
                    var x = (p as ColorPoint).X - e.X;
                    var y = (p as ColorPoint).Y - e.Y;
                    double r = Math.Sqrt(x * x + y * y);
                    if (r <= (p as ColorPoint).Power / 2)
                    {
                        if (e.Delta < 0 && (p as ColorPoint).Power > 30)
                        {
                            (p as ColorPoint).Power -= 10;
                        }
                        if (e.Delta > 0 && (p as ColorPoint).Power < 300)
                        {
                            (p as ColorPoint).Power += 10;
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }
            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            point.X = e.X;
            point.Y = e.Y;
        }
        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;
                emitter.impactPoints.Add(new ColorPoint
                {
                    X = x,
                    Y = y,
                    color = pointColor
                }) ;
            }
            if(e.Button == MouseButtons.Right)
            {
                for (int i = 1; i < emitter.impactPoints.Count; i++)
                {
                    var p = emitter.impactPoints[i];
                    if (p is ColorPoint)
                    {
                        var x = (p as ColorPoint).X - e.X;
                        var y = (p as ColorPoint).Y - e.Y;
                        double r = Math.Sqrt(x * x + y * y);
                        if (r <= (p as ColorPoint).Power / 2)
                        {
                            emitter.impactPoints.Remove((p as ColorPoint));
                            break;
                        }
                    }
                }
            }
        }

        private void tbTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbTick.Value;
            infoTick.Text = tbTick.Value.ToString();
        }

        private void tbWidth_Scroll(object sender, EventArgs e)
        {
            infoWigth.Text = tbWidth.Value.ToString();
            emitters[0].particles.Clear();
            
            (emitters[0] as TopEmitter).fi = tbWidth.Value;
            (emitters[0] as TopEmitter).Width = picDisplay.Width;
            (emitters[0] as TopEmitter).Height = picDisplay.Height;
            (emitters[0] as TopEmitter).R = picDisplay.Height / 2;
            //(emitters[0] as TopEmitter).R = 382;
            (emitters[0] as Emitter).n = tbWidth.Value;
            //Радиус для круга за квадратом 382


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            (emitter as TopEmitter).SpeedY = tbSpeed.Value;
            (emitter as TopEmitter).SpeedX = tbSpeed.Value;
            infoSpeed.Text = tbSpeed.Value.ToString();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pointColor = colorDialog1.Color;
            colorButton.BackColor = colorDialog1.Color;
            point.color = pointColor;
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
