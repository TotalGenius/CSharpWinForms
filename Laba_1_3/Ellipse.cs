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
            
            //Вынести в отдельный метод
            XStart = pb.Width / 2;
            YStart = pb.Height / 2;
            TrajecGraphic = pb.CreateGraphics();
            TrajecPen = new Pen(TrajColor, 3f);
            Injection = 0;
            //Вот эту часть 

            //Это тоже переписать надо
            Step = Math.PI / TrajecPoints.Length;
            //

            //Рассчитываем координаты траетории в цикле
            for (int i = 0; i < TrajecPoints.Length; i++)
            {
                X = XStart + a * Math.Cos(Injection) * Scale;
                Y = YStart - b * Math.Sin(Injection) * Scale;
                
                TrajecPoints[i] = new Point((int)X, (int)Y);
                //Угол, с которым высчитываем следующую координату    
                Injection = Injection + Step;
            }

            //Отрисовывает траекторию по точкам
            TrajecGraphic.DrawPolygon(TrajecPen, TrajecPoints);           

        }
    }
}
