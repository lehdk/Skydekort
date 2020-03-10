using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkydekortGUI
{
    public static class Helper
    {
        public static Image ReziseImage(Image image, Size size)
        {
            return (Image)(new Bitmap(image, size));
        }
    }
}
