using System;
using System.Collections.Generic;
using System.Text;

namespace DependencySumInGraph
{
    class Graph
    {
        int noVertices;
        LinkedList<int>[] adjacencyList;

        public Graph(int verticeCount) {
            noVertices = verticeCount;
            adjacencyList = new LinkedList<int>[noVertices];
        }

        public int GetGraphVertices() {
            return noVertices;
        }

        public LinkedList<int>[] GetGraphAdjacencyList() {
            return adjacencyList;
        }

        public void SetGraphVerticeCount(int value) {
            noVertices = value;
        }

        public void SetGraphAdjacencyList(LinkedList<int>[] linkedListNodes) {
            adjacencyList = linkedListNodes;
        }

        public void AddEdge(int startVertex, int endVertex) {
            if (adjacencyList[startVertex] == null) {
                adjacencyList[startVertex] = new LinkedList<int>();
            }
            adjacencyList[startVertex].AddLast(endVertex);
        }

        public LinkedList<int> GetAjacencyListOfvertex(int vertex) {
            return adjacencyList[vertex];
        }

    }
}
