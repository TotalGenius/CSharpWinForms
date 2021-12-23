using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_3
{
    static class СhangedObject
    {
        private static Trajectory currentTrajectory = new Ellipse();
        public static Trajectory CurrentTrajectory {
            get { return currentTrajectory; }
            set { currentTrajectory = value; }
        }

        private static Figure currentFigure = new FigureVar_5(CurrentTrajectory);
        public static Figure CurrentFigure 
        {
            get { return currentFigure; }
            set { currentFigure = value; }
        }
    }
}
