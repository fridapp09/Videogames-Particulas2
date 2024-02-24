using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV_LAB_4
{
    public class Particle
    {
        public PointF OP,OV;
        public float pX, pY, vX,vY, tFX,tFY;

        public float Alfa { get; set; }
        public float Mass { get; set; }
        public Image Image { get; set; }
        public float Size { get; set; }
        private float Lifetime; // Duración de vida de la partícula
        private float elapsedTime; // Tiempo transcurrido desde que se creó la partícula

        public Particle(PointF position, PointF velocity) 
        {
            OP = position;
            OV = velocity;
            Alfa = .17f; 
            Init(); 
        }

        private void Init() 
        { 
            pX = OP.X + +(float)Util.Instance.Rand.NextDouble(); 
            pY = OP.Y + +(float)Util.Instance.Rand.NextDouble();

            vX = OV.X; 
            vY = OV.Y; 
            elapsedTime = 0; 
            
            Image = Util.Instance.WAT_IMGS[Util.Instance.Rand.Next(Util.Instance.WAT_IMGS.Length)]; 
            
            Lifetime = (float)Util.Instance.Rand.NextDouble() - .59f;
            Size = Util.Instance.Rand.Next(3, 15); 
            Mass = Size; 

            float VAL = (float)Util.Instance.Rand.NextDouble(); 
            
            VAL = Math.Min(VAL, Alfa);
            
            Image = Util.ApplyAlpha(Image, VAL);
        }

        public void Update(List<Influencer> influencers, float deltaTime, Size space, PointF pos)
        {
            tFX = 0; 
            tFY = 0; 
            OP = pos; 
            
            elapsedTime += deltaTime; // Incrementar el tiempo transcurrido
            
            for (int i = 0; i < influencers.Count; i++)
            {
                PointF force = influencers[i].GetForce(this);
                tFX = force.X;
                tFY = force.Y;
            }
            
            // Actualizar la velocidad de la partícula de acuerdo con la fuerza total de influencia
            vX += tFX;
            vY += tFY;
            // Actualizar la posición de la partícula según su velocidad
            pX += vX;
            pY += vY;
            // Actualizar de acuerdo con el tiempo de vida y el espacio del canvas
        }
        public void Render(Graphics g, Size canvasSize)
        {
            if (pX >= 0 && pX + Size <= canvasSize.Width &&
                pY >= 0 && pY + Size <= canvasSize.Height)
            {
                g.DrawImage(Image, pX, pY, Size, Size);
            }
        }
    }
}
