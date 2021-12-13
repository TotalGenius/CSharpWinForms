using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_1_3
{
    abstract class Trajectory
    {
        //Зададим переменные и свойства для начального и конечного угла
        private double injectionStart = 0;
        public double InjectionStart
        {
            get { return injectionStart; }
            set { injectionStart = value; }
        }
        private double injectionEnd = Math.PI;
        public double InjectionEnd 
        {
            get { return injectionEnd; }
            set { injectionEnd = value; } 
        }

        public double InjectionNext { get; set; }
        //
        public double X { get; set; }
        public double Y { get; set; }
        public double XStart { get; set; }
        public double YStart { get; set; }
        public Graphics TrajecGraphic { get; set; }

        private Point[] trajecPoints = new Point[100];
        public Point[] TrajecPoints { get { return trajecPoints; } private set { } }

        public double Step { get; set; }

        private double scale = 1;

        public double Scale { get { return scale; } set { scale=value; } }

        public Pen TrajecPen { get; set; }

        /*
         * Свойства и переменные для изменения 
         * Цвета траектории
         */
        private Color trajColor = Color.Black;
        public Color TrajColor
        {
            get { return trajColor; }
            set { trajColor = value; }
        }
        //

        /*
         * Действия в методе Prepare одинаковы для каждой траектории
         * Поэтому описываем их в отдельном методе абстрактного класса,
         * который будет доступен только в классах наследниках
         */
        protected void Prepare(PictureBox pb)
        {
            XStart = pb.Width / 2;
            YStart = pb.Height / 2;
            TrajecGraphic = pb.CreateGraphics();
            TrajecPen = new Pen(TrajColor, 3f);
           
            Step = InjectionEnd / TrajecPoints.Length;
            
            InjectionNext = InjectionStart;
        }
        public abstract void Draw(PictureBox pb);
    }
}
