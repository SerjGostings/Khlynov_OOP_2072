using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graf_Redactor
{
    class Figure
    {
        public int x, y;
        public virtual void Draw(Graphics gr)
        {

        }
        public virtual void Move(GetPoint gp)
        {

        }
    }
}
