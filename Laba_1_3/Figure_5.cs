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

        public Point[] figurePart_1 = new Point[3];
        public Point[] figurePart_2 = new Point[3];
        public Point[] figurePart_3 = new Point[3];
        public Point[] figurePart_4 = new Point[3];

        public override void Move(PictureBox pb)
        {
            base.MoveCentralPoint(pb);

            figurePart_1[0] = new Point(XPoint, YPoint);
            figurePart_1[1] = new Point(XPoint+10, YPoint+30);
            figurePart_1[2] = new Point(XPoint- 10, YPoint+30);
            Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figurePart_1);
            
            figurePart_2[0] = new Point(XPoint, YPoint);
            figurePart_2[1] = new Point(XPoint+30, YPoint+10);
            figurePart_2[2] = new Point(XPoint+30, YPoint-10);
            Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figurePart_2);

            figurePart_3[0] = new Point(XPoint, YPoint);
            figurePart_3[1] = new Point(XPoint - 30, YPoint + 10);
            figurePart_3[2] = new Point(XPoint - 30, YPoint - 10);
            Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figurePart_3);

            figurePart_4[0] = new Point(XPoint, YPoint);
            figurePart_4[1] = new Point(XPoint + 10, YPoint - 30);
            figurePart_4[2] = new Point(XPoint - 10, YPoint - 30);
            Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figurePart_4);
        }


    }
}
