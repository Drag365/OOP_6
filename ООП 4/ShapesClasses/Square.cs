using Laba4OOP.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4
{
    public class Square : Shape
    {
        public Square(Point click, Graphics graphics, string Colored)
        {
            p = click;
            g = graphics;
            this.Colored = Colored;
        }


        override public void Draw()
        {
            Pen pen = new Pen(Color.Brown);
            pen.Width = 4;
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
            if (selected)
            {
                g.DrawRectangle(pen, p.X - R / 2, p.Y - R / 2, R, R);
                pen.Width = 2;
                pen.Color = Color.Black;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, p.X - (R + 8) / 2, p.Y - (R + 8) / 2, R + 8, R + 8);
            }
            else
            {
               
                g.DrawRectangle(pen, p.X - R / 2, p.Y - R / 2, R, R);
            }
        }
    }
}
