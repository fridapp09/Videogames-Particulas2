using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace GV_LAB_4
{
    public class GravityInfluencer : Influencer
    {
        public float GravitationalConstant { get; set; }
        private float height; 
        PointF gravityForce; 
        float forceMagnitude, distance;

        public GravityInfluencer(float gravitationalConstant, float height)
        {
            this.GravitationalConstant = gravitationalConstant; 
            this.height = height;
        }

        public override PointF GetForce(Particle particle)
        {
            // Calcular la distancia vertical entre la partícula y el punto de referencia (por ejemplo, el suelo)
            distance = height - particle.pY;

            // Calcular la fuerza de la gravedad
            forceMagnitude = (GravitationalConstant * particle.Mass * 1000) / (distance * distance); 

            // F = G * (m1 * m2) / r^2// La fuerza de la gravedad siempre apunta hacia abajo, en dirección negativa en el eje Y
            gravityForce = new PointF(0, -forceMagnitude);

            return gravityForce;
        }
    }
}
