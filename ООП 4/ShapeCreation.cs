using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ООП_4.ShapesClasses;

namespace ООП_4
{
    class ShapeCreation
    {
        private Graphics g;
        public ShapeCreation(Graphics graphics)
        {
            g = graphics;
        }

        public CCIrcle createCCircle(Point click)
        {
            return new CCIrcle(click, g);
        }

        public Square createSquare(Point click)
        {
            return new Square(click, g);
        }

        public Triangle createTriangle(Point click)
        {
            return new Triangle(click, g);
        }
    }
}
