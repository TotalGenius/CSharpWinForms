using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class MovingPoint : MovingObject
    {
        public MovingPoint(Trajectory trajectory) : base (trajectory) {
            
        }

        public override void Move(PictureBox pb)
        {
            MoveCentralPoint(pb);
            Trajectory.TrajecGraphic.FillEllipse(Brushes.Red, XPoint, YPoint, 10, 10);
        }
    }
}
