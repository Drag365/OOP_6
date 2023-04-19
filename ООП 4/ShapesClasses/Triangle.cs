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
        protected string Colored = "Blue";
        Graphics g;
        public Triangle(Point click, Graphics graphics, string Colored)
        {
            p = click;
            g = graphics;
            this.Colored = Colored;
        }


        public void Draw()
        {
            Pen pen = new Pen(Color.Brown);
            if (Colored == "Blue")
                pen.Color = Color.BlueViolet;
            else if (Colored == "Black")
                pen.Color = Color.Black;
            else if (Colored == "Red")
                pen.Color = Color.IndianRed;
            else if (Colored == "Green")
                pen.Color = Color.Green;
            else if (Colored == "Purple")
                pen.Color = Color.Purple;
            double angle = Math.PI / 6;
            pen.Width = 4;
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
                pen.Width = 2;
                pen.Color = Color.Black;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, p.X - (R + 16) / 2, p.Y - (R + 26) / 2, (R + 16), R + 12);

            }
            else
            {
                pen.Width = 4;
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

        public void changeColor(string Color)
        {
            Colored = Color;
        }
    }
}
