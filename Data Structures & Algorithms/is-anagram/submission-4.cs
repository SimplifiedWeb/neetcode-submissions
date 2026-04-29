public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) {
            return false;
        }else {
            
            int[] arr1 = new int[26];
            int[] arr2 = new int[26];

            for(int i = 0; i < s.Length; i++) {
                arr1[s[i] - 'a']++;
            }

            for(int j = 0; j < t.Length; j++) {
                arr2[t[j] - 'a']++;
            }

            for(int k = 0; k < 26; k++) {
                if(arr1[k] != arr2[k] ) {
                    return false;
                }
            }
            return true;
        }
        
    }
}
