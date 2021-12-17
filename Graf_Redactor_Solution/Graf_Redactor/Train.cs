using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graf_Redactor
{
    class Train : Figure
    {
        int wagon_count, wagonS_count, wagonC_count;
        List<Wagon> wagon_list = new List<Wagon>();

        public Train(GetPoint gp, int wag_c, int wagC_c, int wagS_c)
        {
            GetPoint first_wagon_points, wagon_points;

            first_wagon_points = gp;
            wagon_points = first_wagon_points;
            wagon_count = wag_c;
            wagonC_count = wagC_c;
            wagonS_count = wagS_c;
            wagon_count = wagon_count - wagonC_count - wagonS_count;
            int w_c, wC_c, wS_c;
            Wagon train_wagon;
            for (w_c = 0; w_c < wagon_count; w_c++)
            {
                train_wagon = new Wagon(wagon_points);
                wagon_list.Add(train_wagon);
                wagon_points = NextWagon(wagon_points);
            }
            for (wC_c = 0; wC_c < wagonC_count; wC_c++)
            {
                train_wagon = new WagonCoal(wagon_points);
                wagon_list.Add(train_wagon);
                wagon_points = NextWagon(wagon_points);
            }
            for (wS_c = 0; wS_c < wagonS_count; wS_c++)
            {
                train_wagon = new WagonSand(wagon_points);
                wagon_list.Add(train_wagon);
                wagon_points = NextWagon(wagon_points);
            }
        }
        public override void Draw(Graphics yourGraphics)
        {
            foreach (Wagon train_wagon in wagon_list)
            {
                train_wagon.Draw(yourGraphics);
            }
        }
        private GetPoint NextWagon (GetPoint wagon_points)
        {
            int x1, y1, x2, y2;
            x1 = wagon_points.PointEndX + (wagon_points.PointEndX - wagon_points.PointStartX) / 3;
            y1 = wagon_points.PointStartY;
            x2 = x1 + (wagon_points.PointEndX - wagon_points.PointStartX);
            y2 = wagon_points.PointEndY;
            GetPoint wag_p = new GetPoint();
            wag_p.Set(x1, y1, x2, y2);
            return wag_p;
        }
        public int weight_all()
        {
            int count = 0;

            foreach (Wagon train_wagon in wagon_list)
            {
                count += train_wagon.getWeight();
            }
            return count;
        }
    }
}
//for (int i = 0; i < wagon_count; i++)
//{
//    random = rnd.Next(3);
//    if ((random == 0) && (w_c < wagon_count - wagonC_count - wagonS_count))
//    {
//        w_c++;
//        train_wagon = new Wagon(wagon_points);
//        wagon_list.Add(train_wagon);
//    }
//    else if ((random == 1) && (wC_c < wagonC_count))
//    {
//        train_wagon = new WagonCoal(wagon_points);
//        wagon_list.Add(train_wagon);
//    }
//    else if ((random == 2) && (wS_c < wagonS_count))
//    {
//        train_wagon = new WagonSand(wagon_points);
//        wagon_list.Add(train_wagon);
//    }
//    wagon_points = NextWagon(wagon_points);
//}