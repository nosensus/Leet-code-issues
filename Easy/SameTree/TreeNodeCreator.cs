namespace SameTree;

public class TreeNodeCreator
{
    public static TreeNode Create(int?[] nodes)
    {
        if (nodes.Length == 0)
        {
            throw new InvalidOperationException("Nodes can not be null");
        }

        var root = new TreeNode(nodes[0]!.Value);

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        for (int i = 1; i < nodes.Length; i += 2)
        {
            TreeNode parent = queue.Dequeue();

            int? left = nodes[i];
            if (left is not null)
            {
                parent.left = new TreeNode(left.Value);
                queue.Enqueue(parent.left);
            }

            if (i + 1 < nodes.Length)
            {
                int? right = nodes[i + 1];
                if (right is not null)
                {
                    parent.right = new TreeNode(right.Value);
                    queue.Enqueue(parent.right);
                }
            }
        }

        return root;
    }
}