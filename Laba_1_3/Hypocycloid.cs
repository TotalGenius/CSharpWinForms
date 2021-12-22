using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class Hypocycloid : Trajectory
    {
        private int k = 4;
        private double bigRadius = 100;
        public double BigRadius
        { 
            get { return bigRadius; }
            set { bigRadius = value; }
        }

        private double smallRadius;
        public override void Draw(PictureBox pb)
        {
            Prepare(pb);
            smallRadius = BigRadius / k;
            for(int i = 0; i<TrajecPoints.Length; i++)
            {
                X = XStart + smallRadius * (k - 1) * (Math.Cos(InjectionNext) + ((Math.Cos((k - 1) * InjectionNext)) / (k - 1)))*Scale;
                Y = YStart + smallRadius * (k - 1) * (Math.Sin(InjectionNext) - ((Math.Sin((k - 1) * InjectionNext)) / (k - 1)))*Scale;
                TrajecPoints[i] = new Point((int)X, (int)Y);
                InjectionNext = InjectionNext + Step;
            }
            TrajecGraphic.DrawPolygon(TrajecPen, TrajecPoints);
        }
    }
}
