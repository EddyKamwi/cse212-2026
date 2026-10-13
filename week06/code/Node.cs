public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    private HashSet<int> TransverseTree(Node root, HashSet<int>? setTree = null)
    {
        if (setTree is null) { setTree = new HashSet<int>(); }
        // base case
        if (root is null) { return setTree; }

        setTree.Add(root.Data);
        TransverseTree(root.Left!, setTree);
        TransverseTree(root.Right!, setTree);
        return setTree;
    }



    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value != Data)
        {
            if (value < Data)
            {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data) { return true; }

        if (value < Data)
        {
            if(Left is not null)
                return Left.Contains(value);
        }
        else if (value > Data)
        {
            if(Right is not null)
                return Right.Contains(value);
        }
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}