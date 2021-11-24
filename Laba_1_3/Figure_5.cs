using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class Figure_5 : MovingObject
    {
        public Figure_5(Trajectory trajectory) : base(trajectory)
        {    
        }

       
        public Point[] figureParts = new Point[12];

        public override void Move(PictureBox pb)
        {
            base.MoveCentralPoint(pb);
             
            figureParts[0] = new Point(XPoint, YPoint);
            figureParts[1] = new Point(XPoint+10, YPoint+30);
            figureParts[2] = new Point(XPoint- 10, YPoint+30);          

            figureParts[3] = new Point(XPoint, YPoint);
            figureParts[4] = new Point(XPoint+30, YPoint+10);
            figureParts[5] = new Point(XPoint+30, YPoint-10);          

            figureParts[6] = new Point(XPoint, YPoint);
            figureParts[7] = new Point(XPoint - 30, YPoint + 10);
            figureParts[8] = new Point(XPoint - 30, YPoint - 10);          

            figureParts[9] = new Point(XPoint, YPoint);
            figureParts[10] = new Point(XPoint + 10, YPoint - 30);
            figureParts[11] = new Point(XPoint - 10, YPoint - 30);
                        
            Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figureParts);
          
        }
    }
}
