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
                g.DrawEllipse(Pens.Red, n.X * 20, n.Y * 20, 20, 20);
            }
        }
    }
}
