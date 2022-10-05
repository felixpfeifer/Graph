namespace graph;

public class Graph
{
    public Graph()
    {
        Map = new List<Edge>();
        Nodes = new List<Node>();
    }

    public List<Edge> Map { get; set; }

    public List<Node> Nodes { get; set; }

    public Node getNodeID(int id)
    {
        if (id < 0) return null;

        return Nodes[id];
    }

    public List<Node> GetNeighborFromNode(Node start)
    {
        var neighbor = new List<Node>();
        foreach (var edge in Map)
            if (edge.Start == start && !neighbor.Contains(edge.End))
                neighbor.Add(edge.End);
            else if (edge.End == start && !neighbor.Contains(edge.Start)) neighbor.Add(edge.Start);

        return neighbor;
    }

    public int LengthEdge(Node start, Node end)
    {
        for (var i = 0; i < Map.Count(); i++)
            if (Map[i].Start == start && Map[i].End == end)
                return Map[i].Length;
            else if (Map[i].Start == end && Map[i].End == start) return Map[i].Length;

        return -1;
    }
}