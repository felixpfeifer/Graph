namespace graph;

public class Edge
{
    private static int _idCurrent = 0;
    
    private Node _start;
    private Node _end;
    private int _length;
    private int _id;

    public Edge(Node start, Node end,int length)
    {
        _start = start;
        _end = end;
        _length = length;
        _id = _idCurrent++;
    }

}