using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV_LAB_4
{
    public class Emitter
    {
        public PointF Position { get; set; }
        public List<Particle> Particles { get; set; }
        public List<Influencer> Influencers { get; set; }
        private Size space;

        public int MIN_X { get; set; }
        public int MAX_X { get; set; }


        public int MIN_Y { get; set; }
        public int MAX_Y { get; set; }

        public void AddWindInfluencer(float windStrength)
        {
            Influencers.Add(new WindInfluencer(windStrength));
        }

        public Emitter(PointF position, Size space)
        {
            this.Position = position;
            this.space = space;
            this.Influencers = new List<Influencer>();
        }
        public void EmitParticle(PointF position, Size space, float minVelocity, float maxVelocity)
        {
            if (Particles == null)
                Particles = new List<Particle>();

            float velocityX = Util.Instance.Rand.Next((int)minVelocity, (int)maxVelocity);
            float velocityY = Util.Instance.Rand.Next((int)minVelocity, (int)maxVelocity);
            position.X -= space.Width / 2;
            position.Y -= space.Height / 2;

            Particles.Add(new Particle(position, new PointF(velocityX, velocityY)));
        }

        public void ChangeVelocity(float minX, float maxX, float minY, float maxY)
        {
            foreach (var particle in Particles)
            {
                float newVelocityX = Util.Instance.Rand.Next((int)minX, (int)maxX);
                float newVelocityY = Util.Instance.Rand.Next((int)minY, (int)maxY);
                particle.vX = newVelocityX;
                particle.vY = newVelocityY;
            }
        }

        public void ChangeAlpha(float alpha)
        {
            foreach (var particle in Particles)
            {
                particle.Alfa = alpha;
                particle.Image = Util.ApplyAlpha(particle.Image, alpha);
            }
        }
        public void Render(Graphics g, float deltaTime)
        {
            int div = 8;
            int index = 0; 
            for (int p = 0; p < Particles.Count / div; p++) 
            { 
                index = p * div; 
                Update(g, index + 0, deltaTime); 
                Update(g, index + 1, deltaTime); 
                Update(g, index + 2, deltaTime);
                Update(g, index + 3, deltaTime); 
                Update(g, index + 4, deltaTime);
                Update(g, index + 5, deltaTime);
                Update(g, index + 6, deltaTime);
                Update(g, index + 7, deltaTime); 
            }
        }
        private void Update(Graphics g, int p, float deltaTime)
        {
            Particles[p].Update(Influencers, deltaTime, space, Position);
            Particles[p].Render(g, space);
        }
    }
}
