using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Graf_Redactor
{
    class WagonSand : Wagon
    {
        Triangle myTr;
        public WagonSand(GetPoint gp) : base (gp)
        {
            myTr = new Triangle(base.myR);
            base.load(this);
        }
        public override void Draw(Graphics yourGraphics)
        {
            base.Draw(yourGraphics);
            myTr.Draw(yourGraphics);
        }
    }
}
