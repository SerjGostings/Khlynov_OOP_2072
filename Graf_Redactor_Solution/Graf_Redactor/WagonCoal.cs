using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graf_Redactor
{
    class WagonCoal : Wagon
    {
        MyRectangle myCR;
        public WagonCoal(GetPoint gp) : base(gp)
        {
            myCR = new MyRectangle(base.myR);
            base.load(this);
        }
        public override void Draw(Graphics yourGraphics)
        {
                base.Draw(yourGraphics);
                myCR.Draw(yourGraphics);
        }
    }
}
