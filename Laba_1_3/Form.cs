using System;
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


        static Trajectory trajectory = new Hypocycloid();
        MovingObject movingObj = new FigureVar_16(trajectory);
    

        private void pBoxPaint(object sender, PaintEventArgs e)
        {
            //Задаем рамеры picture box и отрисовываем траеторию
            pBox.Height = ClientSize.Height;
            pBox.Width = (int)(ClientSize.Width*0.5);
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
            movingObj.CentralPointMovingSpeed = FigureSpeedMovement.Value;
        }

        private void ChangeFigureSize(object sender, EventArgs e)
        {
            Figure figure = (Figure)movingObj;
            figure.FigureSize = changeFigureSize.Value;
            Refresh();
        }

        private void BreathButton_Click(object sender, EventArgs e)
        {
            Figure figure = (Figure)movingObj;
            if (figure.IsBreath == false)
            {
                figure.IsBreath= true;
            }
            else
            {
                figure.IsBreath = false;
            }

            Refresh();

        }

        private void ChangeBreathSpeed(object sender, EventArgs e)
        {
            Figure figure = (Figure)movingObj;
            figure.BreathSpeed = breathSpeed.Value;
            
        }

        private void ChangeBreathSize(object sender, EventArgs e)
        {
            Figure figure = (Figure)movingObj;
            figure.BreathSize = breathSize.Value;
           
            

        }

        private void pBox_BackColorChanged(object sender, EventArgs e)
        {
            trajectory.Draw(pBox);
        }

        private void trajecColor_Click(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            trajectory.TrajColor = chooseColor.Color;
            Refresh();
            trajectory.Draw(pBox);
        }

        private void objColor_Click(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            movingObj.ObjColor = chooseColor.Color;
        }

        private void backGroundColor_Click(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            pBox.BackColor = chooseColor.Color;
            Refresh();
            trajectory.Draw(pBox);
        }
    }
}
