public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length) return "";

        int[] freq = new int[128];

        for (int i = 0; i < t.Length; i++)
        {
            freq[t[i]]++;
        }

        int[] seen = new int[128];

        int start = 0;
        int matched = 0;

        int minStart = 0;
        int minLength = int.MaxValue;

        for (int end = 0; end < s.Length; end++)
        {
            char current = s[end];

            seen[current]++;

            // We needed this occurrence
            if (seen[current] <= freq[current])
            {
                matched++;
            }

            // We have all characters from t
            while (matched == t.Length)
            {
                int length = end - start + 1;

                if (length < minLength)
                {
                    minLength = length;
                    minStart = start;
                }

                char removed = s[start];

                seen[removed]--;

                // We removed a character that was actually required
                if (seen[removed] < freq[removed])
                {
                    matched--;
                }

                start++;
            }
        }

        return minLength == int.MaxValue
            ? ""
            : s.Substring(minStart, minLength);
    }
}