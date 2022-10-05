namespace graph;

public class Edge
{
    private static int _idCurrent;

    public Edge(Node start, Node end, int length)
    {
        Start = start;
        End = end;
        Length = length;
        Id = _idCurrent++;
    }

    public Node Start { get; }

    public Node End { get; }

    public int Length { get; }

    public int Id { get; }
}