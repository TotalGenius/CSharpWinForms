using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class FigureVar_16 : Figure
    {
       public FigureVar_16(Trajectory trajectory): base(trajectory)
        {
            BreathSize = 10;
            BreathSpeed = 1;
            figureParts = new Point[12];
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

        protected override void MoveBreath(PictureBox pb)
        {
            if (breathIn)
            {
                if (counter >= BreathSize)
                {
                    breathIn = false;
                    breathOut = true;
                    BreathOutStep = FigureSize + BreathSize;

                }

                base.MoveCentralPoint(pb);


                figureParts[0] = new Point(XPoint, YPoint);
                figureParts[1] = new Point(XPoint, YPoint + (30 + FigureSize + counter));
                figureParts[2] = new Point(XPoint - (10 + FigureSize + counter), YPoint + (30 + FigureSize + counter));

                figureParts[3] = new Point(XPoint, YPoint);
                figureParts[4] = new Point(XPoint + (30 + FigureSize + counter), YPoint + (10 + FigureSize + counter));
                figureParts[5] = new Point(XPoint + (30 + FigureSize + counter), YPoint);

                figureParts[6] = new Point(XPoint, YPoint);
                figureParts[7] = new Point(XPoint - (30 + FigureSize + counter), YPoint);
                figureParts[8] = new Point(XPoint - (30 + FigureSize + counter), YPoint - (10 + FigureSize + counter));

                figureParts[9] = new Point(XPoint, YPoint);
                figureParts[10] = new Point(XPoint + (10 + FigureSize + counter), YPoint - (30 + FigureSize + counter));
                figureParts[11] = new Point(XPoint, YPoint - (30 + FigureSize + counter));

                pb.CreateGraphics().DrawPolygon(new Pen(ObjColor, 3f), figureParts);
                counter += BreathSpeed;

            }
            else
            {
                if (counter <= 0)
                {
                    breathIn = true;
                    breathOut = false;
                }

                base.MoveCentralPoint(pb);

                BreathOutStep -= BreathSpeed;
                figureParts[0] = new Point(XPoint, YPoint);

                figureParts[0] = new Point(XPoint, YPoint);
                figureParts[1] = new Point(XPoint, YPoint + (30 + BreathOutStep));
                figureParts[2] = new Point(XPoint - (10 + BreathOutStep), YPoint + (30 + BreathOutStep));

                figureParts[3] = new Point(XPoint, YPoint);
                figureParts[4] = new Point(XPoint + (30 + BreathOutStep), YPoint + (10 + BreathOutStep));
                figureParts[5] = new Point(XPoint + (30 + BreathOutStep), YPoint);

                figureParts[6] = new Point(XPoint, YPoint);
                figureParts[7] = new Point(XPoint - (30 + BreathOutStep), YPoint);
                figureParts[8] = new Point(XPoint - (30 + BreathOutStep), YPoint - (10 + BreathOutStep));

                figureParts[9] = new Point(XPoint, YPoint);
                figureParts[10] = new Point(XPoint + (10 + BreathOutStep), YPoint - (30 + BreathOutStep));
                figureParts[11] = new Point(XPoint, YPoint - (30 + BreathOutStep));

                pb.CreateGraphics().DrawPolygon(new Pen(ObjColor, 3f), figureParts);

                counter -= BreathSpeed;

            }
        }

        protected override void MoveWithoutBreath(PictureBox pb)
        {
            base.MoveCentralPoint(pb);

            figureParts[0] = new Point(XPoint, YPoint);
            figureParts[1] = new Point(XPoint, YPoint + (30 + FigureSize));
            figureParts[2] = new Point(XPoint - (10 + FigureSize), YPoint + (30 + FigureSize));

            figureParts[3] = new Point(XPoint, YPoint);
            figureParts[4] = new Point(XPoint + (30 + FigureSize), YPoint + (10 + FigureSize));
            figureParts[5] = new Point(XPoint + (30 + FigureSize), YPoint);

            figureParts[6] = new Point(XPoint, YPoint);
            figureParts[7] = new Point(XPoint - (30 + FigureSize), YPoint);
            figureParts[8] = new Point(XPoint - (30 + FigureSize), YPoint - (10 + FigureSize));

            figureParts[9] = new Point(XPoint, YPoint);
            figureParts[10] = new Point(XPoint + (10 + FigureSize), YPoint - (30 + FigureSize));
            figureParts[11] = new Point(XPoint, YPoint - (30 + FigureSize));

            pb.CreateGraphics().DrawPolygon(new Pen(ObjColor, 3f), figureParts);
        }
    }
}
