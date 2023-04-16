using Laba4OOP.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4.ShapesClasses
{
    public class Triangle : Shape
    {
        protected Point p;
        protected int R = 40;
        protected Boolean selected;
        Graphics g;
        public Triangle(Point click, Graphics graphics)
        {
            p = click;
            g = graphics;
        }


        public void Draw()
        {
            Pen pen = new Pen(Color.IndianRed);
            pen.Width = 4;
            double angle = Math.PI / 6;
            if (selected)
            {
                Point[] vertices = new Point[3];
                for (int i = 0; i < 3; i++)
                {
                    double x = p.X + (R * Math.Cos(angle)) / 1.5;
                    double y = p.Y + (R * Math.Sin(angle)) / 1.5;
                    vertices[i] = new Point((int)x, (int)y);
                    angle += 2 * Math.PI / 3;
                }
                g.DrawPolygon(pen, vertices);
            }
            else
            {
                pen.Color = Color.BlueViolet;
                Point[] vertices = new Point[3];
                for (int i = 0; i < 3; i++)
                {
                    double x = p.X + (R * Math.Cos(angle)) / 1.5;
                    double y = p.Y + (R * Math.Sin(angle)) / 1.5;
                    vertices[i] = new Point((int)x, (int)y);
                    angle += 2 * Math.PI / 3;
                }
                g.DrawPolygon(pen, vertices);
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
            if (len < R / 2)
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
