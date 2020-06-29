using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLab_2
{
    public static class SP
    {
        public static string key(Project input)
        {
            return '[' + input.MaDA + ']' + " " + input.TenDA;
        }
        public static string key(Member input)
        {
            return '[' + input.MaTV + ']' + " " + input.TenTV;
        }
        public static string key(Job input)
        {
            return '[' + input.MaCV + ']' + " " + input.TenCV;
        }
        public static string GetIDFromKey(string key)
        {
            return key.Substring(1, 6);
        }
        public static Bitmap emptyImage(int w, int h)
        {
            Bitmap bm = new Bitmap(w, h);
            using (Graphics graph = Graphics.FromImage(bm))
            {
                Rectangle ImageSize = new Rectangle(0, 0, w, h);
                graph.FillRectangle(Brushes.LightSteelBlue, ImageSize);
            }
            return bm;

        }
    }
}
