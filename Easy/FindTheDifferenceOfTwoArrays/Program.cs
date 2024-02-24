public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        IList<IList<int>> listOfDifference = new List<IList<int>>();
        List<int> innerList1 = new List<int>();
        List<int> innerList2 = new List<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j]) counter++;
            }

            if (counter == 0 && !innerList1.Contains(nums1[i]))
            {
                innerList1.Add(nums1[i]);
            }
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j < nums1.Length; j++)
            {
                if (nums2[i] == nums1[j]) counter++;
            }

            if (counter == 0 && !innerList2.Contains(nums2[i]))
            {
                innerList2.Add(nums2[i]);
            }
        }

        listOfDifference.Add(innerList1);
        listOfDifference.Add(innerList2);

        return listOfDifference;
    }
}