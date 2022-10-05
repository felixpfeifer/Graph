namespace graph;

public class PathAlgo
{
    private const int MaxValue = 0xFFFFFFF;

    private readonly LinkedList<LinkedList<Node>> Paths = new();


    private Node MindDist(List<int> dist, List<Node> stack, List<Node> allNodes)
    {
        var min = MaxValue;
        Node index = null;
        for (var i = 0; i < dist.Count(); i++)
            if (dist[i] < min && stack.Contains(allNodes[i]))
            {
                min = dist[i];
                index = allNodes[i];
            }

        return index;
    }

    public void PrintPaths(Graph graph)
    {
        foreach (var path in Paths)
        {
            Console.WriteLine("Start\tLength\tTarget");
            for (var i = 0; i < path.Count(); i++)
                if (i + 1 < path.Count())
                {
                    var start = path.ElementAt(i);
                    var target = path.ElementAt(i + 1);
                    Console.Write(start.GetId() + "\t" + graph.LengthEdge(start, target) + "\t" + target.GetId() +
                                  "\n");
                }

            Console.Write("\n");
        }
    }

    public void FindPath(Graph graph, Node start)
    {
        var V = graph.Nodes.Count();
        var stack = new List<Node>();
        var dist = new List<int>();
        var prev = new List<Node>();


        for (var i = 0; i < V; i++)
        {
            dist.Add(MaxValue);
            prev.Add(null);
            stack.Add(graph.Nodes[i]);
        }

        dist[start.GetId()] = 0;

        while (stack.Count() != 0)
        {
            var node = MindDist(dist, stack, graph.Nodes);
            // Remove the node from the stack
            stack.Remove(node);
            // Skip if start Node equal node from stack
            foreach (var neighbor in graph.GetNeighborFromNode(node))
            {
                if (!stack.Contains(neighbor)) continue;

                var alt = dist[node.GetId()] + graph.LengthEdge(node, neighbor);
                if (alt < dist[neighbor.GetId()])
                {
                    dist[neighbor.GetId()] = alt;
                    prev[neighbor.GetId()] = node;
                }
            }

            var target = node;
            var path = new LinkedList<Node>();
            if (prev[target.GetId()] != null || node.GetId() == start.GetId())
                while (target != null)
                {
                    path.AddFirst(target);
                    target = prev[target.GetId()];
                }

            Paths.AddLast(path);
        }
    }
}