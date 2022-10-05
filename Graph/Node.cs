namespace graph;

public class Node
{
    private static int _idCurrent;
    private readonly int _id;

    public Node()
    {
        _id = _idCurrent++;
    }

    public int GetId()
    {
        return _id;
    }
}