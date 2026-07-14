public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> h = new HashSet<char>();
        int temp = 0, count = 0, start = 0, i = 0;

        while (i < s.Length) {
            if (!h.Contains(s[i])) {
                h.Add(s[i]);
                temp++;
                count = Math.Max(count, temp);
                i++;
            }
            else {
                h.Clear();   // restart
                start++;
                i = start;
                temp = 0;
            }
        }
        return count;
    }
}