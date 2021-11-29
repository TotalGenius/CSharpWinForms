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
                if (counter >= BreathSize)
                {
                    breathIn = false;
                    breathOut = true;
                    //counter += BreathSize;
                    BreathStep= FigureSize+ BreathSize;

                }

                base.MoveCentralPoint(pb);

                
                figureParts[0] = new Point(XPoint, YPoint);
                figureParts[1] = new Point(XPoint + (10 + FigureSize+counter), YPoint + (30 + FigureSize + counter));
                figureParts[2] = new Point(XPoint - (10 + FigureSize+ counter), YPoint + (30 + FigureSize+ counter));

                figureParts[3] = new Point(XPoint, YPoint);
                figureParts[4] = new Point(XPoint + (30 + FigureSize + counter), YPoint + (10 + FigureSize + counter));
                figureParts[5] = new Point(XPoint + (30 + FigureSize + counter), YPoint - (10 + FigureSize + counter));

                figureParts[6] = new Point(XPoint, YPoint);
                figureParts[7] = new Point(XPoint - (30 + FigureSize + counter), YPoint + (10 + FigureSize + counter));
                figureParts[8] = new Point(XPoint - (30 + FigureSize + counter), YPoint - (10 + FigureSize + counter));

                figureParts[9] = new Point(XPoint, YPoint);
                figureParts[10] = new Point(XPoint + (10 + FigureSize + counter), YPoint - (30 + FigureSize + counter));
                figureParts[11] = new Point(XPoint - (10 + FigureSize + counter), YPoint - (30 + FigureSize + counter));

                Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figureParts);
                counter+=BreathSpeed;
                
            } 
            else
            {
                if (counter <= 0)
                {
                    breathIn = true;
                    breathOut = false;
                    //counter =0;
                    BreathStep = 0;
                }

                base.MoveCentralPoint(pb);

                figureParts[0] = new Point(XPoint, YPoint);
                BreathStep -= BreathSpeed;
                figureParts[0] = new Point(XPoint, YPoint);
                figureParts[1] = new Point(XPoint + (10 + BreathStep), YPoint + (30 + BreathStep));
                figureParts[2] = new Point(XPoint - (10 + BreathStep), YPoint + (30 + BreathStep));

                figureParts[3] = new Point(XPoint, YPoint);
                figureParts[4] = new Point(XPoint + (30 + BreathStep), YPoint + (10 + BreathStep));
                figureParts[5] = new Point(XPoint + (30 + BreathStep), YPoint - (10 + BreathStep));

                figureParts[6] = new Point(XPoint, YPoint);
                figureParts[7] = new Point(XPoint - (30 + BreathStep), YPoint + (10 + BreathStep));
                figureParts[8] = new Point(XPoint - (30 + BreathStep), YPoint - (10 + BreathStep));

                figureParts[9] = new Point(XPoint, YPoint);
                figureParts[10] = new Point(XPoint + (10 + BreathStep), YPoint - (30 + BreathStep));
                figureParts[11] = new Point(XPoint - (10 + BreathStep), YPoint - (30 + BreathStep));

                Trajectory.TrajecGraphic.DrawPolygon(Trajectory.TrajecPen, figureParts);

                counter -=BreathSpeed;
                
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
