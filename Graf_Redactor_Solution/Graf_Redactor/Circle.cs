using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graf_Redactor
{
    class MyCircle : Figure
    {
        int x_start, y_start, rad;
        Pen Pen = new Pen(Color.Blue, 3);
        public MyCircle(MyRectangle rect)
        {
            this.x_start = rect.x - rect.width / 8;
            this.y_start = rect.y + rect.hight;
            this.rad = rect.width / 2;
            this.x = this.rad;
            this.y = this.x;
        }
        public MyCircle(GetPoint gp)
        {
            if (gp.)
            this.x_start = gp.PointStartX;
            this.y_start = gp.PointStartY;
            this.rad = (gp.PointEndX - gp.PointStartX) / 2;
            this.x = this.rad;
            this.y = this.x;
        }
        public MyCircle(MyCircle circl)
        {
            this.x_start = circl.x_start + circl.x * 3/2;
            this.y_start = circl.y_start;
            this.x = circl.x;
            this.y = this.x;
        }
        public override void Draw(Graphics yourGraphics)
        {
            yourGraphics.DrawEllipse(this.Pen, this.x_start, this.y_start, this.x, this.y);;
        }
        public override void Move(GetPoint gp)
        {
            this.x_start = gp.PointStartX;
            this.y_start = gp.PointStartY;
            this.rad = (gp.PointEndX - gp.PointStartX) / 2;
            this.x = this.rad;
            this.y = this.x;
        }
    }
}
