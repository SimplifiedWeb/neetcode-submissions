public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) {
            return false;
        }else {
            
            int[] arr = new int[26];
            
            for(int i = 0; i < s.Length; i++) {
                arr[s[i] - 'a']++;
            }

            for(int j = 0; j < t.Length; j++) {
                arr[t[j] - 'a']--;
            }

            foreach(int data in arr) {
                if(data == 1 || data > 1) return false;
            }

            return true;

        }
        
    }
}
