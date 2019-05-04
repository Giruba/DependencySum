using System;

namespace DependencySumInGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Sum in a Graph!");
            Console.WriteLine("--------------------------");

            Graph graph = GraphUtility.ConstructGraphFromUserInput();
            Console.WriteLine("Dependency Sum in the graph is " +
                ""+GraphUtility.GetDependencySum(graph));

            Console.ReadLine();
        }
    }
}
