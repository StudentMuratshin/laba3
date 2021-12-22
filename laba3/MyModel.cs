using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba3
{
    class MyModel : IModel
    {
        public event Action Changed;
        LinkedList<Node> nodes = new LinkedList<Node>();

        static Random r = new Random();
        public int Count => nodes.Count;

        public LinkedList<Node> AllNodes => nodes;
        public void AddNode(int value)
        {
            nodes.AddFirst(new Node(value, r.Next(400), r.Next(320)));
            if (Changed != null) Changed();
        }
        public void RemoveNode(Node node)
        {
            nodes.Remove(node);
            if (Changed != null) Changed();
        }
        public void RemoveLastNode()
        {
            nodes.RemoveLast();
            if (Changed != null) Changed();
        }

        public void ChangeColor(int x,int y)
        {
            List<Node> temp = new List<Node>(nodes);
            for (int i = 0; i < nodes.Count; i++)
            {
                double lenght = Math.Sqrt(Math.Pow(temp[i].X - x, 2) + Math.Pow(temp[i].Y - y, 2));
                if (lenght <= 10) 
                { 
                    temp[i].ColorPen = Pens.Blue;
                    for (int j = 0; j < nodes.Count; j++)
                    {
                        double lenght_circles = Math.Sqrt(Math.Pow(temp[i].X - temp[j].X, 2) + Math.Pow(temp[i].Y - temp[j].Y, 2));
                        if (lenght_circles <= 21)
                        {
                            temp[j].ColorPen = Pens.Blue;
                        }
                    }
                }

            }
            if (Changed != null) Changed();
        }
    }
}