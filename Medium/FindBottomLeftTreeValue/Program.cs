using FindBottomLeftTreeValue;

public class Solution
{
    private int depthLevel = -1;
    private int leftLeaf = -1;

    public int FindBottomLeftValue(TreeNode root)
    {
        DFS(root, 0);
        return leftLeaf;
    }

    private void DFS(TreeNode root, int level)
    {
        if (root == null) return;

        if (level > depthLevel)
        {
            leftLeaf = root.val;
            depthLevel = level;
        }

        DFS(root.left, level + 1);
        DFS(root.right, level + 1);
    }
}