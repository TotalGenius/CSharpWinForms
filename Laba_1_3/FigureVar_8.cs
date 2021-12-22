using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    class FigureVar_8 : Figure
    {
      public  FigureVar_8(Trajectory trajectory): base(trajectory)
        {
            BreathSize = 10;
            BreathSpeed = 1;
            figureParts = new Point[20];
        }

        private int highDeametr = 10;
        public int HighDeametr
        {
            get { return highDeametr; }
            set { highDeametr = value; }
        }
        private int weigthDeametr = 10;
        public int WeigthDeametr
        {
            get { return weigthDeametr; }
            set { weigthDeametr = value; }
        }

        private Point rhombusCenter;




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

                //Верхний ромб
                rhombusCenter = new Point(XPoint, YPoint + (2 * HighDeametr + FigureSize+counter));
                figureParts[0] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize + counter));//a
                figureParts[1] = new Point(rhombusCenter.X + (WeigthDeametr + FigureSize + counter), rhombusCenter.Y);//b
                figureParts[2] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize + counter));//c
                figureParts[3] = new Point(rhombusCenter.X - (WeigthDeametr + FigureSize + counter), rhombusCenter.Y);//d

                //возврат к точке
                figureParts[4] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize + counter));//e

                //левый ромб
                rhombusCenter = new Point(XPoint - (2 * WeigthDeametr + FigureSize + counter), YPoint);
                figureParts[5] = new Point(rhombusCenter.X + (WeigthDeametr + FigureSize + counter), rhombusCenter.Y);//f
                figureParts[6] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize + counter));//g
                figureParts[7] = new Point(rhombusCenter.X - (WeigthDeametr + FigureSize + counter), rhombusCenter.Y);//h
                figureParts[8] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize + counter));//i

                //Возврат к точке
                figureParts[9] = new Point(rhombusCenter.X + (WeigthDeametr + FigureSize + counter), rhombusCenter.Y);//j

                //Нижний ромб
                rhombusCenter = new Point(XPoint, YPoint - (2 * HighDeametr + FigureSize + counter));
                figureParts[10] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize + counter));//k
                figureParts[11] = new Point(rhombusCenter.X - (WeigthDeametr + FigureSize+counter), rhombusCenter.Y);//l
                figureParts[12] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize + counter));//m
                figureParts[13] = new Point(rhombusCenter.X + (WeigthDeametr + FigureSize + counter), rhombusCenter.Y);//n

                //Возврат к точке
                figureParts[14] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize + counter));//o

                //Правый ромб
                rhombusCenter = new Point(XPoint + (2 * WeigthDeametr + FigureSize + counter), YPoint);
                figureParts[15] = new Point(rhombusCenter.X - (WeigthDeametr + FigureSize + counter), rhombusCenter.Y);//p
                figureParts[16] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize + counter));//q
                figureParts[17] = new Point(rhombusCenter.X + (WeigthDeametr + FigureSize + counter), rhombusCenter.Y);//r
                figureParts[18] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize + counter));//s

                //Возврат к точке
                figureParts[19] = new Point(rhombusCenter.X - (WeigthDeametr + FigureSize + counter), rhombusCenter.Y);//е


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

                //Верхний ромб
                rhombusCenter = new Point(XPoint, YPoint + (2 * HighDeametr + BreathOutStep));
                figureParts[0] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + BreathOutStep));//a
                figureParts[1] = new Point(rhombusCenter.X + (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//b
                figureParts[2] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + BreathOutStep));//c
                figureParts[3] = new Point(rhombusCenter.X - (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//d

                //возврат к точке
                figureParts[4] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + BreathOutStep));//e

                //левый ромб
                rhombusCenter = new Point(XPoint - (2 * WeigthDeametr + BreathOutStep), YPoint);
                figureParts[5] = new Point(rhombusCenter.X + (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//f
                figureParts[6] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + BreathOutStep));//g
                figureParts[7] = new Point(rhombusCenter.X - (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//h
                figureParts[8] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + BreathOutStep));//i

                //Возврат к точке
                figureParts[9] = new Point(rhombusCenter.X + (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//j

                //Нижний ромб
                rhombusCenter = new Point(XPoint, YPoint - (2 * HighDeametr + BreathOutStep));
                figureParts[10] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + BreathOutStep));//k
                figureParts[11] = new Point(rhombusCenter.X - (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//l
                figureParts[12] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + BreathOutStep));//m
                figureParts[13] = new Point(rhombusCenter.X + (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//n

                //Возврат к точке
                figureParts[14] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + BreathOutStep));//o

                //Правый ромб
                rhombusCenter = new Point(XPoint + (2 * WeigthDeametr + BreathOutStep), YPoint);
                figureParts[15] = new Point(rhombusCenter.X - (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//p
                figureParts[16] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + BreathOutStep));//q
                figureParts[17] = new Point(rhombusCenter.X + (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//r
                figureParts[18] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + BreathOutStep));//s

                //Возврат к точке
                figureParts[19] = new Point(rhombusCenter.X - (WeigthDeametr + BreathOutStep), rhombusCenter.Y);//е

                BreathOutStep -= BreathSpeed;
                



                pb.CreateGraphics().DrawPolygon(new Pen(ObjColor, 3f), figureParts);
                
                counter -= BreathSpeed;
            }
        }

        protected override void MoveWithoutBreath(PictureBox pb)
        {
            base.MoveCentralPoint(pb);

            /*
             * Возможно, когда нибудь и этот кусок нормально заработает
            figureParts[0] = new Point(XPoint - ((WeigthDeametr * 3) + FigureSize), YPoint);
            figureParts[1] = new Point(XPoint - ((WeigthDeametr * 2) + FigureSize), YPoint + (HigthDeametr + FigureSize));
            figureParts[2] = new Point(XPoint + (WeigthDeametr + FigureSize), YPoint - ((HigthDeametr * 2) + FigureSize));
            figureParts[3] = new Point(XPoint, YPoint - ((HigthDeametr * 3) + FigureSize));
            figureParts[4] = new Point(XPoint - (WeigthDeametr + FigureSize), YPoint - ((2 * HigthDeametr) + FigureSize));
            figureParts[5] = new Point(XPoint + ((WeigthDeametr * 2) + FigureSize), YPoint + (HigthDeametr + FigureSize));
            figureParts[6] = new Point(XPoint + ((WeigthDeametr * 3) + FigureSize), YPoint);
            figureParts[7] = new Point(XPoint + ((WeigthDeametr * 2) + FigureSize), YPoint - (HigthDeametr + FigureSize));
            figureParts[8] = new Point(XPoint - (WeigthDeametr + FigureSize), YPoint + ((HigthDeametr * 2)+ FigureSize));
            figureParts[9] = new Point(XPoint, YPoint + ((HigthDeametr * 3) + FigureSize));
            figureParts[10] = new Point(XPoint + (WeigthDeametr + FigureSize), YPoint + ((HigthDeametr * 2) + FigureSize));
            figureParts[11] = new Point(XPoint - ((WeigthDeametr * 2) + FigureSize), YPoint - (HigthDeametr + FigureSize));
            figureParts[12] = new Point(XPoint - ((WeigthDeametr * 3) + FigureSize), YPoint);
            */


           
            //Верхний ромб
            rhombusCenter = new Point(XPoint, YPoint + (2 * HighDeametr+FigureSize));
            figureParts[0] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize));//a
            figureParts[1] = new Point(rhombusCenter.X+(WeigthDeametr+FigureSize), rhombusCenter.Y);//b
            figureParts[2] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize));//c
            figureParts[3] = new Point(rhombusCenter.X-(WeigthDeametr+FigureSize), rhombusCenter.Y);//d

            //возврат к точке
            figureParts[4] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize));//e

            //левый ромб
            rhombusCenter = new Point(XPoint - (2*WeigthDeametr+FigureSize), YPoint);
            figureParts[5] = new Point(rhombusCenter.X + (WeigthDeametr + FigureSize), rhombusCenter.Y);//f
            figureParts[6] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize));//g
            figureParts[7] = new Point(rhombusCenter.X - (WeigthDeametr + FigureSize), rhombusCenter.Y);//h
            figureParts[8] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize));//i

            //Возврат к точке
            figureParts[9] = new Point(rhombusCenter.X + (WeigthDeametr + FigureSize), rhombusCenter.Y);//j

            //Нижний ромб
            rhombusCenter = new Point(XPoint, YPoint-(2*HighDeametr+FigureSize));
            figureParts[10] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize));//k
            figureParts[11] = new Point(rhombusCenter.X - (WeigthDeametr + FigureSize), rhombusCenter.Y);//l
            figureParts[12] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize));//m
            figureParts[13] = new Point(rhombusCenter.X + (WeigthDeametr + FigureSize), rhombusCenter.Y);//n

            //Возврат к точке
            figureParts[14] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize));//o

            //Правый ромб
            rhombusCenter = new Point(XPoint+(2*WeigthDeametr+FigureSize), YPoint);
            figureParts[15] = new Point(rhombusCenter.X - (WeigthDeametr + FigureSize), rhombusCenter.Y);//p
            figureParts[16] = new Point(rhombusCenter.X, rhombusCenter.Y - (HighDeametr + FigureSize));//q
            figureParts[17] = new Point(rhombusCenter.X + (WeigthDeametr + FigureSize), rhombusCenter.Y);//r
            figureParts[18] = new Point(rhombusCenter.X, rhombusCenter.Y + (HighDeametr + FigureSize));//s

            //Возврат к точке
            figureParts[19] = new Point(rhombusCenter.X - (WeigthDeametr + FigureSize), rhombusCenter.Y);//е
           


            pb.CreateGraphics().DrawPolygon(new Pen(ObjColor, 3f), figureParts);
        }
    }
}
