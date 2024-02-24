using System;
using System.Drawing;

namespace GV_LAB_4
{
    public class DarkHoleInfluencer : Influencer
    {
        public PointF Center { get; set; }
        public float AttractionStrength { get; set; }

        public DarkHoleInfluencer(PointF center, float attractionStrength)
        {
            Center = center;
            AttractionStrength = attractionStrength;
        }

        public override PointF GetForce(Particle particle)
        {
            // Calculate the vector pointing from the particle to the center of the dark hole
            float dx = Center.X - particle.pX;
            float dy = Center.Y - particle.pY;

            // Calculate the distance between the particle and the center of the dark hole
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            // Normalize the vector to get the direction
            float normalizedX = dx / distance;
            float normalizedY = dy / distance;

            // Calculate the force magnitude
            float forceMagnitude = AttractionStrength;

            // Apply the force in the direction of the normalized vector
            float forceX = normalizedX * forceMagnitude;
            float forceY = normalizedY * forceMagnitude;

            return new PointF(forceX, forceY);
        }
    }
}