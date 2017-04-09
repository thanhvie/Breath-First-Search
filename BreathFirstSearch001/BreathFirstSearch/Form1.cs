using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BreathFirstSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path_json_file = "";
        string path_directory = "";
        string path_filename = "";
      

        //Declare global variables
       
        Graph g_graph = new Graph();
        

        /*get JSON and put data into hash table
        hashtable(key = "movie" or "actor" value,
        value = Node according to key value*/

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog htv1 = new OpenFileDialog();
                RootObject root = new RootObject();
                Movie[] movies = null;

                if (htv1.ShowDialog() == DialogResult.OK)
                {
                    path_json_file = htv1.FileName;
                    path_directory = Path.GetDirectoryName(path_json_file);
                    path_filename = Path.GetFileNameWithoutExtension(path_json_file);
                    tb1.Text = path_json_file;
                }

                root = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText(path_json_file));
                movies = root.movies.ToArray();

                for (int i = 0; i < movies.Length; i++)
                {
                    //create new movie node
                    string movieTitle = movies[i].title;
                    Node titleNode = new Node(movieTitle);

                    List<string> cast = movies[i].cast;
                    List<Node> nodes = new List<Node>();

                    //add movieTitle to hashtable
                    g_graph.graph.Add(movieTitle, titleNode);

                    for (int j = 0; j < cast.Count; j++)
                    {
                        string actor = cast[j];

                        /*if actor name not appear before,
                        add new actor node */
                        if (!g_graph.actorName.Contains(actor))
                        {
                            //create new node
                            Node m_actorNode = new Node(actor);

                            //add actor name into list string for latest update
                            g_graph.actorName.Add(actor);

                            //add new node into list of nodes
                            g_graph.nodes.Add(m_actorNode);

                            //add edges             
                            titleNode.addEdge(m_actorNode);

                            //add node to hashtable
                            g_graph.graph.Add(actor, m_actorNode);

                        }

                        else
                        {
                            foreach (Node n in g_graph.nodes)
                            {
                                if (n.value == actor)
                                {
                                    //add edges with existing node
                                    titleNode.addEdge(n);
                                }
                            }
                        }
                    }
                }

                //display all actor name to cbx
                for (int i = 0; i < g_graph.nodes.Count; i++)
                {
                    cbx1.Items.Add(g_graph.nodes[i].value);
                    cbx2.Items.Add(g_graph.nodes[i].value);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex);
            }
        }


        private void cbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //reset g_graph
                g_graph.reset();
                bool found = false;

                Node start = g_graph.setStart(cbx1.Text);
                Node end = g_graph.setEnd(cbx2.Text);

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

                if((queue.Count == 0) && (found == true))
                {
                    MessageBox.Show("Cannot find the path");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex);
            }
        }

        public void fpath (Node start, Node end, ref string path)
        {
            path = path + " " + end.value;
            
            if(start.value == end.value)
            {
                MessageBox.Show("Found Connection Path");
                return;
            }

            end = end.parent;
            fpath(start, end, ref path);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string s = null;
            fpath(g_graph.setStart(cbx1.Text), g_graph.setEnd(cbx2.Text),ref s);
            tbPath.Text = s;
        }
    }
}
