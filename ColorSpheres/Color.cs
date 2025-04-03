using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private const byte DEFAULT_ALPHA = 255;

        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = DEFAULT_ALPHA;
        }

        public byte Red
        {
            get { return red; }
            set { red = value; }
        }

        public byte Green
        {
            get { return green; }
            set { green = value; }
        }

        public byte Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        public byte Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public byte GetGrey()
        {
            return (byte)((red + green + blue) / 3);
        }
    }
}