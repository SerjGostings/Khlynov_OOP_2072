using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graf_Redactor
{
    class Triangle : Figure
    {
        SolidBrush sb;
        Point[] points;
        public Triangle(GetPoint gp)
        {
            sb = new SolidBrush(Color.Yellow);
            points = new Point[]
            {
                new Point { X = gp.PointStartX + (gp.PointEndX - gp.PointStartX)/6, Y = gp.PointEndY},
                new Point { X = gp.PointStartX + (gp.PointEndX - gp.PointStartX)/2, Y = gp.PointStartY},
                new Point { X = gp.PointStartX + (gp.PointEndX - gp.PointStartX) * 5/6, Y = gp.PointEndY}
            };
        }
        public Triangle(MyRectangle rect)
        {
            sb = new SolidBrush(Color.Yellow);
            points = new Point[]
           {
               new Point { X = rect.x + rect.width / 6, Y = rect.y },
               new Point { X = rect.x + rect.width / 2, Y = rect.y - 30 },
               new Point { X = rect.x + rect.width * 5 / 6, Y = rect.y }
           };
        }
        public override void Draw(Graphics gr)
        {
            gr.FillPolygon(sb, points);
        }
    }
}
