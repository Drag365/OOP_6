using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Laba4OOP.src;

namespace ООП_4
{
    public class CCIrcle : Shape
    {
        protected Point p;
        protected int R = 40;
        protected Boolean selected;
        Graphics g;
        public CCIrcle(Point click, Graphics graphics)
        {
            p = click;
            g = graphics;
        }

        
        public void Draw()
        {
            Pen pen = new Pen(Color.IndianRed);
            pen.Width = 4;
            if (selected)
            {
                g.DrawEllipse(pen, p.X - R / 2, p.Y - R / 2, R, R);
            }
            else
            {
                pen.Color = Color.BlueViolet;
                g.DrawEllipse(pen, p.X - R / 2, p.Y - R / 2, R, R);
            }
        }
        public Point getPosition()
        {
            return p;
        }

        public bool getSelect()
        {
            return selected;
        }
        public void unSelect()
        {
            selected = false;
        }
        public void changeSelect()
        {
            selected = !selected;
        }
        public bool checkPointPosition(Point point)
        {
            double len = Math.Sqrt(Math.Pow(point.X - p.X, 2) + Math.Pow(point.Y - p.Y, 2));
            if (len < R/2)
            {
                return true;
            }
            return false;
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
    }
}
