﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        static Trajectory trajectory = new Ellipse();
        MovingObject movingObj = new Figure_5(trajectory);
    

        private void pBoxPaint(object sender, PaintEventArgs e)
        {
            //Задаем рамеры picture box и отрисовываем траеторию
            pBox.Height = ClientSize.Height;
            pBox.Width = (int)(ClientSize.Width*0.75);
            trajectory.Draw(pBox);    
        }

        private void pBoxResize(object sender, EventArgs e)
        {
            //При изменении размера picture box она отрисовывается заново вместе с траеторией
            pBoxPaint(sender, null) ;
           
        }

        private void mainFormResize(object sender, EventArgs e)
        {
            //При изменении гланой формы меняется и pucture box
            Refresh();
            pBoxResize(sender, e);
        }

        private void ChangeTrajecSize(object sender, EventArgs e)
        {
            /*
             * С помощью движка меняем размер траектории и заново
             * отрисовываем его.
             */
            trajectory.Scale = changeTrajecSizeTBar.Value / (double)(changeTrajecSizeTBar.Maximum - changeTrajecSizeTBar.Minimum);
            Refresh();
            trajectory.Draw(pBox);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Refresh();
            movingObj.Move(pBox);
        }

        private void MoveStart_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void PointMoveStop_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        private void ChangeFigureSpeed(object sender, EventArgs e)
        {
            movingObj.Speed = FigureSpeedMovement.Value;
        }
    }
}
