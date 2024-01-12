using System;

class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

class BinaryTree
{
    Node root;
    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int key)
    {
        root = InsertRec(root, key);
    }
 
    Node InsertRec(Node root, int key)
    {
        if (root == null)
        {
            root = new Node(key);
            return root;
        }
 
        if (key < root.data)
            root.left = InsertRec(root.left, key);
        else if (key > root.data)
            root.right = InsertRec(root.right, key);
 
        return root;
    }

    public void DeleteKey(int key)
    {
        root = DeleteRec(root, key);
    }

    Node DeleteRec(Node root, int key)
    {
        if (root == null) return root;
 
        if (key < root.data)
            root.left = DeleteRec(root.left, key);
        else if (key > root.data)
            root.right = DeleteRec(root.right, key);
 
        else
        {
            if (root.left == null)
                return root.right;
            else if (root.right == null)
                return root.left;
 
            root.data = MinValue(root.right);
 
            root.right = DeleteRec(root.right, root.data);
        }
 
        return root;
    }

    int MinValue(Node root)
    {
        int minv = root.data;
        while (root.left != null)
        {
            minv = root.left.data;
            root = root.left;
        }
        return minv;
    }

    public bool Search(int key)
    {
        return SearchRec(root, key);
    }
 
    bool SearchRec(Node root, int key)
    {
        if (root == null)
            return false;
 
        if (root.data == key)
            return true;
 
        if (root.data > key)
            return SearchRec(root.left, key);
 
        return SearchRec(root.right, key);
    }

    public void Inorder()
    {
        InorderRec(root);
    }
 
    void InorderRec(Node root)
    {
        if (root != null)
        {
            InorderRec(root.left);
            Console.Write(root.data + " ");
            InorderRec(root.right);
        }
    }

    public void Preorder()
    {
        PreorderRec(root);
    }
 
    void PreorderRec(Node root)
    {
        if (root != null)
        {
            Console.Write(root.data + " ");
            PreorderRec(root.left);
            PreorderRec(root.right);
        }
    }

    public void Postorder()
    {
        PostorderRec(root);
    }

    void PostorderRec(Node root)
    {
        if (root != null)
        {
            PostorderRec(root.left);
            PostorderRec(root.right);
            Console.Write(root.data + " ");
        }
    }

    public int CountAllNodes()
    {
        return CountAllNodesRec(root);
    }

    int CountAllNodesRec(Node root)
    {
        if (root == null)
            return 0;

        return 1 + CountAllNodesRec(root.left) + CountAllNodesRec(root.right);
    }

    public int CountLeafNodes()
    {
        return CountLeafNodesRec(root);
    }

    int CountLeafNodesRec(Node root)
    {
        if (root == null)
            return 0;
        if (root.left == null && root.right == null)
            return 1;
        return CountLeafNodesRec(root.left) + CountLeafNodesRec(root.right);
    }
}

class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();

        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(70);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("Inorder traversal:");
        tree.Inorder();

        Console.WriteLine("\n\nDelete 20");
        tree.DeleteKey(20);
        Console.WriteLine("Inorder traversal after deletion:");
        tree.Inorder();

        Console.WriteLine("\n\nSearch 40");
        if (tree.Search(40))
            Console.WriteLine("40 found");
        else
            Console.WriteLine("40 not found");

        Console.WriteLine("\n\nCount of all nodes: " + tree.CountAllNodes());
        Console.WriteLine("\nCount of leaf nodes: " + tree.CountLeafNodes());
    }
}
