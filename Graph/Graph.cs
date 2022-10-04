namespace graph;

public class Graph
{
    private List<Edge> _map;
    private List<Node> _nodes;

    public Graph()
    {
        _map = new List<Edge>();
        _nodes = new List<Node>();
    }
}