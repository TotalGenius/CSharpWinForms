using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_1_3
{
    class Ellipse : Trajectory
    {
        private double a = 120;
        private double b = 180;

        public override void Draw(PictureBox pb)
        {
            Prepare(pb);
            //Рассчитываем координаты траетории в цикле
            for (int i = 0; i < TrajecPoints.Length; i++)
            {
                X = XStart + a * Math.Cos(InjectionNext) * Scale;
                Y = YStart - b * Math.Sin(InjectionNext) * Scale;
                
                TrajecPoints[i] = new Point((int)X, (int)Y);
                //Угол, с которым высчитываем следующую координату    
                InjectionNext = InjectionNext + Step;
            }
            //Отрисовывает траекторию по точкам
            TrajecGraphic.DrawPolygon(TrajecPen, TrajecPoints);           

        }
    }
}
