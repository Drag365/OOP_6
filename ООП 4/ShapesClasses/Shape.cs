using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4OOP.src
{
    abstract public class Shape
    {
        protected Graphics g;
        protected Point p;
        protected int R = 40;
        protected Boolean selected;
        protected string Colored = "Blue";
        abstract public void Draw();
        public void changeSelect()
        {
            selected = !selected;
        }
        public bool checkPointPosition(Point point)
        {
            double len = Math.Sqrt(Math.Pow(point.X - p.X, 2) + Math.Pow(point.Y - p.Y, 2));
            if (len < R / 2)
            {
                return true;
            }
            return false;
        }

        public Point getPosition()
        {
            return p;
        }

        public int getRadius()
        {
            return R;
        }

        public bool getSelect()
        {
            return selected;
        }

        public void unSelect()
        {
            selected = false;
        }


        public void move(int x, int y)
        {
            p.X += x;
            p.Y += y;
        }

        public void upSize(int s)
        {
            R += s;
        }

        public void changeColor(string Color)
        {
            Colored = Color;
        }
    }
}