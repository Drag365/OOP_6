using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4OOP.src
{
    interface Shape
    {
        void Draw();
        void changeSelect();
        bool checkPointPosition(Point point);

        Point getPosition();

        void unSelect();

        bool getSelect();

        void move(int x, int y);

        void upSize(int s);

        int getRadius();

        void changeColor(string Color);
    }
}