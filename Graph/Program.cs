namespace graph;

public class graph
{
    public static void Main(string[] args)
    {
        PathAlgoTest();
    }

    private static void PathAlgoTest()
    {
        var graph = new Graph();
        var nodes = new List<Node>();
        var edges = new List<Edge>();
        for (var i = 0; i < 5; i++) nodes.Add(new Node());
        edges.Add(new Edge(nodes[0], nodes[1], 2));
        edges.Add(new Edge(nodes[0], nodes[2], 2));
        edges.Add(new Edge(nodes[1], nodes[2], 10));
        edges.Add(new Edge(nodes[2], nodes[3], 2));
        edges.Add(new Edge(nodes[1], nodes[4], 20));

        graph.Map = edges;
        graph.Nodes = nodes;

        var path = new PathAlgo();
        path.FindPath(graph, nodes[0]);
        path.PrintPaths(graph);
    }
}