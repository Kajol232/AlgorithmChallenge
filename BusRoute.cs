using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Challenge1
{
    public class BusRoute
    {
        public static int FindRoutes(int[][] routes, int source, int target)
        {
            int min = 0;
            ArrayList list = FindIndex(routes, source, 0);
            foreach(int s in list)
            {
                Node n = new Node(source);
                DrawTree(routes, n, n.key, 0);
                int path = Transverse(n, target);
                if(path < min)
                {
                    min = path;
                }
            }

            return min;

        }

        private static int Transverse(Node n, int target)
        {
            return 0;

        }
        private static void DrawTree(int[][] routes,Node n, int source, int row)
        {
            ArrayList list = FindIndex(routes,source, row);

            foreach(int s in list)
            {
                int index = Array.IndexOf(routes[s], source);
                if(index !< 0)
                {
                    n.key = routes[s][index];
                    Console.WriteLine(n.ToString());
                    for (int i = 0; i < routes[s].Length; i++)
                    {
                        if (routes[s][i] != n.key)
                        {
                            if (n.left == null)
                            {

                                n.left = new Node(routes[s][i]);
                                DrawTree(routes, n.left, n.left.key, 2);
                            }
                            else
                            {
                                n.right = new Node(routes[s][i]);
                                DrawTree(routes, n.right, n.right.key, 2);
                            }

                        }

                    }

                }
                
               

            }
        }
        private static ArrayList FindIndex(int[][] routes, int source, int row)
        {
            ArrayList sourceIndexList = new ArrayList();
            //ArrayList targetIndexList = new ArrayList();
            for (int i = row; i < routes.Length; i++)
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
