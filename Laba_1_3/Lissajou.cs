using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class Lissajou : Trajectory
    {
        private double radius = 100;
        public double Radius 
        {
            get { return radius; }
            set { radius = value; }
        }

        private int k = 3;

        private double beta;

        public override void Draw(PictureBox pb)
        {
            Prepare(pb);
            for(int i =0; i<TrajecPoints.Length; i++)
            {
                beta = InjectionNext * k;
                X = XStart + Radius * Math.Sin(InjectionNext + Math.PI / 2)*Scale;
                Y = YStart + Radius * Math.Sin(beta) * Scale;
                InjectionNext = InjectionNext + Step;
                TrajecPoints[i] = new Point((int)X, (int)Y);
            }
            TrajecGraphic.DrawPolygon(TrajecPen, TrajecPoints);

        }
    }
}
