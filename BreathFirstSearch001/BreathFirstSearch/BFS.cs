using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreathFirstSearch
{
    class BFS
    {
        //Breath - First Search algorithm
        #region BFS
        public void bfs(Graph graph, ComboBox cbx1, ComboBox cbx2, TextBox tbPath)
        {
            try
            {
                bool found = false;

                //reset
                graph.reset();

                Node start = graph.setStart(cbx1.Text);
                Node end = graph.setEnd(cbx2.Text);

                //declare a queue object which has FIFO property
                Queue<Node> queue = new Queue<Node>();

                start.searched = true;
                queue.Enqueue(start);

                while (queue.Count > 0)
                {
                    Node current = queue.Dequeue();

                    if (current == end)
                    {
                        MessageBox.Show("Found Path");
                        found = true;
                        queue.Clear();
                        break;
                    }

                    List<Node> edges = current.edges;
                    for (int i = 0; i < edges.Count; i++)
                    {
                        Node neighbor = edges[i];
                        if (neighbor.searched == false)
                        {
                            neighbor.searched = true;
                            neighbor.parent = current;
                            queue.Enqueue(neighbor);
                        }
                    }
                }

                if (found == true)
                {
                    string s = null;
                    backtracking(start, end, ref s);
                    tbPath.Text = s;
                }

                if ((queue.Count == 0) && (found == false))
                {
                    MessageBox.Show("Cannot find the path");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex);
            }
        }
        #endregion

        //Backtracking the path
        #region backtracking
        public void backtracking(Node start, Node end, ref string path)
        {
            path = path + " <-- " + end.value;

            if (start.value == end.value)
            {
                //done backtracking
                path = path.Substring(4, path.Length - 4);
                return;
            }

            end = end.parent;
            backtracking(start, end, ref path);
        }
        #endregion
    }
}
