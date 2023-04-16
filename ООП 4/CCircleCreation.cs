using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ООП_4
{
    class CCircleCreation
    {
        private Graphics g;
        public CCircleCreation(Graphics graphics)
        {
            g = graphics;
        }

        public CCIrcle createCCircle(Point click)
        {
            return new CCIrcle(click, g);
        }
    }
}
