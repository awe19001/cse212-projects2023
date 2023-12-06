public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

   public void Insert(int value) {
    if (value == Data) {
        // Ignore duplicate values (you can also choose to handle them differently)
        return;
    }

    if (value < Data) {
        // Insert to the left
        if (Left is null)
            Left = new Node(value);
        else
            Left.Insert(value);
    }
    else {
        // Insert to the right
        if (Right is null)
            Right = new Node(value);
        else
            Right.Insert(value);
    }
}

    public bool Contains(int value) {
        if (value == Data) {
            // Value found in the current node
            return true;
        }

        if (value < Data && Left != null) {
            // Search in the left subtree
            return Left.Contains(value);
        }
        else if (value > Data && Right != null) {
            // Search in the right subtree
            return Right.Contains(value);
        }

        // Value not found
        return false;
    }

    public int GetHeight() {
        int leftHeight = (Left != null) ? Left.GetHeight() : 0;      //recursively calculate the height of the left and right subtrees.
        int rightHeight = (Right != null) ? Right.GetHeight() : 0;   // finds the maximum height between the left and right subtrees.

        // Return 1 plus the maximum height of either subtree
        return 1 + Math.Max(leftHeight, rightHeight);  //gives the height of the current subtree.
    }
}