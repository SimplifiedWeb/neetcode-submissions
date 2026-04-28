public class Solution {
    public bool hasDuplicate(int[] nums) {
        int count = 0;

        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                if (nums[j] == nums[i] && i != j) {
                    count++;
                }
            }
        }

        if (count > 1) {
            return true;
        } else {
            return false;
        }
    }
}