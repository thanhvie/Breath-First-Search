using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathFirstSearch
{
    public class Graph
    {
        public List<Node> nodes;
        public List<string> actorName;
        public Hashtable graph = new Hashtable();
        public Node start;
        public Node end;

        public Graph()
        {
            nodes = new List<Node>();
            actorName = new List<string>();
        }

        public void reset()
        {
            for(int i = 0; i<nodes.Count; i++)
            {
                nodes[i].searched = false;
                nodes[i].parent = null;
            }

            //nodes.Clear();
        }

        public Node setStart(string actor)
        {
            start = (Node)graph[actor];
            return start;
        }

        public Node setEnd(string actor)
        {
            end = (Node)graph[actor];
            return end;
        }
    }
}
