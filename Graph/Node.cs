namespace graph;

public class Node
{
    private static int _idCurrent = 0;
    private int _id;

    public Node()
    {
        _id = _idCurrent++;
    }
}