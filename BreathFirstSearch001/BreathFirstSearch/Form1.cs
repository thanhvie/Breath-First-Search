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


        //Declare global Graph object call g_graph
        Graph g_graph;

        //declare BFS object
        BFS bfs = new BFS();


        /*load JSON file and put data into hash table
        hashtable(key = "movie" or "actor" string value,
        value = Node object*/
        #region LoadData
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog htv1 = new OpenFileDialog();

                /*declare RootObject and Movie object in order to 
                get data from JSON file*/
                RootObject root = new RootObject();
                Movie[] movies = null;
                g_graph = new Graph();

                if (htv1.ShowDialog() == DialogResult.OK)
                {
                    path_json_file = htv1.FileName;
                    path_directory = Path.GetDirectoryName(path_json_file);
                    path_filename = Path.GetFileNameWithoutExtension(path_json_file);
                    tb1.Text = path_json_file;
                }

                //JSON data will be stored in root
                root = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText(path_json_file));

                //get movie objects and store them into an array
                movies = root.movies.ToArray();

                //for each movie object, do the following loop
                for (int i = 0; i < movies.Length; i++)
                {
                    //assign new value for (movieTitle, titleNode) 
                    string movieTitle = movies[i].title;
                    Node titleNode = new Node(movieTitle);

                    //extract all movie's actors and put into list
                    List<string> cast = movies[i].cast;

                    //declare a new list<node>
                    List<Node> nodes = new List<Node>();

                    //add new (movieTitle, titleNode) into hashtable
                    g_graph.graph.Add(movieTitle, titleNode);

                    //for each movie actor, do the following
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

                            //add edges for titleNode            
                            titleNode.addEdge(m_actorNode);

                            //add (actor,m_actorNode) into hashtable
                            g_graph.graph.Add(actor, m_actorNode);

                        }

                        /*if actor name has already appeared before,
                        we will not create a new node for that actor.
                        Instead, we will scan which node represent for the actor
                        and add that node as edge for the movie node*/
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

                //display all actors name to combobox cbx
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
        #endregion

        #region btnSearch_Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bfs.bfs(g_graph, cbx1, cbx2, tbPath);
        }
        #endregion
    }
}
