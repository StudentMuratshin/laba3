using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    interface IModel
    {
        void AddNode(int value);
        void RemoveLastNode();
        int Count { get; }
        IEnumerable<Node> AllNodes { get; }
    }
}
