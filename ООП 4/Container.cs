using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ООП_4
{
    class Container
    {
        private List<CCIrcle> circles;
        public bool ctrlPressed = false;
        public bool selectMany = false;
        public Container()
        {
            circles = new List<CCIrcle>();
        }

        public void drawCircles()
        {
            foreach (CCIrcle circle in circles)
                circle.Draw();
        }

        public void unSelectAll()
        {
            foreach (CCIrcle circle in circles)
            {
                circle.unSelect();
            }
        }
        public bool isSelect(Point point)
        {
            bool res = false;
            foreach (CCIrcle circle in circles)
            {
                if (circle.selected == false && circle.checkPointPosition(point) == true)
                {
                    circle.selected = true;
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
            for (; i < circles.Count;)
            {
                if (circles[i].selected == true)
                {
                    circles.RemoveAt(i);
                    continue;
                }
                i++;
            }
        }
        public void delCircles()
        {
            for (int i = 0; i < circles.Count;)
            {
                    circles.RemoveAt(i);
            }
        }
        public void AddOrSelectShape(CCIrcle circle)
        {
            if (ctrlPressed == false)
                unSelectAll();
            if (isSelect(circle.getPosition())) { return; }
            if (ctrlPressed == false)
            {
                circle.changeSelect();
                circles.Add(circle);
            }
        }
    }
}
