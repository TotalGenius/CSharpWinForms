using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_3
{
    abstract class Figure : MovingObject
    {
        public Figure(Trajectory trajectory) : base(trajectory)
        {    
        }

        /*Свойства и переменные для реализации
         *"дыхания" фигуры, возможности 
         *изменения скорости дыхания 
         *размеров фигуры
          */
        protected int counter;
        protected bool breathIn=true;
        protected bool breathOut = false;
        protected int BreathOutStep;
        
        public int FigureSize { get; set; }

        public bool IsBreath { get; set; }
        public int BreathSize { get; set; }
        public int BreathSpeed { get; set; }
        //

        abstract protected void MoveWithoutBreath(PictureBox pb);
        abstract protected void MoveBreath(PictureBox pb);

        

       
    }
}
