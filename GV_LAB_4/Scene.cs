using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GV_LAB_4
{
    public class Scene
    {
        public List<Emitter> Emitter { get; set; }
        public Scene()
        {
            Emitter = new List<Emitter>(); 
        }
    }
}
