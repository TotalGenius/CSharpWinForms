using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    abstract class MovingObject
    {
        /*
         * В конструктор передается траетория с которой предстоит работать,
         * т.е. траетория по которой должен двигаться объект
         */
        public MovingObject(Trajectory trajectory) 
        {
            Trajectory = trajectory;
        }

        public Trajectory Trajectory { get; set; }

        //Свойства и переменные для движущейся центральной точки
        public int XPoint { get; set; }
        public int YPoint { get; set; }
        private int i = 0;
        private int centralPointMovaingSpeed = 1;
        public int CentralPointMovingSpeed
        {
            get { return centralPointMovaingSpeed; }
            set { centralPointMovaingSpeed = value; }
        }
        private bool isEndOfRoad = false;
        //



        /*
         * Реализация движения точки по траектории 
         * (точка в дальнейшем становится центром фигуры).
         * Движения происходит туда-обратно
         */
        protected void MoveCentralPoint(PictureBox pb)
        {
            Trajectory.Draw(pb);
            if (isEndOfRoad)
            {
                if (i>= Trajectory.TrajecPoints.Length - 1 )
                {
                    isEndOfRoad = false;
                }
                else
                {
                    /*
                     * При добавлении возможности изменения скорости движения
                     * добавили доп. проверку во избежания исключения ArrayOutOfBound
                     */
                    if (i < 0)
                        i = 0;
                    //
                    XPoint = Trajectory.TrajecPoints[i].X;
                    YPoint = Trajectory.TrajecPoints[i].Y;
                    i=i+centralPointMovaingSpeed;
                }
            }
            else
            {
                if (i == 0 || i<0)
                {
                    isEndOfRoad = true;
                }
                else
                {
                    /*
                     * При добавлении возможности изменения скорости движения
                     * добавили доп. проверку во избежания исключения ArrayOutOfBound
                     */
                    if (i > Trajectory.TrajecPoints.Length - 1)
                        i = Trajectory.TrajecPoints.Length - 1;
                    //

                    XPoint = Trajectory.TrajecPoints[i].X;
                    YPoint = Trajectory.TrajecPoints[i].Y;
                    i=i-centralPointMovaingSpeed;
                }
            }            
        }

        /*
         * Реализация движения объекта-фигуры.
         * Внутри метода вызывается метод MoveCentralPoint(PictureBox pb)
         * а также вычисляется форма фигуры. За центр фигуры берем движущуюся
         * точку из метода MoveCentralPoint(PictureBox pb)
         */
        public abstract void Move(PictureBox pb);

    }
}
