using System;
using System.Drawing;

namespace Курсовая
{
    public abstract class IImpactPoint
    {
        public float X; 
        public float Y;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }
    public class ColorPoint : IImpactPoint
    {
        public int Power = 100;
        public Color color;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            //Если частица внутри точки
            if (r + particle.Radius < Power / 1.7 && particle.Life > 0)
            {
                //Перекрасить частицу
                (particle as ParticleColorful).FromColor = color;
            }
        }

        public override void Render(Graphics g)
        {
            //Нарисовать точку
            g.DrawEllipse(
                   new Pen(color, 3),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }
}
