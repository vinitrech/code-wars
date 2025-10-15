namespace katas.CanYouGetTheLoop;

public class CanYouGetTheLoopKata
{
    public static int GetLoopSize(Node startNode)
    {
        var currentNode = startNode;
        var nodeDictionary = new Dictionary<Node, int>();
        var index = 0;

        while (true)
        {
            if (!nodeDictionary.ContainsKey(currentNode!.GetNext()!))
            {
                nodeDictionary.Add(currentNode, index++);
                currentNode = currentNode.GetNext();
            }
            else
                return nodeDictionary.Count - nodeDictionary[currentNode.GetNext()!] + 1;
        }
    }
}

public class Node
{
    private Node? Next;

    public Node? GetNext()
    {
        return Next;
    }

    private void SetNext(Node next)
    {
        Next = next;
    }

    public static Node CreateChain(int tailSize, int loopSize)
    {
        var prevNode = new Node();
        var start = prevNode;

        start.SetNext(start);

        if (loopSize == 1)
            return start;

        for (int i = 1; i <= tailSize; ++i)
        {
            prevNode?.SetNext(new Node());
            prevNode = prevNode?.GetNext();
        }

        var endLoop = prevNode;

        for (int i = 1; i < loopSize; ++i)
        {
            prevNode?.SetNext(new Node());
            prevNode = prevNode?.GetNext();
        }

        prevNode?.SetNext(endLoop!);

        return start;
    }
}
