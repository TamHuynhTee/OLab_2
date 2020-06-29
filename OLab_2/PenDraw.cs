using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLab_2
{
    class PenDraw
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Pen pen { get; set; }
        public bool isUse { get; set; }
        public PenDraw()
        {
            isUse = false;
            pen = new Pen(Color.Black, 2);
        }
    }
}
