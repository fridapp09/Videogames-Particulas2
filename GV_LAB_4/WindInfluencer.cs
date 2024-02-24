using System;
using System.Drawing;

namespace GV_LAB_4
{
    public class WindInfluencer : Influencer
    {
        public float WindStrength { get; set; }

        public WindInfluencer(float windStrength)
        {
            WindStrength = windStrength;
        }

        public override PointF GetForce(Particle particle)
        {
            float windForceX = WindStrength;
            float windForceY = 0; 

            return new PointF(windForceX, windForceY);
        }
    }
}
