﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_1_3
{
    abstract class Trajectory
    {
        public double Injection { get; set; }
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

        public abstract void Draw(PictureBox pb);
    }
}
