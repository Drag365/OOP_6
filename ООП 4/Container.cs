using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Laba4OOP.src;
using System.Security.Cryptography.X509Certificates;

namespace ООП_4
{
    class Container
    {
        private List<Shape> shapes;
        public bool ctrlPressed = false;
        public bool selectMany = false;
        public Container()
        {
            shapes = new List<Shape>();
        }

        public void drawshapes()
        {
            foreach (Shape shape in shapes)
                shape.Draw();
        }

        public void unSelectAll()
        {
            foreach (Shape shape in shapes)
            {
                shape.unSelect();
            }
        }
        public bool isSelect(Point point)
        {
            bool res = false;
            foreach (Shape shape in shapes)
            {
                if (shape.getSelect() == false && shape.checkPointPosition(point) == true)
                {
                    shape.changeSelect();
                    res = true;
                    if (selectMany == false)
                        return res;
                }
            }
            return res;
        }
        public void delSelected()
        {
            int i = 0;
            for (; i < shapes.Count;)
            {
                if (shapes[i].getSelect() == true)
                {
                    shapes.RemoveAt(i);
                    continue;
                }
                i++;
            }
        }
        public void delshapes()
        {
            for (int i = 0; i < shapes.Count;)
            {
                    shapes.RemoveAt(i);
            }
        }
        public void AddOrSelectShape(Shape shape)
        {
            if (ctrlPressed == false)
                unSelectAll();
            if (isSelect(shape.getPosition())) { return; }
            if (ctrlPressed == false)
            {
                shape.changeSelect();
                shapes.Add(shape);
            }
        }

        public void moveShape(int x, int y, int width, int height)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.getSelect() == true)
                {
                    if (shape.getPosition().X + shape.getRadius() / 2 + x < width &&
                        shape.getPosition().X - shape.getRadius() / 2 + x > 0 &&
                        shape.getPosition().Y + shape.getRadius() / 2 + y < height &&
                        shape.getPosition().Y - shape.getRadius() / 2 + y > 0)
                        continue;
                    else return;
                }
            }
            foreach (Shape shape in shapes)
            {
                if (shape.getSelect() == true)
                {
                    shape.move(x, y);
                }
            }
            
        }

        public void upSizeShape(int s, int width, int height)
        {

            foreach (Shape shape in shapes)
            {
                if (shape.getSelect() == true)
                {
                    if (shape.getPosition().X + shape.getRadius() / 2 + s < width &&
                        shape.getPosition().X - shape.getRadius() / 2 + s > 0 &&
                        shape.getPosition().Y + shape.getRadius() / 2 + s < height &&
                        shape.getPosition().Y - shape.getRadius() / 2 + s > 0)
                        continue;
                    else return;
                }
            }
            foreach (Shape shape in shapes)
            {
                if (shape.getSelect() == true)
                {
                    shape.upSize(s);
                }
            }
        }

        public void downSizeShape(int s, int width, int height)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.getSelect() == true)
                {
                    shape.upSize(s);
                }
            }
        }
        public void changeColorShape(string Color)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.getSelect() == true)
                {
                    shape.changeColor(Color);
                    
                }
            }
        }
    }
}
