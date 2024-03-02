
using FindBottomLeftTreeValue;

public class Solution {
    public int FindBottomLeftValue(TreeNode root)
    {
        int leftMostValue = root.val;

        if (root != null)
        {

            var leftNode = root.left.val;
            if (leftNode != null)
            {
                leftMostValue = leftNode;
            }


            FindBottomLeftValue(root.left) && FindBottomLeftValue(root.right);
        }

        return leftMostValue;
    }
}