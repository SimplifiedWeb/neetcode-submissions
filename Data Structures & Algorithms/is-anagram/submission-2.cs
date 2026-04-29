public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var A = s.OrderBy(c => c).ToArray();
        var B = t.OrderBy(c => c).ToArray();

        for (int i = 0; i < A.Length; i++) {
            if (A[i] != B[i]) {
                return false;
            }
        }
       return true;
    }
}
