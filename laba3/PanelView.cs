using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 
using System.Windows.Forms;

namespace laba3
{
    internal class PanelView : Panel, IView
    {
        public delegate void Clicked(int X, int Y);
        public event Clicked ClickedXY;
        IModel model;
        public IModel Model {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public void UpdateView()
        {
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Model == null) return;
            Graphics g = e.Graphics;
            foreach (Node n in Model.AllNodes)
            {
                g.DrawEllipse(n.ColorPen, n.X - 10, n.Y - 10, 20, 20);
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            ClickedXY(e.X, e.Y);
        }
    }
}
