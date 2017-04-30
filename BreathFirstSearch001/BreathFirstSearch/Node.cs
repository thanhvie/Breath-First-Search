using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathFirstSearch
{
    public class Node
    {
        public string value;
        public List<Node> edges;
        public bool searched;
        public Node parent;

        public Node(string val)
        {
            value = val;
            edges = new List<Node>();
            searched = false;
            parent = null;
        }

        public void reset()
        {
            searched = false;
            parent = null;
        }

        public void addEdge(Node neighbor)
        {
            edges.Add(neighbor);
            neighbor.edges.Add(this);
        }
    }
}
