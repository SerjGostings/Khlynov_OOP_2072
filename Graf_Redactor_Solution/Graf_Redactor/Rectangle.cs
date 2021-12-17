using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graf_Redactor
{
    class MyRectangle : Figure
    {
        public int width, hight;
        Pen Pen = new Pen(Color.Red, 3);

        public MyRectangle(GetPoint gp)
        {
            this.x = gp.PointStartX;
            this.y = gp.PointStartY;
            this.width = gp.PointEndX - gp.PointStartX;
            this.hight = gp.PointEndY - gp.PointStartY;
        }
        public MyRectangle(MyRectangle rect)
        {
            this.Pen = new Pen(Color.Black, 3);
            this.x = rect.x + rect.width/6;
            this.y = rect.y - 20;
            this.width = rect.width*2/3;
            this.hight = 20;
        }
        public override void Draw(Graphics yourGraphics)
        {
            yourGraphics.DrawRectangle(this.Pen, this.x, this.y, this.width, this.hight);
        }
    }
}
