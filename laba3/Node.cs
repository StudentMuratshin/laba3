using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Node
    {
        int value;
        int x, y;
        public Node(int value, int x, int y)
        {
            this.x = x;
            this.y = y;
            ColorPen = Pens.Red;
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }

        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }

        }

        public Pen ColorPen { get; set; }
    }
}

