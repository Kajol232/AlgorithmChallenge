using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Challenge1
{
    public class BusRoute
    {
        public int FindRoutes(int[][] routes, int source, int target)
        {
            int min = 0;
            ArrayList list = FindIndex(routes, source);
            foreach(int s in list)
            {
                Node n = DrawTree(routes, new Node(0), source);
                int path = Transverse(n, target);
                if(path < min)
                {
                    min = path;
                }
            }

            return min;

        }

        public int Transverse(Node n, int target)
        {


        }
        public Node DrawTree(int[][] routes,Node n, int source)
        {
            ArrayList list = FindIndex(routes,source);

            foreach(int s in list)
            {
                int index = Array.IndexOf(routes[s], source);
                n.key = (routes[s][index]);
                for(int i = 0; i < routes[s].Length; i++)
                {
                    if(routes[s][i] != n.key)
                    {
                        if (n.left == null)
                        {

                            n.left = new Node(routes[s][i]);
                            DrawTree(routes, n.left, n.left.key);
                        }
                        else
                        {
                            n.right = new Node(routes[s][i]);
                            DrawTree(routes, n.right, n.right.key);
                        }

                    }
                    
                }

            }

            return n;
        }
        private ArrayList FindIndex(int[][] routes, int source)
        {
            ArrayList sourceIndexList = new ArrayList();
            //ArrayList targetIndexList = new ArrayList();
            for (int i = 0; i < routes.Length; i++)
            {
                for (int j = 0; j < routes[i].Length; j++)
                {
                    if (routes[i][j] == source)
                    {
                        sourceIndexList.Add(i);
                        break;
                    }
                }
            }
            return sourceIndexList;
        }
    }

    public class Node
    {
        public int key { get; set; } 
        public Node left { get; set; }
        public Node right { get; set; }

        public Node(int key)
        {
            this.key = key;
            left = null;
            right = null;
        }
    }
}
