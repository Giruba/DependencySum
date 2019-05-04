using System;
using System.Collections.Generic;
using System.Text;

namespace DependencySumInGraph
{
    class GraphUtility
    {
        public static Graph ConstructGraphFromUserInput() {
            Graph graph = null;
            Console.WriteLine("Enter the number of vertices in the" +
                " graph");
            try {
                int numberVertices = int.Parse(Console.ReadLine().Trim());
                graph = new Graph(numberVertices);
                Console.WriteLine("Enter the Adjacency List of every vertex" +
                    " separated by space, comma or semi-colon ");
                for (int index = 0; index < numberVertices; index++) {
                    Console.WriteLine("Enter the adjacency ist of vertex " + (index + 1));
                    String[] elements = Console.ReadLine().Trim().Split(' ', ',', ';');
                    for (int vertex = 0; vertex < elements.Length; vertex++)
                    {
                        graph.AddEdge(index, vertex);
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is " + exception.Message);
            }


            return graph;
        }

        public static int GetDependencySum(Graph graph) {
            if (graph == null ||
                (graph != null && graph.GetGraphVertices() == 0)) {
                Console.WriteLine("Graph is empty!");
                return 0;
            }

            int dependencySum = 0;
            for (int vertexIndex = 0; vertexIndex < graph.GetGraphVertices(); vertexIndex++) {
                dependencySum += graph.GetAjacencyListOfvertex(vertexIndex).Count;
            }
            return dependencySum;
        }
    }
}
