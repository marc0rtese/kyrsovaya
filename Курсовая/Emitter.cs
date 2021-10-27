﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая
{
    public class Emitter
    {
        public int X; 
        public int Y; 
        public int Direction = 0; 
        public int Spreading = 360; 
        public int SpeedMin = 1;
        public int RadiusMin = 2;
        public int SpeedMax = 10; 
        public int RadiusMax = 10;
        public float LifeMax = 100;
        public float LifeMin = 20; 
        public int ParticlesPerTick = 40;
        public Color ColorFrom = Color.White; 
        public Color ColorTo = Color.FromArgb(0, Color.Black); 

        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();

        public List<Particle> particles = new List<Particle>();
        public float GravitationX;
        public float GravitationY;

        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick;
            foreach (var particle in particles)
            {
                if (particle.Life > 0)
                {
                    particle.Life -= 0.5F;
                }

                if (particle.Life <= 0) 
                {
                    if (particlesToCreate > 0)
                    {
                        particlesToCreate -= 1; 
                        ResetParticle(particle);
                    }
                }
                else
                {
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;

                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                }
            }
            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            foreach (var point in impactPoints)
            {
                point.Render(g);
            }
        }

        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next((int)LifeMin, (int)LifeMax);
            (particle as ParticleColorful).FromColor = ColorFrom;
            particle.X = X;
            particle.Y = Y;

            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }
        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }
    }
    public class TopEmitter : Emitter
    {
        public int Width;
        public int Height;

        public int SpeedX;
        public override void ResetParticle(Particle particle)
        {
            base.ResetParticle(particle); 

            particle.X = Particle.rand.Next(Width); 
            particle.Y = Height;

            particle.SpeedY = 1;
            particle.SpeedX = Particle.rand.Next(-SpeedX, SpeedX);
        }
    }
}
