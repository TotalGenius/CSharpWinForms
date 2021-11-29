using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class FigureVar_5 : Figure
    {
        public FigureVar_5(Trajectory trajectory) : base(trajectory) {

            BreathSize = 10;
            BreathSpeed = 1;

        }

        
        public Point[] figureParts = new Point[12];
        protected override void MoveBreath(PictureBox pb)
        {
            if (breathIn)
            {
                base.MoveCentralPoint(pb);
                

                figureParts[0] = new Point(XPoint, YPoint);
                figureParts[1] = new Point(XPoint + (10 + FigureSize+ BreathSpeed), YPoint + (30 + FigureSize + BreathSpeed));
                figureParts[2] = new Point(XPoint - (10 + FigureSize + BreathSpeed), YPoint + (30 + FigureSize + BreathSpeed));

                figureParts[3] = new Point(XPoint, YPoint);
                figureParts[4] = new Point(XPoint + (30 + FigureSize + BreathSpeed), YPoint + (10 + FigureSize + BreathSpeed));
                figureParts[5] = new Point(XPoint + (30 + FigureSize + BreathSpeed), YPoint - (10 + FigureSize + BreathSpeed));

                figureParts[6] = new Point(XPoint, YPoint);
                figureParts[7] = new Point(XPoint - (30 + FigureSize + BreathSpeed), YPoint + (10 + FigureSize + BreathSpeed));
                figureParts[8] = new Point(XPoint - (30 + FigureSize + BreathSpeed), YPoint - (10 + FigureSize + BreathSpeed));

                figureParts[9] = new Point(XPoint, YPoint);
                figureParts[10] = new Point(XPoint + (10 + FigureSize + BreathSpeed), YPoint - (30 + FigureSize + BreathSpeed));
                figureParts[11] = new Point(XPoint - (10 + FigureSize + BreathSpeed), YPoint - (30 + FigureSize + BreathSpeed));

                Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figureParts);
                counter-=BreathSpeed;
                if (counter >= BreathSize)
                {
                    breathIn = false;
                    breathOut = true;
                }
            } else if (breathOut)
            {
                figureParts[0] = new Point(XPoint, YPoint);
                figureParts[1] = new Point(XPoint + (10 + FigureSize - BreathSpeed), YPoint + (30 + FigureSize - BreathSpeed));
                figureParts[2] = new Point(XPoint - (10 + FigureSize - BreathSpeed), YPoint + (30 + FigureSize - BreathSpeed));

                figureParts[3] = new Point(XPoint, YPoint);
                figureParts[4] = new Point(XPoint + (30 + FigureSize - BreathSpeed), YPoint + (10 + FigureSize - BreathSpeed));
                figureParts[5] = new Point(XPoint + (30 + FigureSize - BreathSpeed), YPoint - (10 + FigureSize - BreathSpeed));

                figureParts[6] = new Point(XPoint, YPoint);
                figureParts[7] = new Point(XPoint - (30 + FigureSize -BreathSpeed), YPoint + (10 + FigureSize - BreathSpeed));
                figureParts[8] = new Point(XPoint - (30 + FigureSize - BreathSpeed), YPoint - (10 + FigureSize - BreathSpeed));

                figureParts[9] = new Point(XPoint, YPoint);
                figureParts[10] = new Point(XPoint + (10 + FigureSize - BreathSpeed), YPoint - (30 + FigureSize - BreathSpeed));
                figureParts[11] = new Point(XPoint - (10 + FigureSize - BreathSpeed), YPoint - (30 + FigureSize - BreathSpeed));

                Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figureParts);
                counter -=BreathSpeed;
                if (counter <= 0)
                {
                    breathIn = true;
                    breathOut = false;

                }
            }
            
        }

        protected override void MoveWithoutBreath(PictureBox pb)
        {
            base.MoveCentralPoint(pb);

            figureParts[0] = new Point(XPoint, YPoint);
            figureParts[1] = new Point(XPoint + (10 + FigureSize), YPoint + (30 + FigureSize));
            figureParts[2] = new Point(XPoint - (10 + FigureSize), YPoint + (30 + FigureSize));

            figureParts[3] = new Point(XPoint, YPoint);
            figureParts[4] = new Point(XPoint + (30 + FigureSize), YPoint + (10 + FigureSize));
            figureParts[5] = new Point(XPoint + (30 + FigureSize), YPoint - (10 + FigureSize));

            figureParts[6] = new Point(XPoint, YPoint);
            figureParts[7] = new Point(XPoint - (30 + FigureSize), YPoint + (10 + FigureSize));
            figureParts[8] = new Point(XPoint - (30 + FigureSize), YPoint - (10 + FigureSize));

            figureParts[9] = new Point(XPoint, YPoint);
            figureParts[10] = new Point(XPoint + (10 + FigureSize), YPoint - (30 + FigureSize));
            figureParts[11] = new Point(XPoint - (10 + FigureSize), YPoint - (30 + FigureSize));

            Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figureParts);
        }

        public override void Move(PictureBox pb)
        {
            if (IsBreath)
            {
                MoveBreath(pb);
            }
            else
            {
                MoveWithoutBreath(pb);
            }
        }
    }
}
