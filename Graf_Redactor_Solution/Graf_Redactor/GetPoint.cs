using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf_Redactor
{
    struct GetPoint
    {
        public int PointStartX { get; set; }
        public int PointStartY { get; set; }
        public int PointEndX { get; set; }
        public int PointEndY { get; set; }

        public GetPoint(int pointStartX, int pointStartY, int pointEndX, int pointEndY)
        {
            PointStartX = pointStartX;
            PointStartY = pointStartY;
            PointEndX = pointEndX;
            PointEndY = pointEndY;
        }
        public void Reset()
        {
            PointStartX = 0;
            PointStartY = 0;
            PointEndX = 0;
            PointEndY = 0;
        }
        public void Set(int stX, int stY, int endX, int endY)
        {
            PointStartX = stX;
            PointStartY = stY;
            PointEndX = endX;
            PointEndY = endY;
        }
        public void Swap(GetPoint gp)
        {
            PointStartX = gp.PointEndX;
            PointStartY = gp.PointEndY;
            PointEndX = gp.PointStartX;
            PointEndY = gp.PointStartY;
        }
    }
}