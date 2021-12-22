using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class FigureVar_11 : Figure
    {
        public FigureVar_11(Trajectory trajectory): base(trajectory)
        {
            BreathSize = 10;
            BreathSpeed = 1;
            figureParts = new Point[13];
        }

        private int high = 40;
        private int width = 10;
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

                figureParts[0] = new Point(XPoint + (width + FigureSize+counter), YPoint + (high + FigureSize + counter));
                figureParts[1] = new Point(XPoint + (width + FigureSize + counter), YPoint + (width + FigureSize + counter));
                figureParts[2] = new Point(XPoint + (high + FigureSize + counter), YPoint + (width + FigureSize + counter));
                figureParts[3] = new Point(XPoint + (high + FigureSize + counter), YPoint - (width + FigureSize + counter));
                figureParts[4] = new Point(XPoint + (width + FigureSize + counter), YPoint - (width + FigureSize + counter));
                figureParts[5] = new Point(XPoint + (width + FigureSize + counter), YPoint - (high + FigureSize + counter));
                figureParts[6] = new Point(XPoint - (width + FigureSize + counter), YPoint - (high + FigureSize + counter));
                figureParts[7] = new Point(XPoint - (width + FigureSize + counter), YPoint - (width + FigureSize + counter));
                figureParts[8] = new Point(XPoint - (high + FigureSize + counter), YPoint - (width + FigureSize + counter));
                figureParts[9] = new Point(XPoint - (high + FigureSize + counter), YPoint + (width + FigureSize + counter));
                figureParts[10] = new Point(XPoint - (width + FigureSize + counter), YPoint + (width + FigureSize + counter));
                figureParts[11] = new Point(XPoint - (width + FigureSize + counter), YPoint + (high + FigureSize + counter));
                figureParts[12] = new Point(XPoint + (width + FigureSize + counter), YPoint + (high + FigureSize + counter));

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
                figureParts[0] = new Point(XPoint + (width + FigureSize+ BreathOutStep), YPoint + (high + FigureSize + BreathOutStep));
                figureParts[1] = new Point(XPoint + (width + FigureSize + BreathOutStep), YPoint + (width + FigureSize + BreathOutStep));
                figureParts[2] = new Point(XPoint + (high + FigureSize + BreathOutStep), YPoint + (width + FigureSize + BreathOutStep));
                figureParts[3] = new Point(XPoint + (high + FigureSize + BreathOutStep), YPoint - (width + FigureSize + BreathOutStep));
                figureParts[4] = new Point(XPoint + (width + FigureSize + BreathOutStep), YPoint - (width + FigureSize + BreathOutStep));
                figureParts[5] = new Point(XPoint + (width + FigureSize + BreathOutStep), YPoint - (high + FigureSize + BreathOutStep));
                figureParts[6] = new Point(XPoint - (width + FigureSize + BreathOutStep), YPoint - (high + FigureSize + BreathOutStep));
                figureParts[7] = new Point(XPoint - (width + FigureSize + BreathOutStep), YPoint - (width + FigureSize + BreathOutStep));
                figureParts[8] = new Point(XPoint - (high + FigureSize + BreathOutStep), YPoint - (width + FigureSize + BreathOutStep));
                figureParts[9] = new Point(XPoint - (high + FigureSize + BreathOutStep), YPoint + (width + FigureSize + BreathOutStep));
                figureParts[10] = new Point(XPoint - (width + FigureSize + BreathOutStep), YPoint + (width + FigureSize + BreathOutStep));
                figureParts[11] = new Point(XPoint - (width + FigureSize + BreathOutStep), YPoint + (high + FigureSize + BreathOutStep));
                figureParts[12] = new Point(XPoint + (width + FigureSize + BreathOutStep), YPoint + (high + FigureSize + BreathOutStep));
                pb.CreateGraphics().DrawPolygon(new Pen(ObjColor, 3f), figureParts);

                counter -= BreathSpeed;
            }

            }

        protected override void MoveWithoutBreath(PictureBox pb)
        {
            base.MoveCentralPoint(pb);

            figureParts[0] = new Point(XPoint + (width + FigureSize), YPoint + (high + FigureSize));
            figureParts[1] = new Point(XPoint + (width + FigureSize), YPoint + (width + FigureSize));
            figureParts[2] = new Point(XPoint + (high + FigureSize), YPoint + (width + FigureSize));
            figureParts[3] = new Point(XPoint + (high + FigureSize), YPoint - (width + FigureSize));
            figureParts[4] = new Point(XPoint + (width + FigureSize), YPoint - (width + FigureSize));
            figureParts[5] = new Point(XPoint + (width + FigureSize), YPoint - (high + FigureSize));
            figureParts[6] = new Point(XPoint - (width + FigureSize), YPoint - (high + FigureSize));
            figureParts[7] = new Point(XPoint - (width + FigureSize), YPoint - (width + FigureSize));
            figureParts[8] = new Point(XPoint - (high + FigureSize), YPoint - (width + FigureSize));
            figureParts[9] = new Point(XPoint - (high + FigureSize), YPoint + (width + FigureSize));
            figureParts[10] = new Point(XPoint - (width + FigureSize), YPoint + (width + FigureSize));
            figureParts[11] = new Point(XPoint - (width + FigureSize), YPoint + (high + FigureSize));
            figureParts[12] = new Point(XPoint + (width + FigureSize), YPoint + (high + FigureSize));

            pb.CreateGraphics().DrawPolygon(new Pen(ObjColor, 3f), figureParts);
        }
    }
}
