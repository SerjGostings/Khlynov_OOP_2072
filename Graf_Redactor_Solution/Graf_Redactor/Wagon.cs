using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graf_Redactor
{
    class Wagon : MyRectangle
    {
        MyCircle myC1, myC2;
        protected MyRectangle myR;
        int weight;
        Random rnd = new Random();
        public Wagon (GetPoint gp) : base (gp)
        {
            myR = new MyRectangle(gp);
            myC1 = new MyCircle(myR);
            myC2 = new MyCircle(myC1);
            load(this);
        }
        public override void Draw(Graphics yourGraphics)
        {
                myR.Draw(yourGraphics);
                myC1.Draw(yourGraphics);
                myC2.Draw(yourGraphics);
        }
        public void load(Wagon wagon)
        {
            wagon.setWeight(rnd.Next(100));
        }
        public void setWeight(int weight)
        {
            if (weight >= 0)
                this.weight = weight;
        }
        public int getWeight()
        {
            return weight;
        }
    }
}
