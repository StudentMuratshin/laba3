using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    interface IModel
    {
        event Action Changed;
        LinkedList<Node> AllNodes { get; }
        void AddNode(int value);
        void RemoveLastNode();
        void RemoveNode(Node node);
        int Count { get; }
        void ChangeColor(int x,int y);
    }
}