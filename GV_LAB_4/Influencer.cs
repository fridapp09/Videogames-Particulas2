using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace GV_LAB_4
{
    public abstract class Influencer
    {
        public abstract PointF GetForce(Particle particle);
    }
}