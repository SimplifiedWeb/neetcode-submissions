public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> map = new HashSet<int>();

        int count = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (!map.Contains(nums[i])) {
                map.Add(nums[i]);
            } else {
                count++;
            }
        }

        if (count > 0) {
            return true;
        } else {
            return false;
        }
    }
}