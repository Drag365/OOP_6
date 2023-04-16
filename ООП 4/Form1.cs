using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_4
{
  
    public partial class Form1 : Form
    {
        Container container = new Container();// создаем контейнер хранящий круги
        Graphics g;// создаем объект графики
        ShapeCreation Creation;// создаем объект-конвеер кругов
        Bitmap map;// создаем битмап "мап"
        Boolean ctrlpress = false;// флажок зажатия контрола
        int typeOfShape = 0;
        public Form1()
        {
            InitializeComponent();
            map = new Bitmap(paintField.Width, paintField.Height);// определяем битмап
            Creation = new ShapeCreation(Graphics.FromImage(map));// определяем конвеер кругов
        }

        
        private void paintField_Paint(object sender, PaintEventArgs e)// функция отрисовки кругов
        {
            Graphics.FromImage(map).Clear(Color.LightGray);
            container.drawshapes();
            paintField.Image = map;
        }

        private void paintField_MouseClick(object sender, MouseEventArgs e)//функция нажатия мышкой для добавления на поле круга или его выделения
        {
            if (typeOfShape == 0) 
                container.AddOrSelectShape(Creation.createCCircle(e.Location));
            else if (typeOfShape == 1)
                    container.AddOrSelectShape(Creation.createSquare(e.Location));
            else if (typeOfShape == 2)
                container.AddOrSelectShape(Creation.createTriangle(e.Location));
            paintField.Invalidate();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)//функция нажатия клавиши контрол или делит
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)// определяем зажатие клавиши контрол
            {
                ctrlpress = true;
                container.ctrlPressed = !container.ctrlPressed;
            }
            if (e.KeyCode == Keys.Delete)
            {
                Graphics.FromImage(map).Clear(Color.LightGray);
                container.delSelected();
            }
            if (e.KeyCode == Keys.A)
            {
                container.moveShape(-5, 0);
            }
            if (e.KeyCode == Keys.S)
            {
                container.moveShape(0, 5);
            }
            if (e.KeyCode == Keys.D)
            {
                container.moveShape(5, 0);
            }
            if (e.KeyCode == Keys.W)
            {
                container.moveShape(0, -5);
            }

            if (e.KeyCode == Keys.E)
            {
                container.upSizeShape(1);
            }

            if (e.KeyCode == Keys.Q)
            {
                container.upSizeShape(-1);
            }
        }

        private void CtrlCheck_CheckedChanged(object sender, EventArgs e)//если мы выделели чекбокс "контрол зажат", то меняем значение флажка 
        {
            container.ctrlPressed = !container.ctrlPressed;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)// отжатие контрола, меняем флажок
        {
            
            if ((Control.ModifierKeys & Keys.Control) != Keys.Control && ctrlpress == true)
            {
                container.ctrlPressed = !container.ctrlPressed;
                ctrlpress = !ctrlpress;
            }
        }

        private void deleteAll_Click(object sender, EventArgs e)// функция нажатия на кнопку "Удалить все"
        {
            Graphics.FromImage(map).Clear(Color.LightGray);
            container.delshapes();
        }

        private void selectAll_CheckedChanged(object sender, EventArgs e)
        {
            container.selectMany = !container.selectMany;
        }

        private void paintField_Click(object sender, EventArgs e)
        {

        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeOfShape = 0;
            toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Circle;
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeOfShape = 1;
            toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Square;
        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeOfShape = 2;
            toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Triangle;
        }
    }
    
}
